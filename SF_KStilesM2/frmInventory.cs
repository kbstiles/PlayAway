using System;
using System.Data;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace SF_KStilesM2
{
    /// <summary>
    /// Form that is used to view, add, edit and remove items from inventory.
    /// </summary>
    public partial class frmInventory : Form
    {
        //Variables
        public string fileName = "null",
            restocksNeeded = null;

        public bool editItemNameValidBool = true,
            itemNameChangedBool = false,
            editItemDescriptionValidBool = true,
            itemDescriptionChangedBool = false,
            editRetailPriceValidBool = true,
            retailPriceChangedBool = false,
            editQuantityValidBool = true,
            quantityChangedBool = false,
            editRestockThresholdValidBool = true,
            restockThresholdChangedBool = false,
            editImageValidBool = true,
            imageChangedBool = false,
            addItemNameValidBool = false,
            addItemDescriptionValidBool = false,
            addCategoryValidBool = false,
            addRetailPriceValidBool = false,
            addCostValidBool = false,
            addQuantityValidBool = false,
            addRestockThresholdValidBool = false,
            addImageValidBool = true;

        public Thread inventoryDataThread;

        public System.Windows.Forms.Timer inventoryTimer = new System.Windows.Forms.Timer(),
            displayTimer = new System.Windows.Forms.Timer();

        public DataRow row = null;

        public int categoryID;

        private double ZOOMFACTOR = 1.75;

        private int MINMAX = 2;

        bool mousePressed = false;

        float shiftedX,
            shiftedY;

        int usedX,
            usedY;

        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            CbxSetup();            
        }

        //checks if form is visible and starts timer
        private void frmInventory_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                inventoryTimer.Interval = 500;
                inventoryTimer.Tick += new EventHandler(inventoryTimer_Tick);

                displayTimer.Interval = 250;
                displayTimer.Tick += new EventHandler(displayTimer_Tick);

                displayTimer.Start();
            }
        }

        private void frmInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void inventoryTimer_Tick(object sender, EventArgs e)
        {
            inventoryTimer.Stop();
            SetAllTrue();
            RestockChecker();            
            inventoryTimer.Dispose();
        }

        /// <summary>
        /// Used to update the inventory through threading and timers.
        /// </summary>
        private void InventoryRefresh()
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                inventoryDataThread = new Thread(new ThreadStart(delegate
                {
                    SafeManagerDgvSetup();
                }));

                inventoryTimer.Stop();
                inventoryDataThread.Start();
                inventoryTimer.Start();
            });
        }

        /// <summary>
        /// Determines if invoking is needed and makes thread safe.
        /// </summary>
        public void SafeManagerDgvSetup()
        {
            if (this.dgvInventory.InvokeRequired)
            {
                Action safeWrite = delegate { SafeManagerDgvSetup(); };
                this.dgvInventory.Invoke(safeWrite);
            }
            else
            {
                InventoryDgvSetup();
            }
        }

        public void displayTimer_Tick(object sender, EventArgs e)
        {
            displayTimer.Stop();
            SetAllFalse();
            InventoryRefresh();
            displayTimer.Dispose();
        }

        /// <summary>
        /// Checks if any items quantity is below restock threshold and alerts user.
        /// </summary>
        private void RestockChecker()
        {
            restocksNeeded = null;
            foreach (DataGridViewRow dataRow in dgvInventory.Rows)
            {
                if (Convert.ToInt32(dataRow.Cells["Quantity"].Value) < Convert.ToInt32(dataRow.Cells["RestockThreshold"].Value))
                {
                    restocksNeeded += dataRow.Cells["ItemName"].Value.ToString() + ", ";
                }
            }

            if (!string.IsNullOrEmpty(restocksNeeded))
            {
                restocksNeeded = restocksNeeded.Remove(restocksNeeded.Length - 2);

                MessageBox.Show("Items Needing Restock: " + restocksNeeded);
            }                
        }

        /// <summary>
        /// Used to setup and link the data grid view with the database inventory.
        /// </summary>
        private void InventoryDgvSetup()
        {
            dgvInventory.AutoGenerateColumns = false;

            if (dgvInventory.DataSource == null)
            {
                dgvInventory.DataSource = Program._bsItems;
            }

            dgvInventory.ClearSelection();
            dgvInventory.Rows[0].Selected = true;
            byte[] bytes = null;
            row = clsSQL.DTInventoryTable.Rows[0];
            btnModifyItem.Enabled = true;
            btnRemoveItem.Enabled = true;

            pbxItemImage.Width = pnlImage.Width;
            pbxItemImage.Height = pnlImage.Height;

            if (row["ItemImage"] != DBNull.Value)
            {
                bytes = (byte[])row["ItemImage"];

                if (pbxItemImage.Image != null)
                {
                    pbxItemImage.Image.Dispose();
                }

                pbxItemImage.Image = clsImage.ByteArrayToImage(bytes);
            }
            else
            {
                pbxItemImage.Image = null;
            }
        }

        //checks if new item has been selected and updates image
        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] bytes = null;
            try
            {
                for (int i = 0; i < clsSQL.DTInventoryTable.Rows.Count; i++)
                {
                    row = clsSQL.DTInventoryTable.Rows[i];
                    if (Convert.ToInt32(dgvInventory[0, e.RowIndex].Value) == Convert.ToInt32(row.Field<Int64>("InventoryID").ToString()))
                    {
                        btnModifyItem.Enabled = true;
                        btnRemoveItem.Enabled = true;

                        pbxItemImage.Width = pnlImage.Width;
                        pbxItemImage.Height = pnlImage.Height;

                        if (row["ItemImage"] != DBNull.Value)
                        {
                            bytes = (byte[])row["ItemImage"];

                            if (pbxItemImage.Image != null)
                            {
                                pbxItemImage.Image.Dispose();
                            }

                            pbxItemImage.Image = clsImage.ByteArrayToImage(bytes);
                        }
                        else
                        {
                            pbxItemImage.Image = null;
                        }

                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You chose a header");
            }
        }

        /// <summary>
        /// Sets form functionality to false.
        /// </summary>
        public void SetAllFalse()
        {
            btnAddItem.Enabled = false;
            btnModifyItem.Enabled = false;
            btnRemoveItem.Enabled = false;
            btnPrintInventory.Enabled = false;
            btnMain.Enabled = false;
        }

        /// <summary>
        /// Sets form functionality to true.
        /// </summary>
        public void SetAllTrue()
        {
            btnAddItem.Enabled = true;
            btnPrintInventory.Enabled = true;
            btnMain.Enabled = true;
        }

        //handles the setup of the ComboBox
        public void CbxSetup()
        {
            foreach (clsCategory category in Program.categoryList)
            {
                cbxCategories.Items.Add(category.categoryName);
            }
            cbxCategories.Refresh();
        }

        //shows the user the add item page
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            btnPrintInventory.Enabled = false;
            btnMain.Enabled = false;
            pbxItemImage.Image = null;
            pnlAdd.Visible = true;
            pnlAdd.AutoScroll = false;
            pnlAdd.HorizontalScroll.Enabled = false;
            pnlAdd.HorizontalScroll.Visible = false;
            pnlAdd.HorizontalScroll.Maximum = 0;
            pnlAdd.AutoScroll = true;
        }

        //checks for item name changes and validity
        private void tbxAddItemNameActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateItemName(tbxAddItemNameActual.Text))
            {
                lblValidAddItemName.ForeColor = Color.Green;
                lblValidAddItemName.Text = "O";
                addItemNameValidBool = true;
            }
            else
            {
                lblValidAddItemName.ForeColor = Color.Red;
                lblValidAddItemName.Text = "X";
                addItemNameValidBool = false;
            }
        }

        //checks for item description changes and validity
        private void tbxAddItemDescriptionActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateItemDescription(tbxAddItemDescriptionActual.Text))
            {
                lblValidAddItemDescription.ForeColor = Color.Green;
                lblValidAddItemDescription.Text = "O";
                addItemDescriptionValidBool = true;
            }
            else
            {
                lblValidAddItemDescription.ForeColor = Color.Red;
                lblValidAddItemDescription.Text = "X";
                addItemDescriptionValidBool = false;
            }
        }

        //checks for item category changes and validity
        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategories.SelectedIndex != -1)
            {
                lblValidAddCategory.ForeColor = Color.Green;
                lblValidAddCategory.Text = "O";
                addCategoryValidBool = true;
            }
            else
            {
                lblValidAddCategory.ForeColor = Color.Red;
                lblValidAddCategory.Text = "X";
                addCategoryValidBool = false;
            }
        }

        //checks for retail price changes and validity
        private void tbxAddRetailPriceActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateItemRetailPrice(tbxAddRetailPriceActual.Text))
            {
                lblValidAddRetailPrice.ForeColor = Color.Green;
                lblValidAddRetailPrice.Text = "O";
                addRetailPriceValidBool = true;
            }
            else
            {
                lblValidAddRetailPrice.ForeColor = Color.Red;
                lblValidAddRetailPrice.Text = "X";
                addRetailPriceValidBool = false;
            }
        }

        //Only allows certain keys to be pressed for retail price
        private void tbxAddRetailPriceActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || (int)e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        //checks for cost changes and validity
        private void tbxAddCostActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateItemRetailPrice(tbxAddCostActual.Text))
            {
                lblValidAddCost.ForeColor = Color.Green;
                lblValidAddCost.Text = "O";
                addCostValidBool = true;
            }
            else
            {
                lblValidAddCost.ForeColor = Color.Red;
                lblValidAddCost.Text = "X";
                addCostValidBool = false;
            }
        }

        //only allows certain keys to be pressed for cost
        private void tbxAddCostActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || (int)e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }       

        //checks for quantity changes and validity
        private void tbxAddQuantityActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateItemQuantity(tbxAddQuantityActual.Text))
            {
                lblValidAddQuantity.ForeColor = Color.Green;
                lblValidAddQuantity.Text = "O";
                addQuantityValidBool = true;
            }
            else
            {
                lblValidAddQuantity.ForeColor = Color.Red;
                lblValidAddQuantity.Text = "X";
                addQuantityValidBool = false;
            }
        }

        //only allows for certain keys to be pressed for quantity
        private void tbxAddQuantityActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        /// <summary>
        /// Allows user to zoom in on image.
        /// </summary>
        private void ZoomIn()
        {
            if ((pbxItemImage.Width < (MINMAX * pnlImage.Width)) && (pbxItemImage.Height < (MINMAX * pnlImage.Height)))
            {
                pbxItemImage.Width = Convert.ToInt32(pbxItemImage.Width * ZOOMFACTOR);
                pbxItemImage.Height = Convert.ToInt32(pbxItemImage.Height * ZOOMFACTOR);

                pbxItemImage.Location = new Point(-Convert.ToInt32(shiftedX), -Convert.ToInt32(shiftedY));
            }
        }

        /// <summary>
        /// Handles zooming out of image.
        /// </summary>
        private void ZoomOut()
        {
            if ((pbxItemImage.Width > (pnlImage.Width / MINMAX)) && (pbxItemImage.Height > (pnlImage.Height / MINMAX)))
            {
                pbxItemImage.Width = Convert.ToInt32(pbxItemImage.Width / ZOOMFACTOR);
                pbxItemImage.Height = Convert.ToInt32(pbxItemImage.Height / ZOOMFACTOR);

                pbxItemImage.Location = new Point(0, 0);
            }
        }

        //checks if mouse is pressed and zooms in
        private void pbxItemImage_MouseDown(object sender, MouseEventArgs e)
        {
            mousePressed = true;
            ZoomIn();
        }

        //checks for mouse movement and moves image accordingly
        private void pbxItemImage_MouseMove(object sender, MouseEventArgs e)
        {
            int cursX = this.PointToClient(Cursor.Position).X - pnlImage.Location.X,
                cursY = this.PointToClient(Cursor.Position).Y - pnlImage.Location.Y;

            if (mousePressed)
            {
                if (cursX > 0 && cursX < pnlImage.Width && cursY > 0 && cursY < pnlImage.Height)
                {
                    //calculates where mouse is in pbxItemImage
                    Point imageMouse = new Point(cursX, cursY);

                    //grabs zoomed in coordinates
                    shiftedX = imageMouse.X * .75f;
                    shiftedY = imageMouse.Y * .75f;

                    //sets used coordinates
                    usedX = -Convert.ToInt32(shiftedX);
                    usedY = -Convert.ToInt32(shiftedY);

                    //sets location of image                
                    pbxItemImage.Location = new Point(usedX, usedY);
                }
            }
        }

        //checks if mouse button is released and zooms out
        private void pbxItemImage_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
            ZoomOut();
        }

        //checks for restock threshold changes and validity
        private void tbxAddRestockThresholdActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateItemRestockThreshold(tbxAddRestockThresholdActual.Text))
            {
                lblValidAddRestockThreshold.ForeColor = Color.Green;
                lblValidAddRestockThreshold.Text = "O";
                addRestockThresholdValidBool = true;
            }
            else
            {
                lblValidAddRestockThreshold.ForeColor = Color.Red;
                lblValidAddRestockThreshold.Text = "X";
                addRestockThresholdValidBool = false;
            }
        }

        //Only allows for certain keys to be pressed for restock threshold
        private void tbxAddRestockThresholdActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        //Allows user to add image and checks for validity
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = fileDialog.FileName;

                if (clsValidation.ValidateImage(fileName))
                {
                    lblValidAddImage.ForeColor = Color.Green;
                    lblValidAddImage.Text = "O";
                    addImageValidBool = true;

                }
                else
                {
                    lblValidAddImage.ForeColor = Color.Red;
                    lblValidAddImage.Text = "X";
                    addImageValidBool = false;
                    fileName = "null";
                }
            }
        }

        //clears item info and hides page
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            tbxAddItemNameActual.Clear();
            tbxAddItemDescriptionActual.Clear();
            cbxCategories.SelectedIndex = -1;
            tbxAddRetailPriceActual.Clear();
            tbxAddCostActual.Clear();
            tbxAddQuantityActual.Clear();
            tbxAddRestockThresholdActual.Clear();
            fileName = "null";

            addItemNameValidBool = false;
            addItemDescriptionValidBool = false;
            addCategoryValidBool = false;
            addRetailPriceValidBool = false;
            addCostValidBool = false;
            addQuantityValidBool = false;
            addRestockThresholdValidBool = false;
            addImageValidBool = true;

            displayTimer.Start();
        }

        //Checks for validity of item info and inserts to database
        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            if (addItemNameValidBool && addItemDescriptionValidBool && addCategoryValidBool && addRetailPriceValidBool && addCostValidBool && addQuantityValidBool && addRestockThresholdValidBool && addImageValidBool)
            {
                clsSQL.AddItem(tbxAddItemNameActual.Text, tbxAddItemDescriptionActual.Text, cbxCategories.SelectedItem.ToString(), Convert.ToDecimal(tbxAddRetailPriceActual.Text), Convert.ToDecimal(tbxAddCostActual.Text), Convert.ToInt32(tbxAddQuantityActual.Text), Convert.ToInt32(tbxAddRestockThresholdActual.Text), fileName);
                pnlAdd.Visible = false;
                tbxAddItemNameActual.Clear();
                tbxAddItemDescriptionActual.Clear();
                cbxCategories.SelectedIndex = -1;
                tbxAddRetailPriceActual.Clear();
                tbxAddCostActual.Clear();
                tbxAddQuantityActual.Clear();
                tbxAddRestockThresholdActual.Clear();
                fileName = "null";

                addItemNameValidBool = false;
                addItemDescriptionValidBool = false;
                addCategoryValidBool = false;
                addRetailPriceValidBool = false;
                addCostValidBool = false;
                addQuantityValidBool = false;
                addRestockThresholdValidBool = false;
                addImageValidBool = true;

                displayTimer.Start();
            }
        }

        //Allows user to modify a selected item
        private void btnModifyItem_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                tbxEditItemNameActual.TextChanged -= tbxEditItemNameActual_TextChanged;
                tbxEditDescriptionActual.TextChanged -= tbxEditDescriptionActual_TextChanged;
                tbxEditRetailPriceActual.TextChanged -= tbxEditRetailPriceActual_TextChanged;
                tbxEditQuantityActual.TextChanged -= tbxEditQuantityActual_TextChanged;
                tbxEditRestockThresholdActual.TextChanged -= tbxEditRestockThresholdActual_TextChanged;

                lblValidEditItemName.ForeColor = Color.Green;
                lblValidEditItemName.Text = "O";
                lblValidEditItemDescription.ForeColor = Color.Green;
                lblValidEditItemDescription.Text = "O";
                lblValidEditRetailPrice.ForeColor = Color.Green;
                lblValidEditRetailPrice.Text = "O";
                lblValidEditQuantity.ForeColor = Color.Green;
                lblValidEditQuantity.Text = "O";
                lblValidEditRestockThreshold.ForeColor = Color.Green;
                lblValidEditRestockThreshold.Text = "O";
                lblValidEditImage.ForeColor = Color.Green;
                lblValidEditImage.Text = "O";

                pnlModify.Visible = true;
                btnPrintInventory.Enabled = false;
                btnMain.Enabled = false;

                tbxEditItemNameActual.Text = row.Field<string>("ItemName").ToString();
                tbxEditDescriptionActual.Text = row.Field<string>("ItemDescription").ToString();
                tbxEditRetailPriceActual.Text = row.Field<decimal>("RetailPrice").ToString();
                tbxEditQuantityActual.Text = row.Field<Int64>("Quantity").ToString();
                tbxEditRestockThresholdActual.Text = row.Field<Int64>("RestockThreshold").ToString();

                
                tbxEditItemNameActual.TextChanged += tbxEditItemNameActual_TextChanged;
                tbxEditDescriptionActual.TextChanged += tbxEditDescriptionActual_TextChanged;
                tbxEditRetailPriceActual.TextChanged += tbxEditRetailPriceActual_TextChanged;
                tbxEditQuantityActual.TextChanged += tbxEditQuantityActual_TextChanged;
                tbxEditRestockThresholdActual.TextChanged += tbxEditRestockThresholdActual_TextChanged;
            }
        }

        //checks for item name changes and validity
        private void tbxEditItemNameActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateItemName(tbxEditItemNameActual.Text))
            {
                lblValidEditItemName.ForeColor = Color.Green;
                lblValidEditItemName.Text = "O";
                editItemNameValidBool = true;
                itemNameChangedBool = true;
            }
            else
            {
                lblValidEditItemName.ForeColor = Color.Red;
                lblValidEditItemName.Text = "X";
                editItemNameValidBool = false;
            }
        }        

        //checks for item description changes and validity
        private void tbxEditDescriptionActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateItemDescription(tbxEditDescriptionActual.Text))
            {
                lblValidEditItemDescription.ForeColor = Color.Green;
                lblValidEditItemDescription.Text = "O";
                editItemDescriptionValidBool = true;
                itemDescriptionChangedBool = true;
            }
            else
            {
                lblValidEditItemDescription.ForeColor = Color.Red;
                lblValidEditItemDescription.Text = "X";
                editItemDescriptionValidBool = false;
            }
        }

        //checks for retail price changes and validity
        private void tbxEditRetailPriceActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateItemRetailPrice(tbxEditRetailPriceActual.Text))
            {
                lblValidEditRetailPrice.ForeColor = Color.Green;
                lblValidEditRetailPrice.Text = "O";
                editRetailPriceValidBool = true;
                retailPriceChangedBool = true;
            }
            else
            {
                lblValidEditRetailPrice.ForeColor = Color.Red;
                lblValidEditRetailPrice.Text = "X";
                editRetailPriceValidBool = false;
            }
        }        

        //only allows for certain keys to be pressed for retail price
        private void tbxEditRetailPriceActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || (int)e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        //checks for quantity changes and validity
        private void tbxEditQuantityActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateItemQuantity(tbxEditQuantityActual.Text))
            {
                lblValidEditQuantity.ForeColor = Color.Green;
                lblValidEditQuantity.Text = "O";
                editQuantityValidBool = true;
                quantityChangedBool = true;
            }
            else
            {
                lblValidEditQuantity.ForeColor = Color.Red;
                lblValidEditQuantity.Text = "X";
                editQuantityValidBool = false;
            }
        }
        
        //only allows for certain keys to be pressed for quantity
        private void tbxEditQuantityActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }
        
        //checks for restock threshold changes and validity
        private void tbxEditRestockThresholdActual_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateItemRestockThreshold(tbxEditRestockThresholdActual.Text))
            {
                lblValidEditRestockThreshold.ForeColor = Color.Green;
                lblValidEditRestockThreshold.Text = "O";
                editRestockThresholdValidBool = true;
                restockThresholdChangedBool = true;
            }
            else
            {
                lblValidEditRestockThreshold.ForeColor = Color.Red;
                lblValidEditRestockThreshold.Text = "X";
                editRestockThresholdValidBool = false;
            }
        }

        //only allows certain keys to be pressed for restock threshold
        private void tbxEditRestockThresholdActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        //allows user to change image and checks validity
        private void btnEditImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {                
                fileName = fileDialog.FileName;

                if (clsValidation.ValidateImage(fileName))
                {
                    lblValidEditImage.ForeColor = Color.Green;
                    lblValidEditImage.Text = "O";
                    editImageValidBool = true;
                    imageChangedBool = true;
                }
                else
                {
                    lblValidEditImage.ForeColor = Color.Red;
                    lblValidEditImage.Text = "X";
                    editImageValidBool = false;
                }
            }

            lblValidEditImage.Visible = true;
        }

        //clears changed info and hides page
        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            tbxEditItemNameActual.TextChanged -= tbxEditItemNameActual_TextChanged;
            tbxEditDescriptionActual.TextChanged -= tbxEditDescriptionActual_TextChanged;
            tbxEditRetailPriceActual.TextChanged -= tbxEditRetailPriceActual_TextChanged;
            tbxEditQuantityActual.TextChanged -= tbxEditQuantityActual_TextChanged;
            tbxEditRestockThresholdActual.TextChanged -= tbxEditRestockThresholdActual_TextChanged;

            pnlModify.Visible = false;
            tbxEditItemNameActual.Clear();
            tbxEditDescriptionActual.Clear();
            tbxEditRetailPriceActual.Clear();
            tbxEditQuantityActual.Clear();
            tbxEditRestockThresholdActual.Clear();

            editItemNameValidBool = true;
            itemNameChangedBool = false;
            editItemDescriptionValidBool = true;
            itemDescriptionChangedBool = false;
            editRetailPriceValidBool = true;
            retailPriceChangedBool = false;
            editQuantityValidBool = true;
            quantityChangedBool = false;
            editRestockThresholdValidBool = true;
            restockThresholdChangedBool = false;

            displayTimer.Start();
        }

        //checks for validity of edits and updates item in database
        private void btnEditSave_Click(object sender, EventArgs e)
        {
            
            if (editItemNameValidBool && editItemDescriptionValidBool && editRetailPriceValidBool && editQuantityValidBool && editRestockThresholdValidBool && editImageValidBool) 
            {
                if (itemNameChangedBool || itemDescriptionChangedBool || retailPriceChangedBool || quantityChangedBool || restockThresholdChangedBool || imageChangedBool)
                {
                    pnlModify.Visible = false;                                  
                    clsSQL.ModifyItem(Convert.ToInt32(row["InventoryID"].ToString()), itemNameChangedBool, itemDescriptionChangedBool, retailPriceChangedBool, quantityChangedBool, restockThresholdChangedBool, imageChangedBool, tbxEditItemNameActual.Text, tbxEditDescriptionActual.Text, tbxEditRetailPriceActual.Text, tbxEditQuantityActual.Text, tbxEditRestockThresholdActual.Text, fileName);
                    tbxEditItemNameActual.Clear();
                    tbxEditDescriptionActual.Clear();
                    tbxEditRetailPriceActual.Clear();
                    tbxEditQuantityActual.Clear();
                    tbxEditRestockThresholdActual.Clear();

                    editItemNameValidBool = true;
                    itemNameChangedBool = false;
                    editItemDescriptionValidBool = true;
                    itemDescriptionChangedBool = false;
                    editRetailPriceValidBool = true;
                    retailPriceChangedBool = false;
                    editQuantityValidBool = true;
                    quantityChangedBool = false;
                    editRestockThresholdValidBool = true;
                    restockThresholdChangedBool = false;

                    displayTimer.Start();
                }               
            }
        }

        //removes selected item from database
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                SetAllFalse();
                clsSQL.RemoveItem(Convert.ToInt32(row["InventoryID"].ToString()));
                displayTimer.Start();
            }
        }

        //prints html report of inventory
        private void btnPrintInventory_Click(object sender, EventArgs e)
        {
            clsHTML.PrintInventory(clsHTML.GenerateReceipt(clsHTML.BuildInventoryReceipt()));
        }

        //takes user back to manager home form
        private void btnMain_Click(object sender, EventArgs e)
        {
            new frmManagerHome().Show();
            this.Dispose();
        }

        //Allows user to open help files
        private void lblHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpInventory.HelpNamespace);
        }
    }
}

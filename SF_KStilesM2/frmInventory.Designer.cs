namespace SF_KStilesM2
{
    partial class frmInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.btnMain = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnModifyItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.pnlModify = new System.Windows.Forms.Panel();
            this.lblValidEditImage = new System.Windows.Forms.Label();
            this.lblValidEditRestockThreshold = new System.Windows.Forms.Label();
            this.lblValidEditQuantity = new System.Windows.Forms.Label();
            this.lblValidEditRetailPrice = new System.Windows.Forms.Label();
            this.lblValidEditItemDescription = new System.Windows.Forms.Label();
            this.lblValidEditItemName = new System.Windows.Forms.Label();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditImage = new System.Windows.Forms.Button();
            this.tbxEditRestockThresholdActual = new System.Windows.Forms.TextBox();
            this.lblEditRestockThresholdLabel = new System.Windows.Forms.Label();
            this.tbxEditQuantityActual = new System.Windows.Forms.TextBox();
            this.lblEditQuantityLabel = new System.Windows.Forms.Label();
            this.tbxEditRetailPriceActual = new System.Windows.Forms.TextBox();
            this.lblEditRetailPriceLabel = new System.Windows.Forms.Label();
            this.tbxEditDescriptionActual = new System.Windows.Forms.TextBox();
            this.lblEditItemDescriptionLabel = new System.Windows.Forms.Label();
            this.tbxEditItemNameActual = new System.Windows.Forms.TextBox();
            this.lblEditItemNameLabel = new System.Windows.Forms.Label();
            this.lblRequired2 = new System.Windows.Forms.Label();
            this.lblRequired1 = new System.Windows.Forms.Label();
            this.lblRequired5 = new System.Windows.Forms.Label();
            this.lblRequired4 = new System.Windows.Forms.Label();
            this.lblRequired3 = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.InventoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestockThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discontinued = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.lblValidAddCost = new System.Windows.Forms.Label();
            this.tbxAddCostActual = new System.Windows.Forms.TextBox();
            this.lblAddCostLabel = new System.Windows.Forms.Label();
            this.lblValidAddCategory = new System.Windows.Forms.Label();
            this.lblAddCategoryLabel = new System.Windows.Forms.Label();
            this.lblValidAddImage = new System.Windows.Forms.Label();
            this.lblValidAddRestockThreshold = new System.Windows.Forms.Label();
            this.lblValidAddQuantity = new System.Windows.Forms.Label();
            this.lblValidAddRetailPrice = new System.Windows.Forms.Label();
            this.lblValidAddItemDescription = new System.Windows.Forms.Label();
            this.lblValidAddItemName = new System.Windows.Forms.Label();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.tbxAddRestockThresholdActual = new System.Windows.Forms.TextBox();
            this.lblAddRestockThresholdLabel = new System.Windows.Forms.Label();
            this.tbxAddQuantityActual = new System.Windows.Forms.TextBox();
            this.lblAddQuantityLabel = new System.Windows.Forms.Label();
            this.tbxAddRetailPriceActual = new System.Windows.Forms.TextBox();
            this.lblAddRetailPriceLabel = new System.Windows.Forms.Label();
            this.tbxAddItemDescriptionActual = new System.Windows.Forms.TextBox();
            this.lblAddItemDescriptionLabel = new System.Windows.Forms.Label();
            this.tbxAddItemNameActual = new System.Windows.Forms.TextBox();
            this.lblAddItemNameLabel = new System.Windows.Forms.Label();
            this.lblRequired7 = new System.Windows.Forms.Label();
            this.lblRequired6 = new System.Windows.Forms.Label();
            this.lblRequired8 = new System.Windows.Forms.Label();
            this.lblRequired9 = new System.Windows.Forms.Label();
            this.lblRequired10 = new System.Windows.Forms.Label();
            this.lblRequired11 = new System.Windows.Forms.Label();
            this.lblRequired12 = new System.Windows.Forms.Label();
            this.btnPrintInventory = new System.Windows.Forms.Button();
            this.hlpInventory = new System.Windows.Forms.HelpProvider();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pbxItemImage = new System.Windows.Forms.PictureBox();
            this.pnlModify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.pnlAdd.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Doppio One", 22F, System.Drawing.FontStyle.Bold);
            this.btnMain.Location = new System.Drawing.Point(1287, 694);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(184, 69);
            this.btnMain.TabIndex = 70;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblHelp.Font = new System.Drawing.Font("Doppio One", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHelp.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblHelp.Location = new System.Drawing.Point(1515, 700);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(78, 35);
            this.lblHelp.TabIndex = 69;
            this.lblHelp.Text = "Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Doppio One", 22F);
            this.btnAddItem.Location = new System.Drawing.Point(48, 685);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(230, 71);
            this.btnAddItem.TabIndex = 71;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnModifyItem
            // 
            this.btnModifyItem.Enabled = false;
            this.btnModifyItem.Font = new System.Drawing.Font("Doppio One", 22F);
            this.btnModifyItem.Location = new System.Drawing.Point(309, 685);
            this.btnModifyItem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModifyItem.Name = "btnModifyItem";
            this.btnModifyItem.Size = new System.Drawing.Size(310, 71);
            this.btnModifyItem.TabIndex = 72;
            this.btnModifyItem.Text = "Modify Item";
            this.btnModifyItem.UseVisualStyleBackColor = true;
            this.btnModifyItem.Click += new System.EventHandler(this.btnModifyItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Font = new System.Drawing.Font("Doppio One", 22F);
            this.btnRemoveItem.Location = new System.Drawing.Point(645, 685);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(326, 71);
            this.btnRemoveItem.TabIndex = 73;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // pnlModify
            // 
            this.pnlModify.Controls.Add(this.lblValidEditImage);
            this.pnlModify.Controls.Add(this.lblValidEditRestockThreshold);
            this.pnlModify.Controls.Add(this.lblValidEditQuantity);
            this.pnlModify.Controls.Add(this.lblValidEditRetailPrice);
            this.pnlModify.Controls.Add(this.lblValidEditItemDescription);
            this.pnlModify.Controls.Add(this.lblValidEditItemName);
            this.pnlModify.Controls.Add(this.btnEditSave);
            this.pnlModify.Controls.Add(this.btnEditCancel);
            this.pnlModify.Controls.Add(this.btnEditImage);
            this.pnlModify.Controls.Add(this.tbxEditRestockThresholdActual);
            this.pnlModify.Controls.Add(this.lblEditRestockThresholdLabel);
            this.pnlModify.Controls.Add(this.tbxEditQuantityActual);
            this.pnlModify.Controls.Add(this.lblEditQuantityLabel);
            this.pnlModify.Controls.Add(this.tbxEditRetailPriceActual);
            this.pnlModify.Controls.Add(this.lblEditRetailPriceLabel);
            this.pnlModify.Controls.Add(this.tbxEditDescriptionActual);
            this.pnlModify.Controls.Add(this.lblEditItemDescriptionLabel);
            this.pnlModify.Controls.Add(this.tbxEditItemNameActual);
            this.pnlModify.Controls.Add(this.lblEditItemNameLabel);
            this.pnlModify.Controls.Add(this.lblRequired2);
            this.pnlModify.Controls.Add(this.lblRequired1);
            this.pnlModify.Controls.Add(this.lblRequired5);
            this.pnlModify.Controls.Add(this.lblRequired4);
            this.pnlModify.Controls.Add(this.lblRequired3);
            this.pnlModify.Location = new System.Drawing.Point(20, 8);
            this.pnlModify.Name = "pnlModify";
            this.pnlModify.Size = new System.Drawing.Size(992, 755);
            this.pnlModify.TabIndex = 74;
            this.pnlModify.Visible = false;
            // 
            // lblValidEditImage
            // 
            this.lblValidEditImage.AutoSize = true;
            this.lblValidEditImage.BackColor = System.Drawing.Color.Transparent;
            this.lblValidEditImage.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidEditImage.ForeColor = System.Drawing.Color.Green;
            this.lblValidEditImage.Location = new System.Drawing.Point(390, 646);
            this.lblValidEditImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidEditImage.Name = "lblValidEditImage";
            this.lblValidEditImage.Size = new System.Drawing.Size(35, 40);
            this.lblValidEditImage.TabIndex = 83;
            this.lblValidEditImage.Text = "O";
            // 
            // lblValidEditRestockThreshold
            // 
            this.lblValidEditRestockThreshold.AutoSize = true;
            this.lblValidEditRestockThreshold.BackColor = System.Drawing.Color.Transparent;
            this.lblValidEditRestockThreshold.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidEditRestockThreshold.ForeColor = System.Drawing.Color.Green;
            this.lblValidEditRestockThreshold.Location = new System.Drawing.Point(663, 563);
            this.lblValidEditRestockThreshold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidEditRestockThreshold.Name = "lblValidEditRestockThreshold";
            this.lblValidEditRestockThreshold.Size = new System.Drawing.Size(35, 40);
            this.lblValidEditRestockThreshold.TabIndex = 82;
            this.lblValidEditRestockThreshold.Text = "O";
            // 
            // lblValidEditQuantity
            // 
            this.lblValidEditQuantity.AutoSize = true;
            this.lblValidEditQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblValidEditQuantity.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidEditQuantity.ForeColor = System.Drawing.Color.Green;
            this.lblValidEditQuantity.Location = new System.Drawing.Point(405, 488);
            this.lblValidEditQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidEditQuantity.Name = "lblValidEditQuantity";
            this.lblValidEditQuantity.Size = new System.Drawing.Size(35, 40);
            this.lblValidEditQuantity.TabIndex = 81;
            this.lblValidEditQuantity.Text = "O";
            // 
            // lblValidEditRetailPrice
            // 
            this.lblValidEditRetailPrice.AutoSize = true;
            this.lblValidEditRetailPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblValidEditRetailPrice.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidEditRetailPrice.ForeColor = System.Drawing.Color.Green;
            this.lblValidEditRetailPrice.Location = new System.Drawing.Point(579, 415);
            this.lblValidEditRetailPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidEditRetailPrice.Name = "lblValidEditRetailPrice";
            this.lblValidEditRetailPrice.Size = new System.Drawing.Size(35, 40);
            this.lblValidEditRetailPrice.TabIndex = 80;
            this.lblValidEditRetailPrice.Text = "O";
            // 
            // lblValidEditItemDescription
            // 
            this.lblValidEditItemDescription.AutoSize = true;
            this.lblValidEditItemDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblValidEditItemDescription.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidEditItemDescription.ForeColor = System.Drawing.Color.Green;
            this.lblValidEditItemDescription.Location = new System.Drawing.Point(390, 89);
            this.lblValidEditItemDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidEditItemDescription.Name = "lblValidEditItemDescription";
            this.lblValidEditItemDescription.Size = new System.Drawing.Size(35, 40);
            this.lblValidEditItemDescription.TabIndex = 79;
            this.lblValidEditItemDescription.Text = "O";
            // 
            // lblValidEditItemName
            // 
            this.lblValidEditItemName.AutoSize = true;
            this.lblValidEditItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblValidEditItemName.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidEditItemName.ForeColor = System.Drawing.Color.Green;
            this.lblValidEditItemName.Location = new System.Drawing.Point(896, 11);
            this.lblValidEditItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidEditItemName.Name = "lblValidEditItemName";
            this.lblValidEditItemName.Size = new System.Drawing.Size(35, 40);
            this.lblValidEditItemName.TabIndex = 78;
            this.lblValidEditItemName.Text = "O";
            // 
            // btnEditSave
            // 
            this.btnEditSave.Font = new System.Drawing.Font("Doppio One", 19F);
            this.btnEditSave.Location = new System.Drawing.Point(824, 665);
            this.btnEditSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(152, 60);
            this.btnEditSave.TabIndex = 77;
            this.btnEditSave.Text = "Save";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Font = new System.Drawing.Font("Doppio One", 19F);
            this.btnEditCancel.Location = new System.Drawing.Point(644, 665);
            this.btnEditCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(170, 60);
            this.btnEditCancel.TabIndex = 76;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnEditImage
            // 
            this.btnEditImage.Font = new System.Drawing.Font("Doppio One", 22F);
            this.btnEditImage.Location = new System.Drawing.Point(16, 642);
            this.btnEditImage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEditImage.Name = "btnEditImage";
            this.btnEditImage.Size = new System.Drawing.Size(344, 83);
            this.btnEditImage.TabIndex = 75;
            this.btnEditImage.Text = "Change Image";
            this.btnEditImage.UseVisualStyleBackColor = true;
            this.btnEditImage.Click += new System.EventHandler(this.btnEditImage_Click);
            // 
            // tbxEditRestockThresholdActual
            // 
            this.tbxEditRestockThresholdActual.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxEditRestockThresholdActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEditRestockThresholdActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxEditRestockThresholdActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxEditRestockThresholdActual.Font = new System.Drawing.Font("Doppio One", 19F);
            this.tbxEditRestockThresholdActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxEditRestockThresholdActual.Location = new System.Drawing.Point(423, 568);
            this.tbxEditRestockThresholdActual.Name = "tbxEditRestockThresholdActual";
            this.tbxEditRestockThresholdActual.Size = new System.Drawing.Size(232, 39);
            this.tbxEditRestockThresholdActual.TabIndex = 26;
            this.tbxEditRestockThresholdActual.TextChanged += new System.EventHandler(this.tbxEditRestockThresholdActual_TextChanged);
            this.tbxEditRestockThresholdActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEditRestockThresholdActual_KeyPress);
            // 
            // lblEditRestockThresholdLabel
            // 
            this.lblEditRestockThresholdLabel.AutoSize = true;
            this.lblEditRestockThresholdLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblEditRestockThresholdLabel.Font = new System.Drawing.Font("Doppio One", 22F);
            this.lblEditRestockThresholdLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblEditRestockThresholdLabel.Location = new System.Drawing.Point(4, 568);
            this.lblEditRestockThresholdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditRestockThresholdLabel.Name = "lblEditRestockThresholdLabel";
            this.lblEditRestockThresholdLabel.Size = new System.Drawing.Size(282, 37);
            this.lblEditRestockThresholdLabel.TabIndex = 25;
            this.lblEditRestockThresholdLabel.Text = "Restock Threshold:";
            // 
            // tbxEditQuantityActual
            // 
            this.tbxEditQuantityActual.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxEditQuantityActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEditQuantityActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxEditQuantityActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxEditQuantityActual.Font = new System.Drawing.Font("Doppio One", 19F);
            this.tbxEditQuantityActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxEditQuantityActual.Location = new System.Drawing.Point(228, 494);
            this.tbxEditQuantityActual.Name = "tbxEditQuantityActual";
            this.tbxEditQuantityActual.Size = new System.Drawing.Size(168, 39);
            this.tbxEditQuantityActual.TabIndex = 24;
            this.tbxEditQuantityActual.TextChanged += new System.EventHandler(this.tbxEditQuantityActual_TextChanged);
            this.tbxEditQuantityActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEditQuantityActual_KeyPress);
            // 
            // lblEditQuantityLabel
            // 
            this.lblEditQuantityLabel.AutoSize = true;
            this.lblEditQuantityLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblEditQuantityLabel.Font = new System.Drawing.Font("Doppio One", 22F);
            this.lblEditQuantityLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblEditQuantityLabel.Location = new System.Drawing.Point(4, 491);
            this.lblEditQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditQuantityLabel.Name = "lblEditQuantityLabel";
            this.lblEditQuantityLabel.Size = new System.Drawing.Size(152, 37);
            this.lblEditQuantityLabel.TabIndex = 23;
            this.lblEditQuantityLabel.Text = "Quantity:";
            // 
            // tbxEditRetailPriceActual
            // 
            this.tbxEditRetailPriceActual.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxEditRetailPriceActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEditRetailPriceActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxEditRetailPriceActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxEditRetailPriceActual.Font = new System.Drawing.Font("Doppio One", 19F);
            this.tbxEditRetailPriceActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxEditRetailPriceActual.Location = new System.Drawing.Point(315, 417);
            this.tbxEditRetailPriceActual.MaxLength = 10;
            this.tbxEditRetailPriceActual.Name = "tbxEditRetailPriceActual";
            this.tbxEditRetailPriceActual.Size = new System.Drawing.Size(256, 39);
            this.tbxEditRetailPriceActual.TabIndex = 22;
            this.tbxEditRetailPriceActual.TextChanged += new System.EventHandler(this.tbxEditRetailPriceActual_TextChanged);
            this.tbxEditRetailPriceActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEditRetailPriceActual_KeyPress);
            // 
            // lblEditRetailPriceLabel
            // 
            this.lblEditRetailPriceLabel.AutoSize = true;
            this.lblEditRetailPriceLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblEditRetailPriceLabel.Font = new System.Drawing.Font("Doppio One", 22F);
            this.lblEditRetailPriceLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblEditRetailPriceLabel.Location = new System.Drawing.Point(4, 420);
            this.lblEditRetailPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditRetailPriceLabel.Name = "lblEditRetailPriceLabel";
            this.lblEditRetailPriceLabel.Size = new System.Drawing.Size(210, 37);
            this.lblEditRetailPriceLabel.TabIndex = 21;
            this.lblEditRetailPriceLabel.Text = "Retail Price: $";
            // 
            // tbxEditDescriptionActual
            // 
            this.tbxEditDescriptionActual.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxEditDescriptionActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEditDescriptionActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxEditDescriptionActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxEditDescriptionActual.Font = new System.Drawing.Font("Doppio One", 19F);
            this.tbxEditDescriptionActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxEditDescriptionActual.Location = new System.Drawing.Point(12, 154);
            this.tbxEditDescriptionActual.MaxLength = 100000;
            this.tbxEditDescriptionActual.Multiline = true;
            this.tbxEditDescriptionActual.Name = "tbxEditDescriptionActual";
            this.tbxEditDescriptionActual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxEditDescriptionActual.Size = new System.Drawing.Size(968, 253);
            this.tbxEditDescriptionActual.TabIndex = 20;
            this.tbxEditDescriptionActual.TabStop = false;
            this.tbxEditDescriptionActual.TextChanged += new System.EventHandler(this.tbxEditDescriptionActual_TextChanged);
            // 
            // lblEditItemDescriptionLabel
            // 
            this.lblEditItemDescriptionLabel.AutoSize = true;
            this.lblEditItemDescriptionLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblEditItemDescriptionLabel.Font = new System.Drawing.Font("Doppio One", 22F);
            this.lblEditItemDescriptionLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblEditItemDescriptionLabel.Location = new System.Drawing.Point(4, 92);
            this.lblEditItemDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditItemDescriptionLabel.Name = "lblEditItemDescriptionLabel";
            this.lblEditItemDescriptionLabel.Size = new System.Drawing.Size(261, 37);
            this.lblEditItemDescriptionLabel.TabIndex = 6;
            this.lblEditItemDescriptionLabel.Text = "Item Description:";
            // 
            // tbxEditItemNameActual
            // 
            this.tbxEditItemNameActual.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxEditItemNameActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEditItemNameActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxEditItemNameActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxEditItemNameActual.Font = new System.Drawing.Font("Doppio One", 19F);
            this.tbxEditItemNameActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxEditItemNameActual.Location = new System.Drawing.Point(282, 17);
            this.tbxEditItemNameActual.MaxLength = 100;
            this.tbxEditItemNameActual.Name = "tbxEditItemNameActual";
            this.tbxEditItemNameActual.Size = new System.Drawing.Size(612, 39);
            this.tbxEditItemNameActual.TabIndex = 5;
            this.tbxEditItemNameActual.TextChanged += new System.EventHandler(this.tbxEditItemNameActual_TextChanged);
            // 
            // lblEditItemNameLabel
            // 
            this.lblEditItemNameLabel.AutoSize = true;
            this.lblEditItemNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblEditItemNameLabel.Font = new System.Drawing.Font("Doppio One", 22F);
            this.lblEditItemNameLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblEditItemNameLabel.Location = new System.Drawing.Point(4, 9);
            this.lblEditItemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditItemNameLabel.Name = "lblEditItemNameLabel";
            this.lblEditItemNameLabel.Size = new System.Drawing.Size(183, 37);
            this.lblEditItemNameLabel.TabIndex = 4;
            this.lblEditItemNameLabel.Text = "Item Name:";
            // 
            // lblRequired2
            // 
            this.lblRequired2.AutoSize = true;
            this.lblRequired2.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired2.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblRequired2.ForeColor = System.Drawing.Color.Red;
            this.lblRequired2.Location = new System.Drawing.Point(436, 102);
            this.lblRequired2.Name = "lblRequired2";
            this.lblRequired2.Size = new System.Drawing.Size(23, 29);
            this.lblRequired2.TabIndex = 95;
            this.lblRequired2.Text = "*";
            // 
            // lblRequired1
            // 
            this.lblRequired1.AutoSize = true;
            this.lblRequired1.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired1.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblRequired1.ForeColor = System.Drawing.Color.Red;
            this.lblRequired1.Location = new System.Drawing.Point(946, 23);
            this.lblRequired1.Name = "lblRequired1";
            this.lblRequired1.Size = new System.Drawing.Size(23, 29);
            this.lblRequired1.TabIndex = 94;
            this.lblRequired1.Text = "*";
            // 
            // lblRequired5
            // 
            this.lblRequired5.AutoSize = true;
            this.lblRequired5.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired5.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblRequired5.ForeColor = System.Drawing.Color.Red;
            this.lblRequired5.Location = new System.Drawing.Point(712, 571);
            this.lblRequired5.Name = "lblRequired5";
            this.lblRequired5.Size = new System.Drawing.Size(23, 29);
            this.lblRequired5.TabIndex = 98;
            this.lblRequired5.Text = "*";
            // 
            // lblRequired4
            // 
            this.lblRequired4.AutoSize = true;
            this.lblRequired4.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired4.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblRequired4.ForeColor = System.Drawing.Color.Red;
            this.lblRequired4.Location = new System.Drawing.Point(453, 502);
            this.lblRequired4.Name = "lblRequired4";
            this.lblRequired4.Size = new System.Drawing.Size(23, 29);
            this.lblRequired4.TabIndex = 97;
            this.lblRequired4.Text = "*";
            // 
            // lblRequired3
            // 
            this.lblRequired3.AutoSize = true;
            this.lblRequired3.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired3.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblRequired3.ForeColor = System.Drawing.Color.Red;
            this.lblRequired3.Location = new System.Drawing.Point(621, 425);
            this.lblRequired3.Name = "lblRequired3";
            this.lblRequired3.Size = new System.Drawing.Size(23, 29);
            this.lblRequired3.TabIndex = 96;
            this.lblRequired3.Text = "*";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventory.BackgroundColor = global::SF_KStilesM2.Properties.Settings.Default.boxBack;
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventoryID,
            this.ItemName,
            this.ItemDescription,
            this.RetailPrice,
            this.Cost,
            this.Quantity,
            this.RestockThreshold,
            this.Discontinued});
            this.dgvInventory.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::SF_KStilesM2.Properties.Settings.Default, "boxBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgvInventory.Location = new System.Drawing.Point(20, 12);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Doppio One", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvInventory.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(987, 660);
            this.dgvInventory.TabIndex = 79;
            this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
            // 
            // InventoryID
            // 
            this.InventoryID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryID.DataPropertyName = "InventoryID";
            this.InventoryID.HeaderText = "Inventory ID";
            this.InventoryID.Name = "InventoryID";
            this.InventoryID.ReadOnly = true;
            this.InventoryID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.InventoryID.Width = 109;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemName.DataPropertyName = "ItemName";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ItemName.Width = 96;
            // 
            // ItemDescription
            // 
            this.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemDescription.DataPropertyName = "ItemDescription";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemDescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemDescription.HeaderText = "Item Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            this.ItemDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ItemDescription.Width = 143;
            // 
            // RetailPrice
            // 
            this.RetailPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RetailPrice.DataPropertyName = "RetailPrice";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.RetailPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.RetailPrice.HeaderText = "Retail Price";
            this.RetailPrice.Name = "RetailPrice";
            this.RetailPrice.ReadOnly = true;
            this.RetailPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RetailPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RetailPrice.Width = 102;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cost.DataPropertyName = "Cost";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Cost.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cost.Width = 53;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 91;
            // 
            // RestockThreshold
            // 
            this.RestockThreshold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RestockThreshold.DataPropertyName = "RestockThreshold";
            this.RestockThreshold.HeaderText = "Restock Threshold";
            this.RestockThreshold.Name = "RestockThreshold";
            this.RestockThreshold.ReadOnly = true;
            this.RestockThreshold.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RestockThreshold.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RestockThreshold.Width = 155;
            // 
            // Discontinued
            // 
            this.Discontinued.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Discontinued.DataPropertyName = "Discontinued";
            this.Discontinued.HeaderText = "Discontinued";
            this.Discontinued.Name = "Discontinued";
            this.Discontinued.ReadOnly = true;
            this.Discontinued.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Discontinued.Width = 129;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.cbxCategories);
            this.pnlAdd.Controls.Add(this.lblValidAddCost);
            this.pnlAdd.Controls.Add(this.tbxAddCostActual);
            this.pnlAdd.Controls.Add(this.lblAddCostLabel);
            this.pnlAdd.Controls.Add(this.lblValidAddCategory);
            this.pnlAdd.Controls.Add(this.lblAddCategoryLabel);
            this.pnlAdd.Controls.Add(this.lblValidAddImage);
            this.pnlAdd.Controls.Add(this.lblValidAddRestockThreshold);
            this.pnlAdd.Controls.Add(this.lblValidAddQuantity);
            this.pnlAdd.Controls.Add(this.lblValidAddRetailPrice);
            this.pnlAdd.Controls.Add(this.lblValidAddItemDescription);
            this.pnlAdd.Controls.Add(this.lblValidAddItemName);
            this.pnlAdd.Controls.Add(this.btnAddAdd);
            this.pnlAdd.Controls.Add(this.btnAddCancel);
            this.pnlAdd.Controls.Add(this.btnAddImage);
            this.pnlAdd.Controls.Add(this.tbxAddRestockThresholdActual);
            this.pnlAdd.Controls.Add(this.lblAddRestockThresholdLabel);
            this.pnlAdd.Controls.Add(this.tbxAddQuantityActual);
            this.pnlAdd.Controls.Add(this.lblAddQuantityLabel);
            this.pnlAdd.Controls.Add(this.tbxAddRetailPriceActual);
            this.pnlAdd.Controls.Add(this.lblAddRetailPriceLabel);
            this.pnlAdd.Controls.Add(this.tbxAddItemDescriptionActual);
            this.pnlAdd.Controls.Add(this.lblAddItemDescriptionLabel);
            this.pnlAdd.Controls.Add(this.tbxAddItemNameActual);
            this.pnlAdd.Controls.Add(this.lblAddItemNameLabel);
            this.pnlAdd.Controls.Add(this.lblRequired7);
            this.pnlAdd.Controls.Add(this.lblRequired6);
            this.pnlAdd.Controls.Add(this.lblRequired8);
            this.pnlAdd.Controls.Add(this.lblRequired9);
            this.pnlAdd.Controls.Add(this.lblRequired10);
            this.pnlAdd.Controls.Add(this.lblRequired11);
            this.pnlAdd.Controls.Add(this.lblRequired12);
            this.pnlAdd.Location = new System.Drawing.Point(20, 8);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(992, 755);
            this.pnlAdd.TabIndex = 84;
            this.pnlAdd.Visible = false;
            // 
            // cbxCategories
            // 
            this.cbxCategories.DropDownHeight = 95;
            this.cbxCategories.Font = new System.Drawing.Font("Doppio One", 19F);
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.IntegralHeight = false;
            this.cbxCategories.Location = new System.Drawing.Point(208, 437);
            this.cbxCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(674, 39);
            this.cbxCategories.TabIndex = 101;
            this.cbxCategories.SelectedIndexChanged += new System.EventHandler(this.cbxCategories_SelectedIndexChanged);
            // 
            // lblValidAddCost
            // 
            this.lblValidAddCost.AutoSize = true;
            this.lblValidAddCost.BackColor = System.Drawing.Color.Transparent;
            this.lblValidAddCost.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidAddCost.ForeColor = System.Drawing.Color.Red;
            this.lblValidAddCost.Location = new System.Drawing.Point(404, 580);
            this.lblValidAddCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidAddCost.Name = "lblValidAddCost";
            this.lblValidAddCost.Size = new System.Drawing.Size(35, 40);
            this.lblValidAddCost.TabIndex = 89;
            this.lblValidAddCost.Text = "X";
            // 
            // tbxAddCostActual
            // 
            this.tbxAddCostActual.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxAddCostActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddCostActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddCostActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddCostActual.Font = new System.Drawing.Font("Doppio One", 19F);
            this.tbxAddCostActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxAddCostActual.Location = new System.Drawing.Point(166, 582);
            this.tbxAddCostActual.MaxLength = 10;
            this.tbxAddCostActual.Name = "tbxAddCostActual";
            this.tbxAddCostActual.Size = new System.Drawing.Size(230, 39);
            this.tbxAddCostActual.TabIndex = 88;
            this.tbxAddCostActual.TextChanged += new System.EventHandler(this.tbxAddCostActual_TextChanged);
            this.tbxAddCostActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddCostActual_KeyPress);
            // 
            // lblAddCostLabel
            // 
            this.lblAddCostLabel.AutoSize = true;
            this.lblAddCostLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblAddCostLabel.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblAddCostLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblAddCostLabel.Location = new System.Drawing.Point(8, 582);
            this.lblAddCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddCostLabel.Name = "lblAddCostLabel";
            this.lblAddCostLabel.Size = new System.Drawing.Size(101, 35);
            this.lblAddCostLabel.TabIndex = 87;
            this.lblAddCostLabel.Text = "Cost: $";
            // 
            // lblValidAddCategory
            // 
            this.lblValidAddCategory.AutoSize = true;
            this.lblValidAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblValidAddCategory.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidAddCategory.ForeColor = System.Drawing.Color.Red;
            this.lblValidAddCategory.Location = new System.Drawing.Point(894, 434);
            this.lblValidAddCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidAddCategory.Name = "lblValidAddCategory";
            this.lblValidAddCategory.Size = new System.Drawing.Size(35, 40);
            this.lblValidAddCategory.TabIndex = 86;
            this.lblValidAddCategory.Text = "X";
            // 
            // lblAddCategoryLabel
            // 
            this.lblAddCategoryLabel.AutoSize = true;
            this.lblAddCategoryLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblAddCategoryLabel.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblAddCategoryLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblAddCategoryLabel.Location = new System.Drawing.Point(6, 437);
            this.lblAddCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddCategoryLabel.Name = "lblAddCategoryLabel";
            this.lblAddCategoryLabel.Size = new System.Drawing.Size(138, 35);
            this.lblAddCategoryLabel.TabIndex = 84;
            this.lblAddCategoryLabel.Text = "Category:";
            // 
            // lblValidAddImage
            // 
            this.lblValidAddImage.AutoSize = true;
            this.lblValidAddImage.BackColor = System.Drawing.Color.Transparent;
            this.lblValidAddImage.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidAddImage.ForeColor = System.Drawing.Color.Green;
            this.lblValidAddImage.Location = new System.Drawing.Point(345, 812);
            this.lblValidAddImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidAddImage.Name = "lblValidAddImage";
            this.lblValidAddImage.Size = new System.Drawing.Size(35, 40);
            this.lblValidAddImage.TabIndex = 83;
            this.lblValidAddImage.Text = "O";
            this.lblValidAddImage.Visible = false;
            // 
            // lblValidAddRestockThreshold
            // 
            this.lblValidAddRestockThreshold.AutoSize = true;
            this.lblValidAddRestockThreshold.BackColor = System.Drawing.Color.Transparent;
            this.lblValidAddRestockThreshold.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidAddRestockThreshold.ForeColor = System.Drawing.Color.Red;
            this.lblValidAddRestockThreshold.Location = new System.Drawing.Point(663, 722);
            this.lblValidAddRestockThreshold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidAddRestockThreshold.Name = "lblValidAddRestockThreshold";
            this.lblValidAddRestockThreshold.Size = new System.Drawing.Size(35, 40);
            this.lblValidAddRestockThreshold.TabIndex = 82;
            this.lblValidAddRestockThreshold.Text = "X";
            // 
            // lblValidAddQuantity
            // 
            this.lblValidAddQuantity.AutoSize = true;
            this.lblValidAddQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblValidAddQuantity.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidAddQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblValidAddQuantity.Location = new System.Drawing.Point(430, 649);
            this.lblValidAddQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidAddQuantity.Name = "lblValidAddQuantity";
            this.lblValidAddQuantity.Size = new System.Drawing.Size(35, 40);
            this.lblValidAddQuantity.TabIndex = 81;
            this.lblValidAddQuantity.Text = "X";
            // 
            // lblValidAddRetailPrice
            // 
            this.lblValidAddRetailPrice.AutoSize = true;
            this.lblValidAddRetailPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblValidAddRetailPrice.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidAddRetailPrice.ForeColor = System.Drawing.Color.Red;
            this.lblValidAddRetailPrice.Location = new System.Drawing.Point(525, 508);
            this.lblValidAddRetailPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidAddRetailPrice.Name = "lblValidAddRetailPrice";
            this.lblValidAddRetailPrice.Size = new System.Drawing.Size(35, 40);
            this.lblValidAddRetailPrice.TabIndex = 80;
            this.lblValidAddRetailPrice.Text = "X";
            // 
            // lblValidAddItemDescription
            // 
            this.lblValidAddItemDescription.AutoSize = true;
            this.lblValidAddItemDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblValidAddItemDescription.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidAddItemDescription.ForeColor = System.Drawing.Color.Red;
            this.lblValidAddItemDescription.Location = new System.Drawing.Point(369, 75);
            this.lblValidAddItemDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidAddItemDescription.Name = "lblValidAddItemDescription";
            this.lblValidAddItemDescription.Size = new System.Drawing.Size(35, 40);
            this.lblValidAddItemDescription.TabIndex = 79;
            this.lblValidAddItemDescription.Text = "X";
            // 
            // lblValidAddItemName
            // 
            this.lblValidAddItemName.AutoSize = true;
            this.lblValidAddItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblValidAddItemName.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold);
            this.lblValidAddItemName.ForeColor = System.Drawing.Color.Red;
            this.lblValidAddItemName.Location = new System.Drawing.Point(903, 3);
            this.lblValidAddItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidAddItemName.Name = "lblValidAddItemName";
            this.lblValidAddItemName.Size = new System.Drawing.Size(35, 40);
            this.lblValidAddItemName.TabIndex = 78;
            this.lblValidAddItemName.Text = "X";
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.Font = new System.Drawing.Font("Doppio One", 19F);
            this.btnAddAdd.Location = new System.Drawing.Point(810, 812);
            this.btnAddAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(152, 60);
            this.btnAddAdd.TabIndex = 77;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = true;
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Font = new System.Drawing.Font("Doppio One", 19F);
            this.btnAddCancel.Location = new System.Drawing.Point(630, 812);
            this.btnAddCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(164, 60);
            this.btnAddCancel.TabIndex = 76;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Font = new System.Drawing.Font("Doppio One", 19F);
            this.btnAddImage.Location = new System.Drawing.Point(16, 806);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(298, 80);
            this.btnAddImage.TabIndex = 75;
            this.btnAddImage.Text = "Change Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // tbxAddRestockThresholdActual
            // 
            this.tbxAddRestockThresholdActual.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxAddRestockThresholdActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddRestockThresholdActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddRestockThresholdActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddRestockThresholdActual.Font = new System.Drawing.Font("Doppio One", 19F);
            this.tbxAddRestockThresholdActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxAddRestockThresholdActual.Location = new System.Drawing.Point(435, 728);
            this.tbxAddRestockThresholdActual.Name = "tbxAddRestockThresholdActual";
            this.tbxAddRestockThresholdActual.Size = new System.Drawing.Size(220, 39);
            this.tbxAddRestockThresholdActual.TabIndex = 26;
            this.tbxAddRestockThresholdActual.TextChanged += new System.EventHandler(this.tbxAddRestockThresholdActual_TextChanged);
            this.tbxAddRestockThresholdActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddRestockThresholdActual_KeyPress);
            // 
            // lblAddRestockThresholdLabel
            // 
            this.lblAddRestockThresholdLabel.AutoSize = true;
            this.lblAddRestockThresholdLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblAddRestockThresholdLabel.Font = new System.Drawing.Font("Doppio One", 22F);
            this.lblAddRestockThresholdLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblAddRestockThresholdLabel.Location = new System.Drawing.Point(6, 729);
            this.lblAddRestockThresholdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddRestockThresholdLabel.Name = "lblAddRestockThresholdLabel";
            this.lblAddRestockThresholdLabel.Size = new System.Drawing.Size(282, 37);
            this.lblAddRestockThresholdLabel.TabIndex = 25;
            this.lblAddRestockThresholdLabel.Text = "Restock Threshold:";
            // 
            // tbxAddQuantityActual
            // 
            this.tbxAddQuantityActual.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxAddQuantityActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddQuantityActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddQuantityActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddQuantityActual.Font = new System.Drawing.Font("Doppio One", 19F);
            this.tbxAddQuantityActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxAddQuantityActual.Location = new System.Drawing.Point(232, 654);
            this.tbxAddQuantityActual.Name = "tbxAddQuantityActual";
            this.tbxAddQuantityActual.Size = new System.Drawing.Size(188, 39);
            this.tbxAddQuantityActual.TabIndex = 24;
            this.tbxAddQuantityActual.TextChanged += new System.EventHandler(this.tbxAddQuantityActual_TextChanged);
            this.tbxAddQuantityActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddQuantityActual_KeyPress);
            // 
            // lblAddQuantityLabel
            // 
            this.lblAddQuantityLabel.AutoSize = true;
            this.lblAddQuantityLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblAddQuantityLabel.Font = new System.Drawing.Font("Doppio One", 22F);
            this.lblAddQuantityLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblAddQuantityLabel.Location = new System.Drawing.Point(4, 651);
            this.lblAddQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddQuantityLabel.Name = "lblAddQuantityLabel";
            this.lblAddQuantityLabel.Size = new System.Drawing.Size(152, 37);
            this.lblAddQuantityLabel.TabIndex = 23;
            this.lblAddQuantityLabel.Text = "Quantity:";
            // 
            // tbxAddRetailPriceActual
            // 
            this.tbxAddRetailPriceActual.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxAddRetailPriceActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddRetailPriceActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddRetailPriceActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddRetailPriceActual.Font = new System.Drawing.Font("Doppio One", 19F);
            this.tbxAddRetailPriceActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxAddRetailPriceActual.Location = new System.Drawing.Point(288, 509);
            this.tbxAddRetailPriceActual.MaxLength = 10;
            this.tbxAddRetailPriceActual.Name = "tbxAddRetailPriceActual";
            this.tbxAddRetailPriceActual.Size = new System.Drawing.Size(230, 39);
            this.tbxAddRetailPriceActual.TabIndex = 22;
            this.tbxAddRetailPriceActual.TextChanged += new System.EventHandler(this.tbxAddRetailPriceActual_TextChanged);
            this.tbxAddRetailPriceActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddRetailPriceActual_KeyPress);
            // 
            // lblAddRetailPriceLabel
            // 
            this.lblAddRetailPriceLabel.AutoSize = true;
            this.lblAddRetailPriceLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblAddRetailPriceLabel.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblAddRetailPriceLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblAddRetailPriceLabel.Location = new System.Drawing.Point(6, 508);
            this.lblAddRetailPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddRetailPriceLabel.Name = "lblAddRetailPriceLabel";
            this.lblAddRetailPriceLabel.Size = new System.Drawing.Size(189, 35);
            this.lblAddRetailPriceLabel.TabIndex = 21;
            this.lblAddRetailPriceLabel.Text = "Retail Price: $";
            // 
            // tbxAddItemDescriptionActual
            // 
            this.tbxAddItemDescriptionActual.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxAddItemDescriptionActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddItemDescriptionActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddItemDescriptionActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddItemDescriptionActual.Font = new System.Drawing.Font("Doppio One", 19F);
            this.tbxAddItemDescriptionActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxAddItemDescriptionActual.Location = new System.Drawing.Point(15, 145);
            this.tbxAddItemDescriptionActual.MaxLength = 100000;
            this.tbxAddItemDescriptionActual.Multiline = true;
            this.tbxAddItemDescriptionActual.Name = "tbxAddItemDescriptionActual";
            this.tbxAddItemDescriptionActual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxAddItemDescriptionActual.Size = new System.Drawing.Size(965, 274);
            this.tbxAddItemDescriptionActual.TabIndex = 20;
            this.tbxAddItemDescriptionActual.TabStop = false;
            this.tbxAddItemDescriptionActual.TextChanged += new System.EventHandler(this.tbxAddItemDescriptionActual_TextChanged);
            // 
            // lblAddItemDescriptionLabel
            // 
            this.lblAddItemDescriptionLabel.AutoSize = true;
            this.lblAddItemDescriptionLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblAddItemDescriptionLabel.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblAddItemDescriptionLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblAddItemDescriptionLabel.Location = new System.Drawing.Point(3, 80);
            this.lblAddItemDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddItemDescriptionLabel.Name = "lblAddItemDescriptionLabel";
            this.lblAddItemDescriptionLabel.Size = new System.Drawing.Size(238, 35);
            this.lblAddItemDescriptionLabel.TabIndex = 6;
            this.lblAddItemDescriptionLabel.Text = "Item Description:";
            // 
            // tbxAddItemNameActual
            // 
            this.tbxAddItemNameActual.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxAddItemNameActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddItemNameActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddItemNameActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxAddItemNameActual.Font = new System.Drawing.Font("Doppio One", 19F);
            this.tbxAddItemNameActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxAddItemNameActual.Location = new System.Drawing.Point(249, 9);
            this.tbxAddItemNameActual.MaxLength = 100;
            this.tbxAddItemNameActual.Name = "tbxAddItemNameActual";
            this.tbxAddItemNameActual.Size = new System.Drawing.Size(652, 39);
            this.tbxAddItemNameActual.TabIndex = 5;
            this.tbxAddItemNameActual.TextChanged += new System.EventHandler(this.tbxAddItemNameActual_TextChanged);
            // 
            // lblAddItemNameLabel
            // 
            this.lblAddItemNameLabel.AutoSize = true;
            this.lblAddItemNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblAddItemNameLabel.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblAddItemNameLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblAddItemNameLabel.Location = new System.Drawing.Point(4, 9);
            this.lblAddItemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddItemNameLabel.Name = "lblAddItemNameLabel";
            this.lblAddItemNameLabel.Size = new System.Drawing.Size(164, 35);
            this.lblAddItemNameLabel.TabIndex = 4;
            this.lblAddItemNameLabel.Text = "Item Name:";
            // 
            // lblRequired7
            // 
            this.lblRequired7.AutoSize = true;
            this.lblRequired7.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired7.Font = new System.Drawing.Font("Doppio One", 19F);
            this.lblRequired7.ForeColor = System.Drawing.Color.Red;
            this.lblRequired7.Location = new System.Drawing.Point(426, 85);
            this.lblRequired7.Name = "lblRequired7";
            this.lblRequired7.Size = new System.Drawing.Size(25, 32);
            this.lblRequired7.TabIndex = 95;
            this.lblRequired7.Text = "*";
            // 
            // lblRequired6
            // 
            this.lblRequired6.AutoSize = true;
            this.lblRequired6.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired6.Font = new System.Drawing.Font("Doppio One", 19F);
            this.lblRequired6.ForeColor = System.Drawing.Color.Red;
            this.lblRequired6.Location = new System.Drawing.Point(945, 12);
            this.lblRequired6.Name = "lblRequired6";
            this.lblRequired6.Size = new System.Drawing.Size(25, 32);
            this.lblRequired6.TabIndex = 94;
            this.lblRequired6.Text = "*";
            // 
            // lblRequired8
            // 
            this.lblRequired8.AutoSize = true;
            this.lblRequired8.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired8.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblRequired8.ForeColor = System.Drawing.Color.Red;
            this.lblRequired8.Location = new System.Drawing.Point(946, 437);
            this.lblRequired8.Name = "lblRequired8";
            this.lblRequired8.Size = new System.Drawing.Size(23, 29);
            this.lblRequired8.TabIndex = 96;
            this.lblRequired8.Text = "*";
            // 
            // lblRequired9
            // 
            this.lblRequired9.AutoSize = true;
            this.lblRequired9.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired9.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblRequired9.ForeColor = System.Drawing.Color.Red;
            this.lblRequired9.Location = new System.Drawing.Point(576, 511);
            this.lblRequired9.Name = "lblRequired9";
            this.lblRequired9.Size = new System.Drawing.Size(23, 29);
            this.lblRequired9.TabIndex = 97;
            this.lblRequired9.Text = "*";
            // 
            // lblRequired10
            // 
            this.lblRequired10.AutoSize = true;
            this.lblRequired10.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired10.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblRequired10.ForeColor = System.Drawing.Color.Red;
            this.lblRequired10.Location = new System.Drawing.Point(462, 589);
            this.lblRequired10.Name = "lblRequired10";
            this.lblRequired10.Size = new System.Drawing.Size(23, 29);
            this.lblRequired10.TabIndex = 98;
            this.lblRequired10.Text = "*";
            // 
            // lblRequired11
            // 
            this.lblRequired11.AutoSize = true;
            this.lblRequired11.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired11.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblRequired11.ForeColor = System.Drawing.Color.Red;
            this.lblRequired11.Location = new System.Drawing.Point(474, 658);
            this.lblRequired11.Name = "lblRequired11";
            this.lblRequired11.Size = new System.Drawing.Size(23, 29);
            this.lblRequired11.TabIndex = 99;
            this.lblRequired11.Text = "*";
            // 
            // lblRequired12
            // 
            this.lblRequired12.AutoSize = true;
            this.lblRequired12.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired12.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblRequired12.ForeColor = System.Drawing.Color.Red;
            this.lblRequired12.Location = new System.Drawing.Point(718, 729);
            this.lblRequired12.Name = "lblRequired12";
            this.lblRequired12.Size = new System.Drawing.Size(23, 29);
            this.lblRequired12.TabIndex = 100;
            this.lblRequired12.Text = "*";
            // 
            // btnPrintInventory
            // 
            this.btnPrintInventory.Font = new System.Drawing.Font("Doppio One", 22F, System.Drawing.FontStyle.Bold);
            this.btnPrintInventory.Location = new System.Drawing.Point(1056, 694);
            this.btnPrintInventory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPrintInventory.Name = "btnPrintInventory";
            this.btnPrintInventory.Size = new System.Drawing.Size(184, 69);
            this.btnPrintInventory.TabIndex = 85;
            this.btnPrintInventory.Text = "Print";
            this.btnPrintInventory.UseVisualStyleBackColor = true;
            this.btnPrintInventory.Click += new System.EventHandler(this.btnPrintInventory_Click);
            // 
            // hlpInventory
            // 
            this.hlpInventory.HelpNamespace = "Manager.chm";
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.pbxItemImage);
            this.pnlImage.Location = new System.Drawing.Point(1018, 12);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(626, 665);
            this.pnlImage.TabIndex = 99;
            // 
            // pbxItemImage
            // 
            this.pbxItemImage.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.pbxItemImage.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pbxItemImage.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbxItemImage.Location = new System.Drawing.Point(0, 0);
            this.pbxItemImage.Margin = new System.Windows.Forms.Padding(6);
            this.pbxItemImage.Name = "pbxItemImage";
            this.pbxItemImage.Size = new System.Drawing.Size(626, 665);
            this.pbxItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxItemImage.TabIndex = 1;
            this.pbxItemImage.TabStop = false;
            this.pbxItemImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxItemImage_MouseDown);
            this.pbxItemImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxItemImage_MouseMove);
            this.pbxItemImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxItemImage_MouseUp);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.ClientSize = new System.Drawing.Size(1659, 777);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlModify);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.btnPrintInventory);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnModifyItem);
            this.Controls.Add(this.btnAddItem);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInventory_FormClosing);
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.VisibleChanged += new System.EventHandler(this.frmInventory_VisibleChanged);
            this.pnlModify.ResumeLayout(false);
            this.pnlModify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnModifyItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Panel pnlModify;
        private System.Windows.Forms.TextBox tbxEditItemNameActual;
        private System.Windows.Forms.Label lblEditItemNameLabel;
        private System.Windows.Forms.Label lblEditItemDescriptionLabel;
        private System.Windows.Forms.TextBox tbxEditDescriptionActual;
        private System.Windows.Forms.TextBox tbxEditRetailPriceActual;
        private System.Windows.Forms.Label lblEditRetailPriceLabel;
        private System.Windows.Forms.TextBox tbxEditRestockThresholdActual;
        private System.Windows.Forms.Label lblEditRestockThresholdLabel;
        private System.Windows.Forms.TextBox tbxEditQuantityActual;
        private System.Windows.Forms.Label lblEditQuantityLabel;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditImage;
        private System.Windows.Forms.Label lblValidEditItemName;
        private System.Windows.Forms.Label lblValidEditRetailPrice;
        private System.Windows.Forms.Label lblValidEditItemDescription;
        private System.Windows.Forms.Label lblValidEditRestockThreshold;
        private System.Windows.Forms.Label lblValidEditQuantity;
        private System.Windows.Forms.Label lblValidEditImage;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label lblValidAddImage;
        private System.Windows.Forms.Label lblValidAddRestockThreshold;
        private System.Windows.Forms.Label lblValidAddQuantity;
        private System.Windows.Forms.Label lblValidAddRetailPrice;
        private System.Windows.Forms.Label lblValidAddItemDescription;
        private System.Windows.Forms.Label lblValidAddItemName;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.TextBox tbxAddRestockThresholdActual;
        private System.Windows.Forms.Label lblAddRestockThresholdLabel;
        private System.Windows.Forms.TextBox tbxAddQuantityActual;
        private System.Windows.Forms.Label lblAddQuantityLabel;
        private System.Windows.Forms.TextBox tbxAddRetailPriceActual;
        private System.Windows.Forms.Label lblAddRetailPriceLabel;
        private System.Windows.Forms.TextBox tbxAddItemDescriptionActual;
        private System.Windows.Forms.Label lblAddItemDescriptionLabel;
        private System.Windows.Forms.TextBox tbxAddItemNameActual;
        private System.Windows.Forms.Label lblAddItemNameLabel;
        private System.Windows.Forms.Label lblValidAddCategory;
        private System.Windows.Forms.Label lblAddCategoryLabel;
        private System.Windows.Forms.Label lblValidAddCost;
        private System.Windows.Forms.TextBox tbxAddCostActual;
        private System.Windows.Forms.Label lblAddCostLabel;
        private System.Windows.Forms.Button btnPrintInventory;
        private System.Windows.Forms.Label lblRequired2;
        private System.Windows.Forms.Label lblRequired1;
        private System.Windows.Forms.Label lblRequired5;
        private System.Windows.Forms.Label lblRequired4;
        private System.Windows.Forms.Label lblRequired3;
        private System.Windows.Forms.Label lblRequired8;
        private System.Windows.Forms.Label lblRequired7;
        private System.Windows.Forms.Label lblRequired6;
        private System.Windows.Forms.Label lblRequired9;
        private System.Windows.Forms.Label lblRequired10;
        private System.Windows.Forms.Label lblRequired11;
        private System.Windows.Forms.Label lblRequired12;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.HelpProvider hlpInventory;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox pbxItemImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestockThreshold;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Discontinued;
    }
}
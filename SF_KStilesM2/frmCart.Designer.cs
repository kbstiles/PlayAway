namespace SF_KStilesM2
{
    partial class frmCart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.btnContinueShopping = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.hlpCart = new System.Windows.Forms.HelpProvider();
            this.lblSubtotalLabel = new System.Windows.Forms.Label();
            this.lblTaxLabel = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblDiscountCode = new System.Windows.Forms.Label();
            this.tbxDiscountCodeActual = new System.Windows.Forms.TextBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.tbxCCNum = new System.Windows.Forms.TextBox();
            this.lblCCV = new System.Windows.Forms.Label();
            this.tbxCCV = new System.Windows.Forms.TextBox();
            this.tbxExpiration = new System.Windows.Forms.TextBox();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.lblSubtotalActual = new System.Windows.Forms.Label();
            this.lblTaxActual = new System.Windows.Forms.Label();
            this.lblTotalActual = new System.Windows.Forms.Label();
            this.lblDiscountSubtotalActual = new System.Windows.Forms.Label();
            this.lblDiscountSubtotalLabel = new System.Windows.Forms.Label();
            this.lblValidCCNum = new System.Windows.Forms.Label();
            this.lblValidCCV = new System.Windows.Forms.Label();
            this.lblValidExpDate = new System.Windows.Forms.Label();
            this.lblRequired1 = new System.Windows.Forms.Label();
            this.lblRequired2 = new System.Windows.Forms.Label();
            this.lblRequired3 = new System.Windows.Forms.Label();
            this.btnModifyQuantity = new System.Windows.Forms.Button();
            this.lblNewQuantity = new System.Windows.Forms.Label();
            this.cbxQuantity = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProductNameActual = new System.Windows.Forms.Label();
            this.lblProductNameLabel = new System.Windows.Forms.Label();
            this.lblProductPriceActual = new System.Windows.Forms.Label();
            this.lblProductPriceLabel = new System.Windows.Forms.Label();
            this.lblCurrentQuantityActual = new System.Windows.Forms.Label();
            this.lblCurrentQuantityLabel = new System.Windows.Forms.Label();
            this.tmrDiscount = new System.Windows.Forms.Timer(this.components);
            this.lblDiscountLevelActual = new System.Windows.Forms.Label();
            this.lblDiscountLevelLabel = new System.Windows.Forms.Label();
            this.lblDiscountTypeActual = new System.Windows.Forms.Label();
            this.lblDiscountTypeLabel = new System.Windows.Forms.Label();
            this.lblDiscountAmountActual = new System.Windows.Forms.Label();
            this.lblDiscountAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCart
            // 
            this.lbxCart.BackColor = global::SF_KStilesM2.Properties.Settings.Default.boxBack;
            this.lbxCart.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "boxBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbxCart.Font = new System.Drawing.Font("Doppio One", 15F);
            this.lbxCart.ForeColor = System.Drawing.Color.Black;
            this.lbxCart.HorizontalScrollbar = true;
            this.lbxCart.ItemHeight = 25;
            this.lbxCart.Location = new System.Drawing.Point(20, 20);
            this.lbxCart.Margin = new System.Windows.Forms.Padding(4);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(366, 229);
            this.lbxCart.TabIndex = 0;
            this.lbxCart.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxCart_DrawItem);
            this.lbxCart.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lbxCart_MeasureItem);
            this.lbxCart.SelectedIndexChanged += new System.EventHandler(this.lbxCart_SelectedIndexChanged);
            // 
            // btnContinueShopping
            // 
            this.btnContinueShopping.Font = new System.Drawing.Font("Doppio One", 12F);
            this.btnContinueShopping.Location = new System.Drawing.Point(404, 30);
            this.btnContinueShopping.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.Size = new System.Drawing.Size(170, 48);
            this.btnContinueShopping.TabIndex = 9;
            this.btnContinueShopping.Text = "Continue Shopping";
            this.btnContinueShopping.UseVisualStyleBackColor = true;
            this.btnContinueShopping.Click += new System.EventHandler(this.btnContinueShopping_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Font = new System.Drawing.Font("Doppio One", 18F);
            this.btnRemoveItem.Location = new System.Drawing.Point(404, 118);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(170, 48);
            this.btnRemoveItem.TabIndex = 10;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Font = new System.Drawing.Font("Doppio One", 18F);
            this.btnClearCart.Location = new System.Drawing.Point(600, 117);
            this.btnClearCart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(170, 48);
            this.btnClearCart.TabIndex = 11;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Enabled = false;
            this.btnCheckout.Font = new System.Drawing.Font("Doppio One", 18F);
            this.btnCheckout.Location = new System.Drawing.Point(600, 30);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(170, 48);
            this.btnCheckout.TabIndex = 12;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblHelp.Font = new System.Drawing.Font("Doppio One", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHelp.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblHelp.Location = new System.Drawing.Point(646, 211);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(78, 35);
            this.lblHelp.TabIndex = 15;
            this.lblHelp.Text = "Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // hlpCart
            // 
            this.hlpCart.HelpNamespace = "Shop.chm";
            // 
            // lblSubtotalLabel
            // 
            this.lblSubtotalLabel.AutoSize = true;
            this.lblSubtotalLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSubtotalLabel.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblSubtotalLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblSubtotalLabel.Location = new System.Drawing.Point(9, 270);
            this.lblSubtotalLabel.Name = "lblSubtotalLabel";
            this.lblSubtotalLabel.Size = new System.Drawing.Size(104, 25);
            this.lblSubtotalLabel.TabIndex = 17;
            this.lblSubtotalLabel.Text = "Subtotal:";
            // 
            // lblTaxLabel
            // 
            this.lblTaxLabel.AutoSize = true;
            this.lblTaxLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTaxLabel.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTaxLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblTaxLabel.Location = new System.Drawing.Point(9, 338);
            this.lblTaxLabel.Name = "lblTaxLabel";
            this.lblTaxLabel.Size = new System.Drawing.Size(138, 25);
            this.lblTaxLabel.TabIndex = 18;
            this.lblTaxLabel.Text = "Tax Amount:";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTotalLabel.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTotalLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblTotalLabel.Location = new System.Drawing.Point(10, 376);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(115, 25);
            this.lblTotalLabel.TabIndex = 19;
            this.lblTotalLabel.Text = "Total Due:";
            // 
            // lblDiscountCode
            // 
            this.lblDiscountCode.AutoSize = true;
            this.lblDiscountCode.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblDiscountCode.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDiscountCode.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblDiscountCode.Location = new System.Drawing.Point(367, 270);
            this.lblDiscountCode.Name = "lblDiscountCode";
            this.lblDiscountCode.Size = new System.Drawing.Size(162, 25);
            this.lblDiscountCode.TabIndex = 20;
            this.lblDiscountCode.Text = "Discount Code:";
            // 
            // tbxDiscountCodeActual
            // 
            this.tbxDiscountCodeActual.Font = new System.Drawing.Font("Doppio One", 15F);
            this.tbxDiscountCodeActual.Location = new System.Drawing.Point(535, 267);
            this.tbxDiscountCodeActual.Name = "tbxDiscountCodeActual";
            this.tbxDiscountCodeActual.Size = new System.Drawing.Size(238, 32);
            this.tbxDiscountCodeActual.TabIndex = 21;
            this.tbxDiscountCodeActual.TextChanged += new System.EventHandler(this.tbxDiscountCode_TextChanged);
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCard.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCard.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblCard.Location = new System.Drawing.Point(10, 421);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(193, 25);
            this.lblCard.TabIndex = 23;
            this.lblCard.Text = "VISA/MasterCard:";
            // 
            // tbxCCNum
            // 
            this.tbxCCNum.Font = new System.Drawing.Font("Doppio One", 15F);
            this.tbxCCNum.Location = new System.Drawing.Point(207, 418);
            this.tbxCCNum.MaxLength = 16;
            this.tbxCCNum.Name = "tbxCCNum";
            this.tbxCCNum.Size = new System.Drawing.Size(203, 32);
            this.tbxCCNum.TabIndex = 24;
            this.tbxCCNum.TextChanged += new System.EventHandler(this.tbxCCNum_TextChanged);
            // 
            // lblCCV
            // 
            this.lblCCV.AutoSize = true;
            this.lblCCV.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCCV.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCCV.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblCCV.Location = new System.Drawing.Point(446, 421);
            this.lblCCV.Name = "lblCCV";
            this.lblCCV.Size = new System.Drawing.Size(57, 25);
            this.lblCCV.TabIndex = 25;
            this.lblCCV.Text = "CCV:";
            // 
            // tbxCCV
            // 
            this.tbxCCV.Font = new System.Drawing.Font("Doppio One", 15F);
            this.tbxCCV.Location = new System.Drawing.Point(509, 418);
            this.tbxCCV.MaxLength = 3;
            this.tbxCCV.Name = "tbxCCV";
            this.tbxCCV.Size = new System.Drawing.Size(50, 32);
            this.tbxCCV.TabIndex = 26;
            this.tbxCCV.TextChanged += new System.EventHandler(this.tbxCCV_TextChanged);
            // 
            // tbxExpiration
            // 
            this.tbxExpiration.Font = new System.Drawing.Font("Doppio One", 15F);
            this.tbxExpiration.Location = new System.Drawing.Point(654, 418);
            this.tbxExpiration.MaxLength = 7;
            this.tbxExpiration.Name = "tbxExpiration";
            this.tbxExpiration.Size = new System.Drawing.Size(92, 32);
            this.tbxExpiration.TabIndex = 28;
            this.tbxExpiration.TextChanged += new System.EventHandler(this.tbxExpiration_TextChanged);
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblExpiration.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblExpiration.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblExpiration.Location = new System.Drawing.Point(596, 421);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(52, 25);
            this.lblExpiration.TabIndex = 27;
            this.lblExpiration.Text = "Exp:";
            // 
            // lblSubtotalActual
            // 
            this.lblSubtotalActual.AutoSize = true;
            this.lblSubtotalActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSubtotalActual.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblSubtotalActual.Location = new System.Drawing.Point(110, 272);
            this.lblSubtotalActual.Name = "lblSubtotalActual";
            this.lblSubtotalActual.Size = new System.Drawing.Size(0, 25);
            this.lblSubtotalActual.TabIndex = 29;
            // 
            // lblTaxActual
            // 
            this.lblTaxActual.AutoSize = true;
            this.lblTaxActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTaxActual.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblTaxActual.Location = new System.Drawing.Point(144, 340);
            this.lblTaxActual.Name = "lblTaxActual";
            this.lblTaxActual.Size = new System.Drawing.Size(0, 25);
            this.lblTaxActual.TabIndex = 30;
            // 
            // lblTotalActual
            // 
            this.lblTotalActual.AutoSize = true;
            this.lblTotalActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTotalActual.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblTotalActual.Location = new System.Drawing.Point(122, 378);
            this.lblTotalActual.Name = "lblTotalActual";
            this.lblTotalActual.Size = new System.Drawing.Size(0, 25);
            this.lblTotalActual.TabIndex = 31;
            // 
            // lblDiscountSubtotalActual
            // 
            this.lblDiscountSubtotalActual.AutoSize = true;
            this.lblDiscountSubtotalActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblDiscountSubtotalActual.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountSubtotalActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblDiscountSubtotalActual.Location = new System.Drawing.Point(230, 307);
            this.lblDiscountSubtotalActual.Name = "lblDiscountSubtotalActual";
            this.lblDiscountSubtotalActual.Size = new System.Drawing.Size(0, 25);
            this.lblDiscountSubtotalActual.TabIndex = 36;
            this.lblDiscountSubtotalActual.Visible = false;
            // 
            // lblDiscountSubtotalLabel
            // 
            this.lblDiscountSubtotalLabel.AutoSize = true;
            this.lblDiscountSubtotalLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblDiscountSubtotalLabel.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDiscountSubtotalLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblDiscountSubtotalLabel.Location = new System.Drawing.Point(9, 305);
            this.lblDiscountSubtotalLabel.Name = "lblDiscountSubtotalLabel";
            this.lblDiscountSubtotalLabel.Size = new System.Drawing.Size(224, 25);
            this.lblDiscountSubtotalLabel.TabIndex = 35;
            this.lblDiscountSubtotalLabel.Text = "Discounted Subtotal:";
            this.lblDiscountSubtotalLabel.Visible = false;
            // 
            // lblValidCCNum
            // 
            this.lblValidCCNum.AutoSize = true;
            this.lblValidCCNum.BackColor = System.Drawing.Color.Transparent;
            this.lblValidCCNum.Font = new System.Drawing.Font("Cascadia Code", 19F, System.Drawing.FontStyle.Bold);
            this.lblValidCCNum.ForeColor = System.Drawing.Color.Red;
            this.lblValidCCNum.Location = new System.Drawing.Point(407, 416);
            this.lblValidCCNum.Name = "lblValidCCNum";
            this.lblValidCCNum.Size = new System.Drawing.Size(30, 34);
            this.lblValidCCNum.TabIndex = 37;
            this.lblValidCCNum.Text = "X";
            // 
            // lblValidCCV
            // 
            this.lblValidCCV.AutoSize = true;
            this.lblValidCCV.Font = new System.Drawing.Font("Cascadia Code", 19F, System.Drawing.FontStyle.Bold);
            this.lblValidCCV.ForeColor = System.Drawing.Color.Red;
            this.lblValidCCV.Location = new System.Drawing.Point(557, 416);
            this.lblValidCCV.Name = "lblValidCCV";
            this.lblValidCCV.Size = new System.Drawing.Size(30, 34);
            this.lblValidCCV.TabIndex = 38;
            this.lblValidCCV.Text = "X";
            // 
            // lblValidExpDate
            // 
            this.lblValidExpDate.AutoSize = true;
            this.lblValidExpDate.Font = new System.Drawing.Font("Cascadia Code", 19F, System.Drawing.FontStyle.Bold);
            this.lblValidExpDate.ForeColor = System.Drawing.Color.Red;
            this.lblValidExpDate.Location = new System.Drawing.Point(745, 416);
            this.lblValidExpDate.Name = "lblValidExpDate";
            this.lblValidExpDate.Size = new System.Drawing.Size(30, 34);
            this.lblValidExpDate.TabIndex = 39;
            this.lblValidExpDate.Text = "X";
            // 
            // lblRequired1
            // 
            this.lblRequired1.AutoSize = true;
            this.lblRequired1.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired1.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.lblRequired1.ForeColor = System.Drawing.Color.Red;
            this.lblRequired1.Location = new System.Drawing.Point(428, 420);
            this.lblRequired1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired1.Name = "lblRequired1";
            this.lblRequired1.Size = new System.Drawing.Size(24, 27);
            this.lblRequired1.TabIndex = 59;
            this.lblRequired1.Text = "*";
            // 
            // lblRequired2
            // 
            this.lblRequired2.AutoSize = true;
            this.lblRequired2.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired2.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.lblRequired2.ForeColor = System.Drawing.Color.Red;
            this.lblRequired2.Location = new System.Drawing.Point(578, 419);
            this.lblRequired2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired2.Name = "lblRequired2";
            this.lblRequired2.Size = new System.Drawing.Size(24, 27);
            this.lblRequired2.TabIndex = 60;
            this.lblRequired2.Text = "*";
            // 
            // lblRequired3
            // 
            this.lblRequired3.AutoSize = true;
            this.lblRequired3.BackColor = System.Drawing.Color.Transparent;
            this.lblRequired3.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.lblRequired3.ForeColor = System.Drawing.Color.Red;
            this.lblRequired3.Location = new System.Drawing.Point(766, 421);
            this.lblRequired3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequired3.Name = "lblRequired3";
            this.lblRequired3.Size = new System.Drawing.Size(24, 27);
            this.lblRequired3.TabIndex = 61;
            this.lblRequired3.Text = "*";
            // 
            // btnModifyQuantity
            // 
            this.btnModifyQuantity.Enabled = false;
            this.btnModifyQuantity.Font = new System.Drawing.Font("Doppio One", 14F);
            this.btnModifyQuantity.Location = new System.Drawing.Point(404, 204);
            this.btnModifyQuantity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModifyQuantity.Name = "btnModifyQuantity";
            this.btnModifyQuantity.Size = new System.Drawing.Size(170, 48);
            this.btnModifyQuantity.TabIndex = 63;
            this.btnModifyQuantity.Text = "Modify Quantity";
            this.btnModifyQuantity.UseVisualStyleBackColor = true;
            this.btnModifyQuantity.Click += new System.EventHandler(this.btnModifyQuantity_Click);
            // 
            // lblNewQuantity
            // 
            this.lblNewQuantity.AutoSize = true;
            this.lblNewQuantity.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblNewQuantity.Font = new System.Drawing.Font("Doppio One", 17F);
            this.lblNewQuantity.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblNewQuantity.Location = new System.Drawing.Point(22, 187);
            this.lblNewQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewQuantity.Name = "lblNewQuantity";
            this.lblNewQuantity.Size = new System.Drawing.Size(162, 29);
            this.lblNewQuantity.TabIndex = 65;
            this.lblNewQuantity.Text = "New Quantity:";
            this.lblNewQuantity.Visible = false;
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.DropDownHeight = 100;
            this.cbxQuantity.Enabled = false;
            this.cbxQuantity.Font = new System.Drawing.Font("Doppio One", 15F);
            this.cbxQuantity.FormattingEnabled = true;
            this.cbxQuantity.IntegralHeight = false;
            this.cbxQuantity.Location = new System.Drawing.Point(185, 187);
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(198, 33);
            this.cbxQuantity.TabIndex = 64;
            this.cbxQuantity.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Doppio One", 14F);
            this.btnSave.Location = new System.Drawing.Point(113, 230);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 37);
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblProductNameActual
            // 
            this.lblProductNameActual.AutoSize = true;
            this.lblProductNameActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblProductNameActual.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblProductNameActual.Location = new System.Drawing.Point(23, 49);
            this.lblProductNameActual.Name = "lblProductNameActual";
            this.lblProductNameActual.Size = new System.Drawing.Size(0, 25);
            this.lblProductNameActual.TabIndex = 68;
            this.lblProductNameActual.Visible = false;
            // 
            // lblProductNameLabel
            // 
            this.lblProductNameLabel.AutoSize = true;
            this.lblProductNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblProductNameLabel.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblProductNameLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblProductNameLabel.Location = new System.Drawing.Point(23, 23);
            this.lblProductNameLabel.Name = "lblProductNameLabel";
            this.lblProductNameLabel.Size = new System.Drawing.Size(162, 25);
            this.lblProductNameLabel.TabIndex = 67;
            this.lblProductNameLabel.Text = "Product Name:";
            this.lblProductNameLabel.Visible = false;
            // 
            // lblProductPriceActual
            // 
            this.lblProductPriceActual.AutoSize = true;
            this.lblProductPriceActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblProductPriceActual.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPriceActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblProductPriceActual.Location = new System.Drawing.Point(23, 102);
            this.lblProductPriceActual.Name = "lblProductPriceActual";
            this.lblProductPriceActual.Size = new System.Drawing.Size(0, 25);
            this.lblProductPriceActual.TabIndex = 70;
            this.lblProductPriceActual.Visible = false;
            // 
            // lblProductPriceLabel
            // 
            this.lblProductPriceLabel.AutoSize = true;
            this.lblProductPriceLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblProductPriceLabel.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblProductPriceLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblProductPriceLabel.Location = new System.Drawing.Point(23, 76);
            this.lblProductPriceLabel.Name = "lblProductPriceLabel";
            this.lblProductPriceLabel.Size = new System.Drawing.Size(62, 25);
            this.lblProductPriceLabel.TabIndex = 69;
            this.lblProductPriceLabel.Text = "Cost:";
            this.lblProductPriceLabel.Visible = false;
            // 
            // lblCurrentQuantityActual
            // 
            this.lblCurrentQuantityActual.AutoSize = true;
            this.lblCurrentQuantityActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCurrentQuantityActual.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuantityActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblCurrentQuantityActual.Location = new System.Drawing.Point(23, 155);
            this.lblCurrentQuantityActual.Name = "lblCurrentQuantityActual";
            this.lblCurrentQuantityActual.Size = new System.Drawing.Size(0, 25);
            this.lblCurrentQuantityActual.TabIndex = 72;
            this.lblCurrentQuantityActual.Visible = false;
            // 
            // lblCurrentQuantityLabel
            // 
            this.lblCurrentQuantityLabel.AutoSize = true;
            this.lblCurrentQuantityLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCurrentQuantityLabel.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCurrentQuantityLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblCurrentQuantityLabel.Location = new System.Drawing.Point(23, 129);
            this.lblCurrentQuantityLabel.Name = "lblCurrentQuantityLabel";
            this.lblCurrentQuantityLabel.Size = new System.Drawing.Size(254, 25);
            this.lblCurrentQuantityLabel.TabIndex = 71;
            this.lblCurrentQuantityLabel.Text = "Current Order Quantity:";
            this.lblCurrentQuantityLabel.Visible = false;
            // 
            // tmrDiscount
            // 
            this.tmrDiscount.Interval = 5000;
            this.tmrDiscount.Tick += new System.EventHandler(this.discountTimer_Tick);
            // 
            // lblDiscountLevelActual
            // 
            this.lblDiscountLevelActual.AutoSize = true;
            this.lblDiscountLevelActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblDiscountLevelActual.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountLevelActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblDiscountLevelActual.Location = new System.Drawing.Point(558, 311);
            this.lblDiscountLevelActual.Name = "lblDiscountLevelActual";
            this.lblDiscountLevelActual.Size = new System.Drawing.Size(0, 25);
            this.lblDiscountLevelActual.TabIndex = 124;
            this.lblDiscountLevelActual.Visible = false;
            // 
            // lblDiscountLevelLabel
            // 
            this.lblDiscountLevelLabel.AutoSize = true;
            this.lblDiscountLevelLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblDiscountLevelLabel.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDiscountLevelLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblDiscountLevelLabel.Location = new System.Drawing.Point(394, 311);
            this.lblDiscountLevelLabel.Name = "lblDiscountLevelLabel";
            this.lblDiscountLevelLabel.Size = new System.Drawing.Size(165, 25);
            this.lblDiscountLevelLabel.TabIndex = 123;
            this.lblDiscountLevelLabel.Text = "Discount Level:";
            this.lblDiscountLevelLabel.Visible = false;
            // 
            // lblDiscountTypeActual
            // 
            this.lblDiscountTypeActual.AutoSize = true;
            this.lblDiscountTypeActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblDiscountTypeActual.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountTypeActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblDiscountTypeActual.Location = new System.Drawing.Point(553, 344);
            this.lblDiscountTypeActual.Name = "lblDiscountTypeActual";
            this.lblDiscountTypeActual.Size = new System.Drawing.Size(0, 25);
            this.lblDiscountTypeActual.TabIndex = 122;
            // 
            // lblDiscountTypeLabel
            // 
            this.lblDiscountTypeLabel.AutoSize = true;
            this.lblDiscountTypeLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblDiscountTypeLabel.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDiscountTypeLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblDiscountTypeLabel.Location = new System.Drawing.Point(394, 344);
            this.lblDiscountTypeLabel.Name = "lblDiscountTypeLabel";
            this.lblDiscountTypeLabel.Size = new System.Drawing.Size(160, 25);
            this.lblDiscountTypeLabel.TabIndex = 121;
            this.lblDiscountTypeLabel.Text = "Discount Type:";
            // 
            // lblDiscountAmountActual
            // 
            this.lblDiscountAmountActual.AutoSize = true;
            this.lblDiscountAmountActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblDiscountAmountActual.Font = new System.Drawing.Font("Doppio One", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountAmountActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblDiscountAmountActual.Location = new System.Drawing.Point(585, 376);
            this.lblDiscountAmountActual.Name = "lblDiscountAmountActual";
            this.lblDiscountAmountActual.Size = new System.Drawing.Size(0, 25);
            this.lblDiscountAmountActual.TabIndex = 120;
            // 
            // lblDiscountAmountLabel
            // 
            this.lblDiscountAmountLabel.AutoSize = true;
            this.lblDiscountAmountLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblDiscountAmountLabel.Font = new System.Drawing.Font("Doppio One", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDiscountAmountLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblDiscountAmountLabel.Location = new System.Drawing.Point(394, 376);
            this.lblDiscountAmountLabel.Name = "lblDiscountAmountLabel";
            this.lblDiscountAmountLabel.Size = new System.Drawing.Size(191, 25);
            this.lblDiscountAmountLabel.TabIndex = 119;
            this.lblDiscountAmountLabel.Text = "Discount Amount:";
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.ClientSize = new System.Drawing.Size(789, 460);
            this.Controls.Add(this.lblDiscountLevelActual);
            this.Controls.Add(this.lblDiscountLevelLabel);
            this.Controls.Add(this.lblDiscountTypeActual);
            this.Controls.Add(this.lblDiscountTypeLabel);
            this.Controls.Add(this.lblDiscountAmountActual);
            this.Controls.Add(this.lblDiscountAmountLabel);
            this.Controls.Add(this.lblCurrentQuantityActual);
            this.Controls.Add(this.lblCurrentQuantityLabel);
            this.Controls.Add(this.lblProductPriceActual);
            this.Controls.Add(this.lblProductPriceLabel);
            this.Controls.Add(this.lblProductNameActual);
            this.Controls.Add(this.lblProductNameLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNewQuantity);
            this.Controls.Add(this.cbxQuantity);
            this.Controls.Add(this.btnModifyQuantity);
            this.Controls.Add(this.lblRequired3);
            this.Controls.Add(this.lblRequired2);
            this.Controls.Add(this.lblRequired1);
            this.Controls.Add(this.lblDiscountSubtotalActual);
            this.Controls.Add(this.lblDiscountSubtotalLabel);
            this.Controls.Add(this.lblTotalActual);
            this.Controls.Add(this.lblTaxActual);
            this.Controls.Add(this.lblSubtotalActual);
            this.Controls.Add(this.tbxExpiration);
            this.Controls.Add(this.lblExpiration);
            this.Controls.Add(this.tbxCCV);
            this.Controls.Add(this.lblCCV);
            this.Controls.Add(this.tbxCCNum);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.tbxDiscountCodeActual);
            this.Controls.Add(this.lblDiscountCode);
            this.Controls.Add(this.lblTotalLabel);
            this.Controls.Add(this.lblTaxLabel);
            this.Controls.Add(this.lblSubtotalLabel);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnContinueShopping);
            this.Controls.Add(this.lbxCart);
            this.Controls.Add(this.lblValidExpDate);
            this.Controls.Add(this.lblValidCCV);
            this.Controls.Add(this.lblValidCCNum);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Doppio One", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCart_FormClosing);
            this.Load += new System.EventHandler(this.frmCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCart;
        private System.Windows.Forms.Button btnContinueShopping;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.HelpProvider hlpCart;
        private System.Windows.Forms.Label lblSubtotalLabel;
        private System.Windows.Forms.Label lblTaxLabel;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblDiscountCode;
        private System.Windows.Forms.TextBox tbxDiscountCodeActual;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.TextBox tbxCCNum;
        private System.Windows.Forms.Label lblCCV;
        private System.Windows.Forms.TextBox tbxCCV;
        private System.Windows.Forms.TextBox tbxExpiration;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.Label lblSubtotalActual;
        private System.Windows.Forms.Label lblTaxActual;
        private System.Windows.Forms.Label lblTotalActual;
        private System.Windows.Forms.Label lblDiscountSubtotalActual;
        private System.Windows.Forms.Label lblDiscountSubtotalLabel;
        private System.Windows.Forms.Label lblValidCCNum;
        private System.Windows.Forms.Label lblValidCCV;
        private System.Windows.Forms.Label lblValidExpDate;
        private System.Windows.Forms.Label lblRequired1;
        private System.Windows.Forms.Label lblRequired2;
        private System.Windows.Forms.Label lblRequired3;
        private System.Windows.Forms.Button btnModifyQuantity;
        private System.Windows.Forms.Label lblNewQuantity;
        private System.Windows.Forms.ComboBox cbxQuantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblProductNameActual;
        private System.Windows.Forms.Label lblProductNameLabel;
        private System.Windows.Forms.Label lblProductPriceActual;
        private System.Windows.Forms.Label lblProductPriceLabel;
        private System.Windows.Forms.Label lblCurrentQuantityActual;
        private System.Windows.Forms.Label lblCurrentQuantityLabel;
        private System.Windows.Forms.Timer tmrDiscount;
        private System.Windows.Forms.Label lblDiscountLevelActual;
        private System.Windows.Forms.Label lblDiscountLevelLabel;
        private System.Windows.Forms.Label lblDiscountTypeActual;
        private System.Windows.Forms.Label lblDiscountTypeLabel;
        private System.Windows.Forms.Label lblDiscountAmountActual;
        private System.Windows.Forms.Label lblDiscountAmountLabel;
    }
}
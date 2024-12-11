namespace SF_KStilesM2
{
    partial class frmShopPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShopPOS));
            this.lblCategoryActual = new System.Windows.Forms.Label();
            this.lblCategoryLabel = new System.Windows.Forms.Label();
            this.lblPriceActual = new System.Windows.Forms.Label();
            this.lblQuantityActual = new System.Windows.Forms.Label();
            this.tbxDescriptionActual = new System.Windows.Forms.TextBox();
            this.lblPriceLabel = new System.Windows.Forms.Label();
            this.lblQuantityLabel = new System.Windows.Forms.Label();
            this.lblDescriptionLabel = new System.Windows.Forms.Label();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.cbxPrice = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblQuantityAmountLabel = new System.Windows.Forms.Label();
            this.cbxQuantity = new System.Windows.Forms.ComboBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.hlpShopPOS = new System.Windows.Forms.HelpProvider();
            this.pnlCartCount = new System.Windows.Forms.Panel();
            this.lblCartCount = new System.Windows.Forms.Label();
            this.pbxCartImage = new System.Windows.Forms.PictureBox();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pbxItemImage = new System.Windows.Forms.PictureBox();
            this.pnlCartCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCartImage)).BeginInit();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoryActual
            // 
            this.lblCategoryActual.AutoSize = true;
            this.lblCategoryActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCategoryActual.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblCategoryActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblCategoryActual.Location = new System.Drawing.Point(593, 387);
            this.lblCategoryActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryActual.Name = "lblCategoryActual";
            this.lblCategoryActual.Size = new System.Drawing.Size(0, 35);
            this.lblCategoryActual.TabIndex = 69;
            // 
            // lblCategoryLabel
            // 
            this.lblCategoryLabel.AutoSize = true;
            this.lblCategoryLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCategoryLabel.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblCategoryLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblCategoryLabel.Location = new System.Drawing.Point(383, 387);
            this.lblCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryLabel.Name = "lblCategoryLabel";
            this.lblCategoryLabel.Size = new System.Drawing.Size(205, 35);
            this.lblCategoryLabel.TabIndex = 68;
            this.lblCategoryLabel.Text = "Item Category:";
            // 
            // lblPriceActual
            // 
            this.lblPriceActual.AutoSize = true;
            this.lblPriceActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPriceActual.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblPriceActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblPriceActual.Location = new System.Drawing.Point(541, 493);
            this.lblPriceActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceActual.Name = "lblPriceActual";
            this.lblPriceActual.Size = new System.Drawing.Size(0, 35);
            this.lblPriceActual.TabIndex = 67;
            // 
            // lblQuantityActual
            // 
            this.lblQuantityActual.AutoSize = true;
            this.lblQuantityActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblQuantityActual.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblQuantityActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblQuantityActual.Location = new System.Drawing.Point(594, 445);
            this.lblQuantityActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityActual.Name = "lblQuantityActual";
            this.lblQuantityActual.Size = new System.Drawing.Size(0, 35);
            this.lblQuantityActual.TabIndex = 66;
            // 
            // tbxDescriptionActual
            // 
            this.tbxDescriptionActual.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.tbxDescriptionActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDescriptionActual.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxDescriptionActual.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbxDescriptionActual.Font = new System.Drawing.Font("Doppio One", 21F);
            this.tbxDescriptionActual.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.tbxDescriptionActual.Location = new System.Drawing.Point(544, 58);
            this.tbxDescriptionActual.Multiline = true;
            this.tbxDescriptionActual.Name = "tbxDescriptionActual";
            this.tbxDescriptionActual.ReadOnly = true;
            this.tbxDescriptionActual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDescriptionActual.Size = new System.Drawing.Size(538, 305);
            this.tbxDescriptionActual.TabIndex = 63;
            this.tbxDescriptionActual.TabStop = false;
            // 
            // lblPriceLabel
            // 
            this.lblPriceLabel.AutoSize = true;
            this.lblPriceLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPriceLabel.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblPriceLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblPriceLabel.Location = new System.Drawing.Point(385, 493);
            this.lblPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceLabel.Name = "lblPriceLabel";
            this.lblPriceLabel.Size = new System.Drawing.Size(151, 35);
            this.lblPriceLabel.TabIndex = 65;
            this.lblPriceLabel.Text = "Item Price:";
            // 
            // lblQuantityLabel
            // 
            this.lblQuantityLabel.AutoSize = true;
            this.lblQuantityLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblQuantityLabel.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblQuantityLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblQuantityLabel.Location = new System.Drawing.Point(385, 445);
            this.lblQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityLabel.Name = "lblQuantityLabel";
            this.lblQuantityLabel.Size = new System.Drawing.Size(204, 35);
            this.lblQuantityLabel.TabIndex = 64;
            this.lblQuantityLabel.Text = "Item Quantity:";
            // 
            // lblDescriptionLabel
            // 
            this.lblDescriptionLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblDescriptionLabel.Font = new System.Drawing.Font("Doppio One", 19F);
            this.lblDescriptionLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblDescriptionLabel.Location = new System.Drawing.Point(385, 58);
            this.lblDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptionLabel.Name = "lblDescriptionLabel";
            this.lblDescriptionLabel.Size = new System.Drawing.Size(165, 72);
            this.lblDescriptionLabel.TabIndex = 62;
            this.lblDescriptionLabel.Text = "Item Description:";
            // 
            // lbxItems
            // 
            this.lbxItems.BackColor = global::SF_KStilesM2.Properties.Settings.Default.boxBack;
            this.lbxItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxItems.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "boxBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbxItems.Font = new System.Drawing.Font("Doppio One", 18F);
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.HorizontalScrollbar = true;
            this.lbxItems.ItemHeight = 30;
            this.lbxItems.Location = new System.Drawing.Point(6, 58);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(372, 480);
            this.lbxItems.TabIndex = 61;
            this.lbxItems.SelectedIndexChanged += new System.EventHandler(this.lbxItems_SelectedIndexChanged);
            // 
            // cbxPrice
            // 
            this.cbxPrice.DropDownHeight = 95;
            this.cbxPrice.Font = new System.Drawing.Font("Doppio One", 19F);
            this.cbxPrice.FormattingEnabled = true;
            this.cbxPrice.IntegralHeight = false;
            this.cbxPrice.Items.AddRange(new object[] {
            "None",
            "$0.00 - $9.99",
            "$10.00 - $19.99",
            "$20.00 - $29.99",
            "$30.00 - $39.99",
            "$40.00 - $49.99",
            "$50.00+"});
            this.cbxPrice.Location = new System.Drawing.Point(1116, 8);
            this.cbxPrice.Name = "cbxPrice";
            this.cbxPrice.Size = new System.Drawing.Size(293, 39);
            this.cbxPrice.TabIndex = 60;
            this.cbxPrice.Text = "Price Filter";
            this.cbxPrice.SelectedIndexChanged += new System.EventHandler(this.cbxPrice_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Doppio One", 19F);
            this.btnSearch.Location = new System.Drawing.Point(523, 8);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 40);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblHelp.Font = new System.Drawing.Font("Doppio One", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHelp.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblHelp.Location = new System.Drawing.Point(1438, 558);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(78, 35);
            this.lblHelp.TabIndex = 58;
            this.lblHelp.Text = "Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Doppio One", 19F);
            this.btnClear.Location = new System.Drawing.Point(1418, 8);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 57;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxCategories
            // 
            this.cbxCategories.DropDownHeight = 95;
            this.cbxCategories.Font = new System.Drawing.Font("Doppio One", 19F);
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.IntegralHeight = false;
            this.cbxCategories.Location = new System.Drawing.Point(642, 8);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(465, 39);
            this.cbxCategories.TabIndex = 56;
            this.cbxCategories.Text = "Categories";
            this.cbxCategories.SelectedIndexChanged += new System.EventHandler(this.cbxCategories_SelectedIndexChanged);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Doppio One", 22F);
            this.btnMain.Location = new System.Drawing.Point(1172, 551);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(198, 48);
            this.btnMain.TabIndex = 55;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnCart
            // 
            this.btnCart.Font = new System.Drawing.Font("Doppio One", 22F);
            this.btnCart.Location = new System.Drawing.Point(751, 551);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(116, 48);
            this.btnCart.TabIndex = 54;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Doppio One", 22F);
            this.btnAddToCart.Location = new System.Drawing.Point(513, 551);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(204, 48);
            this.btnAddToCart.TabIndex = 53;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblQuantityAmountLabel
            // 
            this.lblQuantityAmountLabel.AutoSize = true;
            this.lblQuantityAmountLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblQuantityAmountLabel.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblQuantityAmountLabel.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblQuantityAmountLabel.Location = new System.Drawing.Point(0, 556);
            this.lblQuantityAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityAmountLabel.Name = "lblQuantityAmountLabel";
            this.lblQuantityAmountLabel.Size = new System.Drawing.Size(216, 35);
            this.lblQuantityAmountLabel.TabIndex = 52;
            this.lblQuantityAmountLabel.Text = "Order Quantity:";
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.DropDownHeight = 100;
            this.cbxQuantity.Font = new System.Drawing.Font("Doppio One", 19F);
            this.cbxQuantity.FormattingEnabled = true;
            this.cbxQuantity.IntegralHeight = false;
            this.cbxQuantity.Location = new System.Drawing.Point(223, 556);
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(252, 39);
            this.cbxQuantity.TabIndex = 51;
            this.cbxQuantity.Text = "Quantity On Hand";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Doppio One", 19F);
            this.tbxSearch.Location = new System.Drawing.Point(105, 8);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(409, 39);
            this.tbxSearch.TabIndex = 50;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSearch.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblSearch.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblSearch.Location = new System.Drawing.Point(0, 8);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(108, 35);
            this.lblSearch.TabIndex = 49;
            this.lblSearch.Text = "Search:";
            // 
            // hlpShopPOS
            // 
            this.hlpShopPOS.HelpNamespace = "Shop.chm";
            // 
            // pnlCartCount
            // 
            this.pnlCartCount.Controls.Add(this.lblCartCount);
            this.pnlCartCount.Controls.Add(this.pbxCartImage);
            this.pnlCartCount.Location = new System.Drawing.Point(873, 551);
            this.pnlCartCount.Name = "pnlCartCount";
            this.pnlCartCount.Size = new System.Drawing.Size(245, 48);
            this.pnlCartCount.TabIndex = 70;
            // 
            // lblCartCount
            // 
            this.lblCartCount.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::SF_KStilesM2.Properties.Settings.Default, "mainText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCartCount.Font = new System.Drawing.Font("Doppio One", 21F);
            this.lblCartCount.ForeColor = global::SF_KStilesM2.Properties.Settings.Default.mainText;
            this.lblCartCount.Location = new System.Drawing.Point(42, 5);
            this.lblCartCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(199, 39);
            this.lblCartCount.TabIndex = 27;
            this.lblCartCount.Text = "0";
            // 
            // pbxCartImage
            // 
            this.pbxCartImage.Image = global::SF_KStilesM2.Properties.Resources.cartImage;
            this.pbxCartImage.Location = new System.Drawing.Point(0, 0);
            this.pbxCartImage.Name = "pbxCartImage";
            this.pbxCartImage.Size = new System.Drawing.Size(42, 48);
            this.pbxCartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCartImage.TabIndex = 27;
            this.pbxCartImage.TabStop = false;
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.pbxItemImage);
            this.pnlImage.Location = new System.Drawing.Point(1090, 56);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(448, 483);
            this.pnlImage.TabIndex = 30;
            // 
            // pbxItemImage
            // 
            this.pbxItemImage.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.pbxItemImage.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pbxItemImage.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbxItemImage.Location = new System.Drawing.Point(0, 0);
            this.pbxItemImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbxItemImage.Name = "pbxItemImage";
            this.pbxItemImage.Size = new System.Drawing.Size(448, 483);
            this.pbxItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxItemImage.TabIndex = 1;
            this.pbxItemImage.TabStop = false;
            this.pbxItemImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxItemImage_MouseDown);
            this.pbxItemImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxItemImage_MouseMove);
            this.pbxItemImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxItemImage_MouseUp);
            // 
            // frmShopPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::SF_KStilesM2.Properties.Settings.Default.mainBack;
            this.ClientSize = new System.Drawing.Size(1545, 605);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlCartCount);
            this.Controls.Add(this.lblCategoryActual);
            this.Controls.Add(this.lblCategoryLabel);
            this.Controls.Add(this.lblPriceActual);
            this.Controls.Add(this.lblQuantityActual);
            this.Controls.Add(this.tbxDescriptionActual);
            this.Controls.Add(this.lblPriceLabel);
            this.Controls.Add(this.lblQuantityLabel);
            this.Controls.Add(this.lblDescriptionLabel);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.cbxPrice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbxCategories);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblQuantityAmountLabel);
            this.Controls.Add(this.cbxQuantity);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SF_KStilesM2.Properties.Settings.Default, "mainBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShopPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop POS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShopPOS_FormClosing);
            this.Load += new System.EventHandler(this.frmShopPOS_Load);
            this.pnlCartCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCartImage)).EndInit();
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryActual;
        private System.Windows.Forms.Label lblCategoryLabel;
        private System.Windows.Forms.Label lblPriceActual;
        private System.Windows.Forms.Label lblQuantityActual;
        private System.Windows.Forms.TextBox tbxDescriptionActual;
        private System.Windows.Forms.Label lblPriceLabel;
        private System.Windows.Forms.Label lblQuantityLabel;
        private System.Windows.Forms.Label lblDescriptionLabel;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.ComboBox cbxPrice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblQuantityAmountLabel;
        private System.Windows.Forms.ComboBox cbxQuantity;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.HelpProvider hlpShopPOS;
        private System.Windows.Forms.Panel pnlCartCount;
        private System.Windows.Forms.Label lblCartCount;
        private System.Windows.Forms.PictureBox pbxCartImage;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox pbxItemImage;
    }
}
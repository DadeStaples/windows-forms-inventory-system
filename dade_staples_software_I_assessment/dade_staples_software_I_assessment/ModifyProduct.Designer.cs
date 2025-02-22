namespace dade_staples_software_I_assessment
{
    partial class ModifyProduct
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.removePartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.dgvAvailableParts = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.Button();
            this.savePartButton = new System.Windows.Forms.Button();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.partIDLabel = new System.Windows.Forms.Label();
            this.productIDBox = new System.Windows.Forms.TextBox();
            this.availPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availPartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availPartStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availPartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availPartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availManufactureType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocManufactureType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableParts)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(587, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 67;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(668, 20);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 22);
            this.searchBox.TabIndex = 66;
            // 
            // removePartButton
            // 
            this.removePartButton.Location = new System.Drawing.Point(662, 407);
            this.removePartButton.Name = "removePartButton";
            this.removePartButton.Size = new System.Drawing.Size(108, 23);
            this.removePartButton.TabIndex = 65;
            this.removePartButton.Text = "Remove Part";
            this.removePartButton.UseVisualStyleBackColor = true;
            this.removePartButton.Click += new System.EventHandler(this.removePartButton_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(661, 203);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(108, 23);
            this.addPartButton.TabIndex = 64;
            this.addPartButton.Text = "Add Part";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Associated Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Available Parts";
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assocPartID,
            this.assocPartName,
            this.assocPartPrice,
            this.assocPartStock,
            this.assocPartMin,
            this.assocPartMax,
            this.assocManufactureType});
            this.dgvAssociatedParts.Location = new System.Drawing.Point(391, 251);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.RowHeadersWidth = 51;
            this.dgvAssociatedParts.RowTemplate.Height = 24;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(379, 150);
            this.dgvAssociatedParts.TabIndex = 61;
            // 
            // dgvAvailableParts
            // 
            this.dgvAvailableParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.availPartID,
            this.availPartName,
            this.availPartPrice,
            this.availPartStock,
            this.availPartMin,
            this.availPartMax,
            this.availManufactureType});
            this.dgvAvailableParts.Location = new System.Drawing.Point(391, 46);
            this.dgvAvailableParts.Name = "dgvAvailableParts";
            this.dgvAvailableParts.RowHeadersWidth = 51;
            this.dgvAvailableParts.RowTemplate.Height = 24;
            this.dgvAvailableParts.Size = new System.Drawing.Size(379, 150);
            this.dgvAvailableParts.TabIndex = 60;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(190, 354);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 47);
            this.Cancel.TabIndex = 59;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // savePartButton
            // 
            this.savePartButton.Location = new System.Drawing.Point(31, 354);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(109, 47);
            this.savePartButton.TabIndex = 58;
            this.savePartButton.Text = "Save";
            this.savePartButton.UseVisualStyleBackColor = true;
            this.savePartButton.Click += new System.EventHandler(this.savePartButton_Click);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(63, 264);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(32, 16);
            this.maxLabel.TabIndex = 57;
            this.maxLabel.Text = "Max";
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(116, 261);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(100, 22);
            this.maxBox.TabIndex = 56;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(63, 236);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(28, 16);
            this.minLabel.TabIndex = 55;
            this.minLabel.Text = "Min";
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(116, 233);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(100, 22);
            this.minBox.TabIndex = 54;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(63, 208);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(41, 16);
            this.stockLabel.TabIndex = 53;
            this.stockLabel.Text = "Stock";
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(116, 205);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(100, 22);
            this.stockBox.TabIndex = 52;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(63, 180);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(38, 16);
            this.priceLabel.TabIndex = 51;
            this.priceLabel.Text = "Price";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(116, 177);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 22);
            this.priceBox.TabIndex = 50;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(63, 152);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 49;
            this.nameLabel.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(116, 149);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 48;
            // 
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.Location = new System.Drawing.Point(41, 124);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(69, 16);
            this.partIDLabel.TabIndex = 47;
            this.partIDLabel.Text = "Product ID";
            // 
            // productIDBox
            // 
            this.productIDBox.Location = new System.Drawing.Point(116, 121);
            this.productIDBox.Name = "productIDBox";
            this.productIDBox.Size = new System.Drawing.Size(100, 22);
            this.productIDBox.TabIndex = 46;
            // 
            // availPartID
            // 
            this.availPartID.DataPropertyName = "partID";
            this.availPartID.HeaderText = "Part ID";
            this.availPartID.MinimumWidth = 6;
            this.availPartID.Name = "availPartID";
            this.availPartID.Width = 125;
            // 
            // availPartName
            // 
            this.availPartName.DataPropertyName = "name";
            this.availPartName.HeaderText = "Name";
            this.availPartName.MinimumWidth = 6;
            this.availPartName.Name = "availPartName";
            this.availPartName.Width = 125;
            // 
            // availPartPrice
            // 
            this.availPartPrice.DataPropertyName = "price";
            this.availPartPrice.HeaderText = "Price";
            this.availPartPrice.MinimumWidth = 6;
            this.availPartPrice.Name = "availPartPrice";
            this.availPartPrice.Width = 125;
            // 
            // availPartStock
            // 
            this.availPartStock.DataPropertyName = "inStock";
            this.availPartStock.HeaderText = "In Stock";
            this.availPartStock.MinimumWidth = 6;
            this.availPartStock.Name = "availPartStock";
            this.availPartStock.Width = 125;
            // 
            // availPartMin
            // 
            this.availPartMin.DataPropertyName = "min";
            this.availPartMin.HeaderText = "Min";
            this.availPartMin.MinimumWidth = 6;
            this.availPartMin.Name = "availPartMin";
            this.availPartMin.Visible = false;
            this.availPartMin.Width = 125;
            // 
            // availPartMax
            // 
            this.availPartMax.DataPropertyName = "max";
            this.availPartMax.HeaderText = "Max";
            this.availPartMax.MinimumWidth = 6;
            this.availPartMax.Name = "availPartMax";
            this.availPartMax.Visible = false;
            this.availPartMax.Width = 125;
            // 
            // availManufactureType
            // 
            this.availManufactureType.DataPropertyName = "manufactureType";
            this.availManufactureType.HeaderText = "Manufacturer";
            this.availManufactureType.MinimumWidth = 6;
            this.availManufactureType.Name = "availManufactureType";
            this.availManufactureType.Visible = false;
            this.availManufactureType.Width = 125;
            // 
            // assocPartID
            // 
            this.assocPartID.DataPropertyName = "partID";
            this.assocPartID.HeaderText = "Part ID";
            this.assocPartID.MinimumWidth = 6;
            this.assocPartID.Name = "assocPartID";
            this.assocPartID.Width = 125;
            // 
            // assocPartName
            // 
            this.assocPartName.DataPropertyName = "name";
            this.assocPartName.HeaderText = "Name";
            this.assocPartName.MinimumWidth = 6;
            this.assocPartName.Name = "assocPartName";
            this.assocPartName.Width = 125;
            // 
            // assocPartPrice
            // 
            this.assocPartPrice.DataPropertyName = "price";
            this.assocPartPrice.HeaderText = "Price";
            this.assocPartPrice.MinimumWidth = 6;
            this.assocPartPrice.Name = "assocPartPrice";
            this.assocPartPrice.Width = 125;
            // 
            // assocPartStock
            // 
            this.assocPartStock.DataPropertyName = "inStock";
            this.assocPartStock.HeaderText = "In Stock";
            this.assocPartStock.MinimumWidth = 6;
            this.assocPartStock.Name = "assocPartStock";
            this.assocPartStock.Width = 125;
            // 
            // assocPartMin
            // 
            this.assocPartMin.DataPropertyName = "min";
            this.assocPartMin.HeaderText = "Min";
            this.assocPartMin.MinimumWidth = 6;
            this.assocPartMin.Name = "assocPartMin";
            this.assocPartMin.Visible = false;
            this.assocPartMin.Width = 125;
            // 
            // assocPartMax
            // 
            this.assocPartMax.DataPropertyName = "max";
            this.assocPartMax.HeaderText = "Max";
            this.assocPartMax.MinimumWidth = 6;
            this.assocPartMax.Name = "assocPartMax";
            this.assocPartMax.Visible = false;
            this.assocPartMax.Width = 125;
            // 
            // assocManufactureType
            // 
            this.assocManufactureType.DataPropertyName = "manufactureType";
            this.assocManufactureType.HeaderText = "Manufacturer";
            this.assocManufactureType.MinimumWidth = 6;
            this.assocManufactureType.Name = "assocManufactureType";
            this.assocManufactureType.Visible = false;
            this.assocManufactureType.Width = 125;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.removePartButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvAvailableParts);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.savePartButton);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.stockBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.partIDLabel);
            this.Controls.Add(this.productIDBox);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button removePartButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.DataGridView dgvAvailableParts;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label partIDLabel;
        private System.Windows.Forms.TextBox productIDBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn availPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn availPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn availPartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn availPartStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn availPartMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn availPartMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn availManufactureType;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocManufactureType;
    }
}
namespace dade_staples_software_I_assessment
{
    partial class Form1
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
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.partsSearchBox = new System.Windows.Forms.TextBox();
            this.partSearchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.productsSearchBox = new System.Windows.Forms.TextBox();
            this.addPartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.partName,
            this.Price,
            this.Instock,
            this.Min,
            this.Max,
            this.Manufacturer});
            this.dgvParts.Location = new System.Drawing.Point(41, 52);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersWidth = 51;
            this.dgvParts.RowTemplate.Height = 24;
            this.dgvParts.Size = new System.Drawing.Size(505, 312);
            this.dgvParts.TabIndex = 0;
            this.dgvParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.BindingComplete);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productPrice,
            this.productStock,
            this.productMin,
            this.productMax});
            this.dgvProducts.Location = new System.Drawing.Point(612, 52);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(500, 312);
            this.dgvProducts.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(381, 387);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(165, 51);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete Part";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(972, 387);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(140, 51);
            this.deleteProduct.TabIndex = 4;
            this.deleteProduct.Text = "Delete Product";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // partsSearchBox
            // 
            this.partsSearchBox.Location = new System.Drawing.Point(445, 24);
            this.partsSearchBox.Name = "partsSearchBox";
            this.partsSearchBox.Size = new System.Drawing.Size(100, 22);
            this.partsSearchBox.TabIndex = 5;
            // 
            // partSearchButton
            // 
            this.partSearchButton.Location = new System.Drawing.Point(364, 23);
            this.partSearchButton.Name = "partSearchButton";
            this.partSearchButton.Size = new System.Drawing.Size(75, 23);
            this.partSearchButton.TabIndex = 6;
            this.partSearchButton.Text = "Search";
            this.partSearchButton.UseVisualStyleBackColor = true;
            this.partSearchButton.Click += new System.EventHandler(this.partSearchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(972, 444);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 51);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // productSearchButton
            // 
            this.productSearchButton.Location = new System.Drawing.Point(931, 23);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(75, 23);
            this.productSearchButton.TabIndex = 9;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = true;
            this.productSearchButton.Click += new System.EventHandler(this.productSearchButton_Click);
            // 
            // productsSearchBox
            // 
            this.productsSearchBox.Location = new System.Drawing.Point(1012, 24);
            this.productsSearchBox.Name = "productsSearchBox";
            this.productsSearchBox.Size = new System.Drawing.Size(100, 22);
            this.productsSearchBox.TabIndex = 8;
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(41, 387);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(165, 51);
            this.addPartButton.TabIndex = 10;
            this.addPartButton.Text = "Add Part";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.Location = new System.Drawing.Point(41, 444);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(165, 51);
            this.modifyPartButton.TabIndex = 11;
            this.modifyPartButton.Text = "Modify Part";
            this.modifyPartButton.UseVisualStyleBackColor = true;
            this.modifyPartButton.Click += new System.EventHandler(this.modifyPartButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(612, 387);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(165, 51);
            this.addProductButton.TabIndex = 12;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.Location = new System.Drawing.Point(612, 453);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(165, 51);
            this.modifyProductButton.TabIndex = 13;
            this.modifyProductButton.Text = "Modify Product";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.modifyProductButton_Click);
            // 
            // productID
            // 
            this.productID.DataPropertyName = "productID";
            this.productID.HeaderText = "Product ID";
            this.productID.MinimumWidth = 6;
            this.productID.Name = "productID";
            this.productID.Width = 125;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "name";
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.Width = 125;
            // 
            // productPrice
            // 
            this.productPrice.DataPropertyName = "price";
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 6;
            this.productPrice.Name = "productPrice";
            this.productPrice.Width = 125;
            // 
            // productStock
            // 
            this.productStock.DataPropertyName = "inStock";
            this.productStock.HeaderText = "In Stock";
            this.productStock.MinimumWidth = 6;
            this.productStock.Name = "productStock";
            this.productStock.Width = 125;
            // 
            // productMin
            // 
            this.productMin.DataPropertyName = "min";
            this.productMin.HeaderText = "Min";
            this.productMin.MinimumWidth = 6;
            this.productMin.Name = "productMin";
            this.productMin.Visible = false;
            this.productMin.Width = 110;
            // 
            // productMax
            // 
            this.productMax.DataPropertyName = "max";
            this.productMax.HeaderText = "Max";
            this.productMax.MinimumWidth = 6;
            this.productMax.Name = "productMax";
            this.productMax.Visible = false;
            this.productMax.Width = 110;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "partID";
            this.ID.HeaderText = "Part ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // partName
            // 
            this.partName.DataPropertyName = "name";
            this.partName.HeaderText = "Name";
            this.partName.MinimumWidth = 6;
            this.partName.Name = "partName";
            this.partName.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Instock
            // 
            this.Instock.DataPropertyName = "inStock";
            this.Instock.HeaderText = "In Stock";
            this.Instock.MinimumWidth = 6;
            this.Instock.Name = "Instock";
            this.Instock.Width = 125;
            // 
            // Min
            // 
            this.Min.DataPropertyName = "min";
            this.Min.HeaderText = "Min";
            this.Min.MinimumWidth = 6;
            this.Min.Name = "Min";
            this.Min.Visible = false;
            this.Min.Width = 125;
            // 
            // Max
            // 
            this.Max.DataPropertyName = "max";
            this.Max.HeaderText = "Max";
            this.Max.MinimumWidth = 6;
            this.Max.Name = "Max";
            this.Max.Visible = false;
            this.Max.Width = 125;
            // 
            // Manufacturer
            // 
            this.Manufacturer.DataPropertyName = "manufactureType";
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.MinimumWidth = 6;
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Visible = false;
            this.Manufacturer.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 516);
            this.Controls.Add(this.modifyProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.modifyPartButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.productSearchButton);
            this.Controls.Add(this.productsSearchBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.partSearchButton);
            this.Controls.Add(this.partsSearchBox);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.TextBox partsSearchBox;
        private System.Windows.Forms.Button partSearchButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.TextBox productsSearchBox;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
    }
}


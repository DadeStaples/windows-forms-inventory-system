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
            this.showButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dgvProducts.Location = new System.Drawing.Point(612, 52);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(500, 312);
            this.dgvProducts.TabIndex = 1;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(41, 387);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(157, 51);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show Item";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 516);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button deleteProduct;
    }
}


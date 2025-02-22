namespace dade_staples_software_I_assessment
{
    partial class ModifyPart
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
            this.Cancel = new System.Windows.Forms.Button();
            this.savePartButton = new System.Windows.Forms.Button();
            this.manufactureLabel = new System.Windows.Forms.Label();
            this.manufactureBox = new System.Windows.Forms.TextBox();
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
            this.partIDBox = new System.Windows.Forms.TextBox();
            this.outsourcedButton = new System.Windows.Forms.RadioButton();
            this.inHouseButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(190, 359);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 47);
            this.Cancel.TabIndex = 37;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // savePartButton
            // 
            this.savePartButton.Location = new System.Drawing.Point(31, 359);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(109, 47);
            this.savePartButton.TabIndex = 36;
            this.savePartButton.Text = "Save";
            this.savePartButton.UseVisualStyleBackColor = true;
            this.savePartButton.Click += new System.EventHandler(this.savePartButton_Click);
            // 
            // manufactureLabel
            // 
            this.manufactureLabel.AutoSize = true;
            this.manufactureLabel.Location = new System.Drawing.Point(44, 256);
            this.manufactureLabel.Name = "manufactureLabel";
            this.manufactureLabel.Size = new System.Drawing.Size(74, 16);
            this.manufactureLabel.TabIndex = 35;
            this.manufactureLabel.Text = "Machine ID";
            // 
            // manufactureBox
            // 
            this.manufactureBox.Location = new System.Drawing.Point(152, 253);
            this.manufactureBox.Name = "manufactureBox";
            this.manufactureBox.Size = new System.Drawing.Size(100, 22);
            this.manufactureBox.TabIndex = 34;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(99, 228);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(32, 16);
            this.maxLabel.TabIndex = 33;
            this.maxLabel.Text = "Max";
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(152, 225);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(100, 22);
            this.maxBox.TabIndex = 32;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(99, 200);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(28, 16);
            this.minLabel.TabIndex = 31;
            this.minLabel.Text = "Min";
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(152, 197);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(100, 22);
            this.minBox.TabIndex = 30;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(99, 172);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(41, 16);
            this.stockLabel.TabIndex = 29;
            this.stockLabel.Text = "Stock";
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(152, 169);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(100, 22);
            this.stockBox.TabIndex = 28;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(99, 144);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(38, 16);
            this.priceLabel.TabIndex = 27;
            this.priceLabel.Text = "Price";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(152, 141);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 22);
            this.priceBox.TabIndex = 26;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(99, 116);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(152, 113);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 24;
            // 
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.Location = new System.Drawing.Point(99, 88);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(47, 16);
            this.partIDLabel.TabIndex = 23;
            this.partIDLabel.Text = "Part ID";
            // 
            // partIDBox
            // 
            this.partIDBox.Location = new System.Drawing.Point(152, 85);
            this.partIDBox.Name = "partIDBox";
            this.partIDBox.Size = new System.Drawing.Size(100, 22);
            this.partIDBox.TabIndex = 22;
            // 
            // outsourcedButton
            // 
            this.outsourcedButton.AutoSize = true;
            this.outsourcedButton.Location = new System.Drawing.Point(190, 50);
            this.outsourcedButton.Name = "outsourcedButton";
            this.outsourcedButton.Size = new System.Drawing.Size(97, 20);
            this.outsourcedButton.TabIndex = 21;
            this.outsourcedButton.TabStop = true;
            this.outsourcedButton.Text = "Outsourced";
            this.outsourcedButton.UseVisualStyleBackColor = true;
            // 
            // inHouseButton
            // 
            this.inHouseButton.AutoSize = true;
            this.inHouseButton.Location = new System.Drawing.Point(102, 50);
            this.inHouseButton.Name = "inHouseButton";
            this.inHouseButton.Size = new System.Drawing.Size(82, 20);
            this.inHouseButton.TabIndex = 20;
            this.inHouseButton.TabStop = true;
            this.inHouseButton.Text = "In-House";
            this.inHouseButton.UseVisualStyleBackColor = true;
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.savePartButton);
            this.Controls.Add(this.manufactureLabel);
            this.Controls.Add(this.manufactureBox);
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
            this.Controls.Add(this.partIDBox);
            this.Controls.Add(this.outsourcedButton);
            this.Controls.Add(this.inHouseButton);
            this.Name = "ModifyPart";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.Label manufactureLabel;
        private System.Windows.Forms.TextBox manufactureBox;
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
        private System.Windows.Forms.TextBox partIDBox;
        private System.Windows.Forms.RadioButton outsourcedButton;
        private System.Windows.Forms.RadioButton inHouseButton;
    }
}
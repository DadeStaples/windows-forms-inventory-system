namespace dade_staples_software_I_assessment
{
    partial class AddPart
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
            this.inHouseButton = new System.Windows.Forms.RadioButton();
            this.outsourcedButton = new System.Windows.Forms.RadioButton();
            this.partIDBox = new System.Windows.Forms.TextBox();
            this.partIDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.manufactureLabel = new System.Windows.Forms.Label();
            this.manufactureBox = new System.Windows.Forms.TextBox();
            this.savePartButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inHouseButton
            // 
            this.inHouseButton.AutoSize = true;
            this.inHouseButton.Location = new System.Drawing.Point(111, 25);
            this.inHouseButton.Name = "inHouseButton";
            this.inHouseButton.Size = new System.Drawing.Size(82, 20);
            this.inHouseButton.TabIndex = 0;
            this.inHouseButton.TabStop = true;
            this.inHouseButton.Text = "In-House";
            this.inHouseButton.UseVisualStyleBackColor = true;
            this.inHouseButton.CheckedChanged += new System.EventHandler(this.inHouseButton_CheckedChanged);
            // 
            // outsourcedButton
            // 
            this.outsourcedButton.AutoSize = true;
            this.outsourcedButton.Location = new System.Drawing.Point(199, 25);
            this.outsourcedButton.Name = "outsourcedButton";
            this.outsourcedButton.Size = new System.Drawing.Size(97, 20);
            this.outsourcedButton.TabIndex = 1;
            this.outsourcedButton.TabStop = true;
            this.outsourcedButton.Text = "Outsourced";
            this.outsourcedButton.UseVisualStyleBackColor = true;
            this.outsourcedButton.CheckedChanged += new System.EventHandler(this.outsourcedButton_CheckedChanged);
            // 
            // partIDBox
            // 
            this.partIDBox.Location = new System.Drawing.Point(161, 60);
            this.partIDBox.Name = "partIDBox";
            this.partIDBox.Size = new System.Drawing.Size(100, 22);
            this.partIDBox.TabIndex = 2;
            // 
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.Location = new System.Drawing.Point(108, 63);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(47, 16);
            this.partIDLabel.TabIndex = 3;
            this.partIDLabel.Text = "Part ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(108, 91);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(161, 88);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 4;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(108, 119);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(38, 16);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Price";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(161, 116);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 22);
            this.priceBox.TabIndex = 6;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(108, 147);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(41, 16);
            this.stockLabel.TabIndex = 9;
            this.stockLabel.Text = "Stock";
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(161, 144);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(100, 22);
            this.stockBox.TabIndex = 8;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(108, 175);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(28, 16);
            this.minLabel.TabIndex = 11;
            this.minLabel.Text = "Min";
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(161, 172);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(100, 22);
            this.minBox.TabIndex = 10;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(108, 203);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(32, 16);
            this.maxLabel.TabIndex = 13;
            this.maxLabel.Text = "Max";
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(161, 200);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(100, 22);
            this.maxBox.TabIndex = 12;
            // 
            // manufactureLabel
            // 
            this.manufactureLabel.AutoSize = true;
            this.manufactureLabel.Location = new System.Drawing.Point(53, 231);
            this.manufactureLabel.Name = "manufactureLabel";
            this.manufactureLabel.Size = new System.Drawing.Size(74, 16);
            this.manufactureLabel.TabIndex = 15;
            this.manufactureLabel.Text = "Machine ID";
            // 
            // manufactureBox
            // 
            this.manufactureBox.Location = new System.Drawing.Point(161, 228);
            this.manufactureBox.Name = "manufactureBox";
            this.manufactureBox.Size = new System.Drawing.Size(100, 22);
            this.manufactureBox.TabIndex = 14;
            // 
            // savePartButton
            // 
            this.savePartButton.Location = new System.Drawing.Point(40, 334);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(109, 47);
            this.savePartButton.TabIndex = 18;
            this.savePartButton.Text = "Save";
            this.savePartButton.UseVisualStyleBackColor = true;
            this.savePartButton.Click += new System.EventHandler(this.savePartButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(199, 334);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 47);
            this.Cancel.TabIndex = 19;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
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
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inHouseButton;
        private System.Windows.Forms.RadioButton outsourcedButton;
        private System.Windows.Forms.TextBox partIDBox;
        private System.Windows.Forms.Label partIDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.Label manufactureLabel;
        private System.Windows.Forms.TextBox manufactureBox;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.Button Cancel;
    }
}
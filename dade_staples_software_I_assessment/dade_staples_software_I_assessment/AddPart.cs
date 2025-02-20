using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace dade_staples_software_I_assessment
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();

            partIDBox.ReadOnly = true;

            inHouseButton.Checked = true;

            partIDBox.Text = Inventory.newPartId().ToString();



        }


        //need to check which radio button is clicked and update the form accordingly

        //private void inHouseCheck(object sender, EventArgs e)
        //{
        //    machineIDBox.Enabled = true;
        //    machineIDLabel.Enabled = true;
        //    companyBox.Enabled = false;
        //    companyLabel.Enabled = false;
        //    companyBox.Clear();
        //}

        //private void outsourceCheck(object sender, EventArgs e)
        //{
        //    machineIDBox.Enabled = false;
        //    machineIDBox.Clear();
        //    companyBox.Enabled = true;
        //    companyLabel.Enabled = true;
        //}

        private void savePartButton_Click(object sender, EventArgs e)
        {
            try
            {
                int partID = int.Parse(partIDBox.Text);
                string name = nameBox.Text;
                decimal price = decimal.Parse(priceBox.Text);
                int inStock = int.Parse(stockBox.Text);
                int min = int.Parse(minBox.Text);
                int max = int.Parse(maxBox.Text);

                if (min > max)
                {
                    MessageBox.Show("Min cannot be greater than Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Part incomingPart;
                if (inHouseButton.Checked)
                {
                    int machineID = int.Parse(manufactureBox.Text);
                    incomingPart = new InHouse(partID, name, price, inStock, min, max, machineID);
                }
                else
                {
                    string companyName = manufactureBox.Text;
                    incomingPart = new Outsourced(partID, name, price, inStock, min, max, companyName);
                }

                // Add the new part to inventory
                Inventory.AllParts.Add(incomingPart);

                // Close the form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please check all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inHouseButton_CheckedChanged(object sender, EventArgs e)
        {
            if (inHouseButton.Checked)
            {
                manufactureLabel.Text = "Machine ID";
            }
            else
            {
                manufactureLabel.Text = "Company Name";
            }
        }

        private void outsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (inHouseButton.Checked)
            {
                manufactureLabel.Text = "Machine ID";
            }
            else
            {
                manufactureLabel.Text = "Company Name";
            }
        }
    }
}

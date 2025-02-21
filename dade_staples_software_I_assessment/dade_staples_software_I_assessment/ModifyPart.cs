using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dade_staples_software_I_assessment
{
    public partial class ModifyPart : Form
    {

        private Part selectedPart;
        public ModifyPart(Part selectedPart)
        {
            InitializeComponent();
            this.selectedPart = selectedPart;

            partIDBox.ReadOnly = true;


            if (selectedPart is InHouse inHousePart)
            {
                inHouseButton.Checked = true;
                manufactureLabel.Text = "Machine ID:";
                manufactureBox.Text = inHousePart.MachineID.ToString();
            }
            else if (selectedPart is Outsourced outsourcedPart)
            {
                outsourcedButton.Checked = true;
                manufactureLabel.Text = "Company Name:";
                manufactureBox.Text = outsourcedPart.CompanyName;
            }

            partIDBox.Text = selectedPart.partID.ToString();
            nameBox.Text = selectedPart.name;
            priceBox.Text = selectedPart.price.ToString();
            stockBox.Text = selectedPart.inStock.ToString();
            minBox.Text = selectedPart.min.ToString();
            maxBox.Text = selectedPart.max.ToString();
            

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savePartButton_Click(object sender, EventArgs e)
        {
            if(inHouseButton.Checked)
            {
                InHouse modifiedPart = new InHouse(int.Parse(partIDBox.Text), nameBox.Text, decimal.Parse(priceBox.Text), int.Parse(stockBox.Text), int.Parse(minBox.Text), int.Parse(maxBox.Text), int.Parse(manufactureBox.Text));
                Inventory.updatePart(selectedPart.partID, modifiedPart);
            }
            else
            {
                Outsourced modifiedPart = new Outsourced(int.Parse(partIDBox.Text), nameBox.Text, decimal.Parse(priceBox.Text), int.Parse(stockBox.Text), int.Parse(minBox.Text), int.Parse(maxBox.Text), manufactureBox.Text);
                Inventory.updatePart(selectedPart.partID, modifiedPart);
            }
            this.Close();
            
        }
    }
}

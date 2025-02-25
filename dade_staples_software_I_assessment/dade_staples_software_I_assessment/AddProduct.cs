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
    
    public partial class AddProduct : Form
    {
        BindingList<Part> tempPartsList = new BindingList<Part>();
        

        public AddProduct()
        {
            InitializeComponent();
            dgvAvailableParts.DataSource = Inventory.AllParts;
            dgvAssociatedParts.DataSource = tempPartsList;

            dgvAvailableParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableParts.ReadOnly = true;
            dgvAvailableParts.MultiSelect = false;
            dgvAvailableParts.AllowUserToAddRows = false;

            dgvAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssociatedParts.ReadOnly = true;
            dgvAssociatedParts.MultiSelect = false;
            dgvAssociatedParts.AllowUserToAddRows = false;

            productIDBox.ReadOnly = true;
            productIDBox.Text = Inventory.newProductId().ToString();
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Product currentProduct = new Product(new BindingList<Part>(), 0, "", 0, 0, 0, 0);

        private void addPartButton_Click(object sender, EventArgs e)
        {
            Part selectedPart = dgvAvailableParts.CurrentRow.DataBoundItem as Part;

            if (selectedPart != null)
            {
                currentProduct.addAssociatedPart(selectedPart);
                dgvAssociatedParts.DataSource = currentProduct.associatedParts;
            }
        }


        private void removePartButton_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow != null)
            {
                Part selectedPart = dgvAssociatedParts.CurrentRow.DataBoundItem as Part;

                if (selectedPart != null)
                {
                    currentProduct.removeAssociatedPart(selectedPart.partID);
                }
            }
            else
            {
                MessageBox.Show("Please select a part to remove.",
                                "Invalid Selection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void savePartButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = int.Parse(productIDBox.Text);
                string name = nameBox.Text;
                decimal price = decimal.Parse(priceBox.Text);
                int inStock = int.Parse(stockBox.Text);
                int min = int.Parse(minBox.Text);
                int max = int.Parse(maxBox.Text);

                if (min > max)
                {
                    MessageBox.Show("Min cannot be greater than Max.", 
                                    "Input Error", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Warning);
                    return;
                }

                if (inStock > max || inStock < min)
                {
                     MessageBox.Show("Stock value must be within the min and max values.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }

                Product productToAdd = new Product(currentProduct.associatedParts, productID, name, price, inStock, min, max);
                Inventory.addProduct(productToAdd);
                this.Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Invalid input. Please check all fields.", 
                                "Error",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var userInput = searchBox.Text;


            if (int.TryParse(userInput, out int number) && number > Inventory.AllParts.Count - 1)
            {
                MessageBox.Show("Number entered is outside of index range.",
                "Invalid Search Query",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
    );
            }
            else if (int.TryParse(userInput, out int IDNumber))
            {
                var partFound = Inventory.lookupPart(IDNumber);
                BindingList<Part> filteredParts = new BindingList<Part>(
                Inventory.AllParts.Where(p => p.partID == (partFound.partID)).ToList()
                );

                dgvAvailableParts.DataSource = filteredParts;
                dgvAvailableParts.Refresh();

            }
            else if (userInput == "")
            {
                dgvAvailableParts.DataSource = Inventory.AllParts;
                dgvAvailableParts.Refresh();
            }
            else
            {
                MessageBox.Show("Please enter a part ID number to search.",
                    "Invalid Search Query",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }
    }
}

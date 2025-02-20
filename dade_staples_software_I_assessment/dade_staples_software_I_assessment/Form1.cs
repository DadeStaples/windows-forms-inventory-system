using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dade_staples_software_I_assessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // data source for parts
            dgvParts.DataSource = Inventory.AllParts;

            // property modifiers for parts data grid
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParts.ReadOnly = true;
            dgvParts.MultiSelect = false;
            dgvParts.AllowUserToAddRows = false;
            //Will probably need to change so only ID, name, inventory, and price are show in dgv

            // data source for products
            dgvProducts.DataSource = Inventory.Products;

            // property modifiers for products data grid
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.ReadOnly = true;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;
            //Will probably need to change so only ID, name, inventory, and price are show in dgv


        }

        private void BindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvParts.ClearSelection();
            dgvProducts.ClearSelection();
        }


        //this part will need to be edited for modify button, takes the info from thisPart and replaces item at that index
        
        private void showButton_Click(object sender, EventArgs e)
        {
            if (!dgvParts.CurrentRow.Selected) // setting condition as '!= true' causes issues with MessageBoxIcon, reason unknown
            {
                MessageBox.Show("No item has been selected.",
                                "Invalid Selection", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                return;
            }
            Part thisPart = dgvParts.CurrentRow.DataBoundItem as Part;
            int Index = dgvParts.CurrentCell.RowIndex;

            MessageBox.Show(thisPart.name + " has been selected. Its Index in the dgv is " + Index,
                            "Show Selection",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow.Selected != false)
            {
                Part selectedPart = dgvParts.CurrentRow.DataBoundItem as Part;

                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{selectedPart.name}'?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int partID = selectedPart.partID;
                    Inventory.removePart(partID);
                    dgvParts.Refresh();

                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.", 
                                "No Selection", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
            }
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow.Selected != false)
            {
                Product selectedProduct = dgvProducts.CurrentRow.DataBoundItem as Product;

                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{selectedProduct.name}'?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int productID = selectedProduct.productID;
                    Inventory.removeProduct(productID);
                    dgvParts.Refresh();

                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.",
                                "No Selection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void partSearchButton_Click(object sender, EventArgs e)
        {
            var userInput = partsSearchBox.Text;


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

                dgvParts.DataSource = filteredParts;
                dgvParts.Refresh();

            }
            else if(userInput == "")
                {
                dgvParts.DataSource = Inventory.AllParts;
                dgvParts.Refresh();
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

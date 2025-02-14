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

            // data source for products
            dgvProducts.DataSource = Inventory.Products;

            // property modifiers for products data grid
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.ReadOnly = true;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;

        }

        private void BindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvParts.ClearSelection();
            dgvProducts.ClearSelection();
        }

        //private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    MessageBox.Show(dgvParts.CurrentRow.Cells["name"].Value + " was clicked.");
        //}

        private void showButton_Click(object sender, EventArgs e)
        {
            if (!dgvParts.CurrentRow.Selected)
            {
                MessageBox.Show("No items have been selected");
                return;
            }
            MessageBox.Show(dgvParts.CurrentRow.Cells["name"].Value + " is selected.");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Inventory.removePart(Convert.ToInt32(dgvParts.CurrentRow.Cells["partID"].Value));
            dgvParts.Refresh();
        }
    }
}

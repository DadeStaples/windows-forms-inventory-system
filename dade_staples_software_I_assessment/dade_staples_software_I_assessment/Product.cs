using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace dade_staples_software_I_assessment
{
    public class Product
    {
        public BindingList<Part> associatedParts { get; set; } = new BindingList<Part>();
        public int productID { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int inStock { get; set; }
        public int min { get; set; }
        public int max { get; set; }

        public BindingList<Part> tempPartsList = new BindingList<Part>();

        public Product(BindingList<Part> AssociatedParts, int productID, string name, decimal price, int inStock, int min, int max)
        {
            this.associatedParts = AssociatedParts ?? new BindingList<Part>();
            this.productID = productID;
            this.name = name;
            this.price = price;
            this.inStock = inStock;
            this.min = min;
            this.max = max;
        }

        // addAssociatedPart(Part) : void

        public void addAssociatedPart(Part part)
        {
            var partAdded = false;

            foreach (var associatedPart in associatedParts)
            {
                if (part.partID == associatedPart.partID)
                {
                    partAdded = true;
                }

            }

            if (!partAdded)
            {
                associatedParts.Add(part);
            }
            else
            {
                MessageBox.Show("Part has already been added. Please select another part",
                                "Invalid Selection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        // removeAssociatedPart(int) : Bool

        public bool removeAssociatedPart(int idToDelete)
        {
            foreach (Part part in associatedParts)
            {
                if (part.partID == idToDelete)
                {
                    associatedParts.Remove(part);
                    return true;
                }

            }
                return false;
        }

        // lookupAssociatedPart(int) : Part

        public static Product lookupAssociatedPart(int getId)
        {

            // lookup code goes here
            return null;

        }

    }
}

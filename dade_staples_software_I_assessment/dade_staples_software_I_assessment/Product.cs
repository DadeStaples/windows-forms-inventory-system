using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

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

        // **TODO implement addAssociated part,recieves Part arguement, return is void **

        // **TODO implement lookupAssociatedPart, recieves int arguement,  returns part **

        public static Product lookupAssociatedPart(int getId)
        {

            // lookup code goes here
            return null;

        }

    }
}

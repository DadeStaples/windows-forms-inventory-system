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

        //List<Product> products = new List<Product>();

        //sets list of default products to be displayed, may need to change to BindingList
        //this will probably also need to be moved to the inventory class
        public static List<Product> DefaultProducts { get; } = new List<Product>
    {
        new Product(
            new BindingList<Part>
            {
                new Part { partID = 0, name = "Tire", price = 49.99m,  inStock = 12, min = 4, max = 20 }
            },
            0, "Wheel", 149.99m, 12, 20, 4),
        new Product(new BindingList<Part>
                        {
                new Part { partID = 0, name = "Spoke", price = 49.99m,  inStock = 12, min = 4, max = 20 }
            },
            1, "Hubcap", 249.99m, 16, 4 , 20),
        new Product(new BindingList<Part>
                        {
                new Part { partID = 0, name = "Bracket", price = 49.99m,  inStock = 12, min = 4, max = 20 }
            },
            3, "Lug Nuts", 19.99m, 40, 20, 60)
    };


        // **TODO need to change this to return bool value **
        // **TODO this will be moved to inventory class
        public static void removeProduct(int idToDelete)
        {
            bool removed = false;


            foreach (Product p in DefaultProducts)
            {
                if (p.productID == idToDelete)
                {
                    removed = true;
                }
            }
            DefaultProducts.RemoveAll(p => p.productID == idToDelete);

            //this check is likely not needed for assessment 

            if (removed == true)
                Console.WriteLine($"Item with ID #{idToDelete} has been deleted.");
            else
                Console.WriteLine($"No item found with ID #{idToDelete}.");
        }


        //likely not needed for assessment product
        public static void GetAll()
        {
            foreach (Product product in Product.DefaultProducts)
            {
                Console.WriteLine($" Associated Parts: TBD ID: {product.productID} Name: {product.name} Price: ${product.price:F2}, In stock: {product.inStock}, Minimum: {product.min}, Maximum: {product.max}");
            }
        }

        //Move to Inventory Class

        //public static void AddItem(List<Part> associatedParts, int id, string name, decimal price, int inStock, int min, int max)
        //{
        //    DefaultProducts.Add(new Product(new List<Part>(), id, name, price, inStock, min, max));
        //}

        // **TODO implement addAssociated part,recieves Part arguement, return is void **

        // **TODO implement lookupAssociatedPart, recieves int arguement,  returns part **

    }
}

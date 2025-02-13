using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using static dade_staples_software_I_assessment.Part;

namespace dade_staples_software_I_assessment
{
    public partial class Inventory
    {

        //get all Parts and Products and populate default inventory

        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Product> Products = new BindingList<Product>();

        static Inventory()
        {
            AllParts.Add(new Part { partID = 0, name = "Tire", price = 49.99m, inStock = 12, min = 4, max = 20 });
            AllParts.Add(new Part { partID = 1, name = "Screw", price = 1.99m, inStock = 100, min = 10, max = 500 });
            AllParts.Add(new Part { partID = 2, name = "Bolt", price = 5.99m, inStock = 50, min = 10, max = 100 });

            Products.Add(
            new Product(
            new BindingList<Part>
            {
                new Part { partID = 0, name = "Tire", price = 49.99m,  inStock = 12, min = 4, max = 20 },
                new Part { partID = 2, name = "Bolt", price = 5.99m, inStock = 50, min = 10, max = 100 }
            },
            0, "Wheel", 149.99m, 12, 20, 4)
            );
            Products.Add(new Product(
            new BindingList<Part>
            {
                new Part { partID = 1, name = "Screw", price = 1.99m, inStock = 100, min = 10, max = 500 },
                new Part { partID = 2, name = "Bolt", price = 5.99m, inStock = 50, min = 10, max = 100 }
            },
            1, "Lug Nut", 5.99m, 100, 20, 500));
        }


        // addProduct(Product) : void **TODO

        // removeProduct(int) : bool **TODO
        public static bool removeProduct(int idToDelete)
        {
            bool removed = false;


            for (int i = Products.Count - 1; i >= 0; i--)
            {
                if (Products[i].productID == idToDelete)
                {
                    Products.RemoveAt(i);
                    removed = true;
                }
            }

            return removed;
        }

        //lookupProduct(int) : Product **TODO

        //updateProduct(int, Product) : void **TODO

        //addPart(Part) : void **TODO

        //deletePart(Part) : bool **TODO

        //lookupPart(int) : Part **TODO

        //updatePart(int, Part) : void **TODO




    }
}

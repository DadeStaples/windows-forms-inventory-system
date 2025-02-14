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
            AllParts.Add(new Part(0, "Tire", 49.99m, 12, 4, 20));
            AllParts.Add(new Part(1, "Screw", 1.99m, 100, 10, 500));
            AllParts.Add(new Part(2, "Bolt", 5.99m, 50, 10, 100));

            Products.Add(
            new Product(
            new BindingList<Part>
            {
                new Part (0, "Tire", 49.99m, 12, 4, 20),
                new Part (2, "Bolt", 5.99m, 50, 10, 100 )
            },
            0, "Wheel", 149.99m, 12, 20, 4)
            );
            Products.Add(new Product(
            new BindingList<Part>
            {
                new Part (1, "Screw", 1.99m, 100, 10, 500 ),
                new Part (2, "Bolt", 5.99m, 50, 10, 100 )
            },
            1, "Lug Nut", 5.99m, 100, 20, 500));
        }


        // addProduct(Product) : void 

        public static void addProduct(List<Part> associatedParts, int productID, string name, decimal price, int inStock, int min, int max)
        {
            Products.Add(new Product(new BindingList<Part>(associatedParts), productID, name, price, inStock, min, max));
        }


        // removeProduct(int) : bool **TODO
        public static bool removeProduct(int idToDelete)
        {

            // needs to check for associated parts as well **TODO

            for (int ctr = Products.Count - 1; ctr >= 0; ctr--)
            {
                if (Products[ctr].productID == idToDelete)
                {
                    Products.RemoveAt(ctr);
                    return true;
                }
            }

            return false;
        }

        //lookupProduct(int) : Product 

        public static Product lookupProduct(int getId)
        {
            
            for (int ctr = Products.Count - 1; ctr >= 0; ctr--)
            {
                if (Products[ctr].productID == getId)
                {
                  return Products[ctr];
                }
            }
            return null;

        }

        //updateProduct(int, Product) : void **TODO

        //addPart(Part) : void
        public static void addPart(int partID, string name, decimal price, int inStock, int min, int max)
        {
            AllParts.Add(new Part(partID, name, price, inStock, min, max));
        }

        //deletePart(Part) : bool 
        public static bool removePart(int idToDelete)
        {

            for (int ctr = AllParts.Count - 1; ctr >= 0; ctr--)
            {
                if (AllParts[ctr].partID == idToDelete)
                {
                    AllParts.RemoveAt(ctr);
                    return  true;
                }
            }

            return false;
        }

        //lookupPart(int) : Part 
        public static Part lookupPart(int getId)
        {

            for (int ctr = AllParts.Count - 1; ctr >= 0; ctr--)
            {
                if (AllParts[ctr].partID == getId)
                {
                    return AllParts[ctr];
                }
            }
            return null;

        }

        //updatePart(int, Part) : void **TODO




    }
}

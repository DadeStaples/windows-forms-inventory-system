using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using static dade_staples_software_I_assessment.Part;
using System.Windows.Forms;

namespace dade_staples_software_I_assessment
{
    public static class Inventory
    {

        //get all Parts and Products and populate default inventory

        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Product> Products = new BindingList<Product>();

        static Inventory()
        {
            AllParts.Add(new Outsourced(0, "Tire", 49.99m, 12, 4, 20, "Staples Machining"));
            AllParts.Add(new InHouse(1, "Screw", 1.99m, 100, 10, 500, 387631));
            AllParts.Add(new InHouse(2, "Bolt", 5.99m, 50, 10, 100, 889173));
            AllParts.Add(new Outsourced(3, "Windshield", 359.99m, 10, 5, 15, "West Coast Auto Glass"));

            Products.Add(
            new Product(
            new BindingList<Part>
            {
                new Outsourced(0, "Tire", 49.99m, 12, 4, 20, "Staples Machining"),
                new InHouse(2, "Bolt", 5.99m, 50, 10, 100, 889173)
            },
            0, "Wheel", 149.99m, 12, 20, 4)
            );
            Products.Add(new Product(
            new BindingList<Part>
            {
                new InHouse(1, "Screw", 1.99m, 100, 10, 500, 387631),
                new InHouse(2, "Bolt", 5.99m, 50, 10, 100, 889173)
            },
            1, "Lug Nut", 5.99m, 100, 20, 500));
        }


        // addProduct(Product) : void

        public static void addProduct(Product incomingProduct)
        {
            Products.Add(incomingProduct);
        }


        // removeProduct(int) : bool
        public static bool removeProduct(int idToDelete)
        {

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

        //updateProduct(int, Product) : void
        public static void updateProduct(int idToUpdate, Product incomingProduct)
        {
            Products[idToUpdate] = incomingProduct;
        }

        //addPart(Part) : void 
        public static void addPart(Part incomingPart)
        {
            AllParts.Add(incomingPart);
        }

        //deletePart(Part) : bool
        public static bool removePart(int idToDelete)
        {
            foreach (Product product in Products)
            {
                foreach (Part assocPart in product.associatedParts)
                {
                    if (idToDelete == assocPart.partID)
                    {
                        MessageBox.Show($"Part cannot be deleted, product '{product.name}' contains this part. Please delete any products that contain '{assocPart.name}' and try again.",
                                        "Product Conflict",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            foreach (Part part in AllParts)
            {
                if (part.partID == idToDelete)
                {
                    AllParts.Remove(part); 
                    return true;
                }
            }

            return false;
        }

        //lookupPart(int) : Part 
        public static Part lookupPart(int getId)
        {

            foreach (Part part in AllParts)
            {
                if (part.partID == getId)
                {
                    return part;
                }
            }
            return null;

        }

        //updatePart(int, Part) : void
        public static void updatePart( int idToUpdate, Part incomingPart )
        {
            AllParts[idToUpdate] = incomingPart;          
        }

        public static int newPartId()
        {
            if (AllParts.Count == 0)
                return 1;

            return AllParts.Max(p => p.partID) + 1;
        }

        public static int newProductId()
        {
            if (Products.Count == 0)
                return 1;

            return Products.Max(p => p.productID) + 1;
        }




    }
}

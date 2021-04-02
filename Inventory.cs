using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Richard_Menz
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool removeProduct(int productID)
        {
            foreach (var product in Products)
            {
                if(productID == product.ProductID)
                {
                    Products.Remove(product);
                    return true;
                }
            }
            return false;
        }

        public static Product lookupProduct(int productID)
        {
            Product productToReturn = null;
            foreach (var product in Products)
            {
                if(product.ProductID == productID)
                {
                    productToReturn = product;
                }
            }
            return productToReturn;
            
        }

        public static void updateProduct(int productID, Product updated)
        {
            foreach (var product in Products)
            {
                if(product.ProductID == productID)
                {
                    product.AssociatedParts = updated.AssociatedParts;
                    product.Name = updated.Name;
                    product.Price = updated.Price;
                    product.InStock = updated.InStock;
                    product.Min = updated.Min;
                    product.Max = updated.Max;
                    return;
                }
            }
        }

        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool deletePart(Part partToRemove)
        {
            // J. Exception handling requirements:
            // "Confirm “Delete” actions"
            DialogResult result = MessageBox.Show("Are you sure that you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // J. Exception handling requirements:
                // "Prevent the user from deleting a product that has a Part associated with it"
                foreach (var part in AllParts)
                {
                    if (part.PartID == partToRemove.PartID)
                    {
                        AllParts.Remove(part);
                        return true;
                    }
                }
            }

            return false;
            
        }
        public static Part lookupPart(int LookupPartID)
        {
            Part partToReturn = null;
            foreach (var part in AllParts)
            {
                if (part.PartID == LookupPartID)
                {
                    partToReturn = part;
                }
            }
            return partToReturn;

        }

        public static void updatePart(int PartID, Part updated)
        {
            foreach (var part in AllParts)
            {
                if (part.PartID == PartID)
                {
                    part.Name = updated.Name;
                    part.Price = updated.Price;
                    part.InStock = updated.InStock;
                    part.Min = updated.Min;
                    part.Max = updated.Max;
                    return;
                }
            }
        }
    }
}

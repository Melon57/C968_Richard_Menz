using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Richard_Menz
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int PartID)
        {
            foreach (var part in AssociatedParts)
            {
                if(part.PartID == PartID)
                {
                    AssociatedParts.Remove(part);
                    return true;
                }

            }
            return false;
        }

        public Part lookupAssociatedPart(int PartID)
        {
            Part lookUpPart = null;
            foreach (var part in AssociatedParts)
            {
                if(part.PartID == PartID)
                {
                    lookUpPart = part;
                    return lookUpPart;
                }
            }
            return lookUpPart;
            
        }

    }
}

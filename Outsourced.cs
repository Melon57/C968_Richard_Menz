using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Richard_Menz
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }
        public Outsourced(int PartID, string Name, decimal Price, int InStock, int Min, int Max) : base(PartID, Name, Price, InStock, Min, Max)
        {

        }
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName) : base(partID, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }
    }
}

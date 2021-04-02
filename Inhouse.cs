using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Richard_Menz
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }
        public Inhouse(int PartID, string Name, decimal Price, int InStock, int Min, int Max) : base(PartID,Name,Price,InStock,Min,Max)
        {

        }
        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID) : base(partID, name, price, inStock, min, max)
        {
            MachineID = machineID;
        }
    }
}

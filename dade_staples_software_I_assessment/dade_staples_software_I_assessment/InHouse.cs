using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dade_staples_software_I_assessment
{
    public class InHouse : Part
    {
        public int MachineID { get; set; }

        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
            : base(partID, name, price, inStock, min, max)
        {
            this.MachineID = machineID;
        }
    }
}

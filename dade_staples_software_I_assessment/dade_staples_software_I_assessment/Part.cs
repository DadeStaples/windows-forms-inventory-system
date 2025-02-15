using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dade_staples_software_I_assessment
{
    public abstract class Part
    {
        public int partID { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int inStock { get; set; }
        public int min { get; set; }
        public int max { get; set; }

        public virtual string manufactureType
        {
            get { return "Unknown"; }
        }


        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            this.partID = partID;
            this.name = name;
            this.price = price;
            this.inStock = inStock;
            this.min = min;
            this.max = max;
        }
    }

}

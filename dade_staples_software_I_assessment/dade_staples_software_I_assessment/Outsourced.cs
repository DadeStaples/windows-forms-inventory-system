using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dade_staples_software_I_assessment
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
            : base(partID, name, price, inStock, min, max)
        {
            this.CompanyName = companyName;
        }
    }
}

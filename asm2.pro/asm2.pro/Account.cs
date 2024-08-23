using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2.pro
{
    internal class Account
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double LastMonthWater { get; set; }
        public double ThisMonthWater { get; set; }
        public string TypeCustomer { get; set; }
        public double Consumed { get; set; }
        public double TotalBill { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2.pro
{
    internal class Customer
    {
        public string ID { get; internal set; }
        public string Name { get; set; }
        public double LastMonthWater { get; internal set; }
        public double ThisMonthWater { get; internal set; }
        public string TypeCustomer { get; internal set; }
        public double Consumed { get; set; }
        public double TotalBill { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace assignment4
{
    public class Employee
    {
       private  int eid;
        private static int count = 0;
       private string name;
       private double hra, da, pt, pf,bs,total,netpaid;

        public Employee(string name,double pt,double bs)
        {
            count++;
            eid = count;
            this.name = name;
            this.pt = pt;
            this.bs = bs;
        }

        public void Calculate()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;

            total = bs + hra + da + pf + pt;
            netpaid = total - pf - pt;
        }

        public static  int DisplayCount()
        {
            
            return count;
        }
        /* public string Display()
         {
             return $"employee detail: empid {eid} \nname {name} \nhra {hra} \nda {da} \npf {pf} \ntotalsalary {total} \nnetPaid {netpaid}";
         }*/
        public override string ToString()
        {
            return $"emp: \nempid {eid} \nname {name} \ntotalsalary {total} \nnetpaid {netpaid}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("rekha", 200,45000);
            Employee e1 = new Employee("surekha", 200, 50000);
            e.Calculate();
            e1.Calculate();

            //Console.WriteLine(e.Display());
            //Console.WriteLine(e1.Display());
            Console.WriteLine(Employee.DisplayCount());

            Console.WriteLine(e);
            Console.WriteLine(e1);
        }
    }
}

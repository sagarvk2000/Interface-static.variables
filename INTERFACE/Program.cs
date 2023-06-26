using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Employee e1 = new Employee("sagar", 10000);
            //e1.CalulateSalary();
            //Console.WriteLine(e1.ToString());

            //Employee e2 = new Employee("om", 20000);
            //e2.CalulateSalary();
            ////Console.WriteLine(e2.ToString());

            ////Console.WriteLine(e1.PrintD());
            //Console.WriteLine(e2.PrintD());
            //Console.WriteLine(Employee.GetCount());

            Circle c1 = new Circle(4);
            c1.CalculateArea();
            Console.WriteLine(c1);

            Rectangle r1 = new Rectangle(4, 5);
            r1.CalculateArea();
            Console.WriteLine(r1);

        }
    }
}

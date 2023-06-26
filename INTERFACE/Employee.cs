using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE
{  
        public interface IPrint
        {
            string PrintD();
        }
        public class Employee:IPrint
        {
            private string ename;
            private double basesal, gs, hra, ta, da, pf;
            private int empid;
            private static int count;

            public Employee(string ename, int basesal)
            {
                count++;
                this.empid = count;
                this.ename = ename;
                this.basesal = basesal;
            }

            public static string GetCount()
            {
                return "Count is =" + count;
            }

            public void CalulateSalary()
            {
                hra = basesal * 0.40;
                ta = basesal * 0.20;
                da = basesal * 0.15;
                pf = basesal * 0.12;

                //total = (hra+da+ta);

                gs = (hra + da + ta) - pf;
            }
            public string PrintD()
            {
                return $"name is {ename}\n id is {empid} \nbasic salary is {basesal}\ngross salary is {gs}";
            }

            public override string ToString()
            {
                return $"name is {ename}\n id is {empid} \nbasic salary is {basesal}\ngross salary is {gs}";
            }
        }
    }


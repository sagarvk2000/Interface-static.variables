using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE
{
    public interface IPrintD
    {
        string Print();
    }
    abstract public class shape
    {
        public abstract void CalculateArea();
    }
    public class Circle : shape, IPrintD
    {
        private int r;
        private double area;

        public Circle(int r)
        {
            this.r = r;
        }
        public override void CalculateArea()
        {
            area = 3.14 * r * r;
        }

        public override string ToString()
        {
            return $"Area is {area}";
        }

        public string Print()
        {
            return $"Area is {area}";
        }
    }
    public class Rectangle : shape, IPrintD
    {
        private int l, b;
        private double area;

        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }
        public override void CalculateArea()
        {
            area = l * b;
        }
        public override string ToString()
        {
            return $"Area is {area}";
        }
        public string Print()
        {
            return $"Area is {area}";
        }

    }
}

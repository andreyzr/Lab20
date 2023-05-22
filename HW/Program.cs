using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        delegate double MyDelegate(double a);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Len;
            myDelegate += Square;
            myDelegate += Volume;
            double x= myDelegate(5);
            Console.ReadKey();
        }
        static double Len(double a)
        {
            double l = 2*Math.PI* a;
            Console.WriteLine(l);
            return l;
        }
        static double Square(double a)
        {
            double s =  Math.PI * Math.Pow(a,2);
            Console.WriteLine(s);
            return s;
        }
        static double Volume(double a)
        {
            double v = 4/3*(Math.PI * Math.Pow(a, 3));
            Console.WriteLine(v);
            return v;
        }
    }
}

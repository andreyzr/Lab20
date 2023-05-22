using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW
{
    internal class Program
    {
        delegate int MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = PowerAB;
            //int r=myDelegate(2, 10);                          //Первый способ
            //Console.WriteLine(r);        

            //myDelegate=PowerBA;
            //r=myDelegate(2, 10);
            //Console.WriteLine(r);
            MyDelegate myDelegate = PowerAB;
            myDelegate += PowerBA;
            int r = myDelegate(2, 10);
            //Console.WriteLine(r);                        //Первый способ                 
            Console.ReadKey();
        }

        //static int PowerAB(int a, int b) => (int)Math.Pow(a, b);   //Первый способ
        //static int PowerBA(int a, int b) => (int)Math.Pow(b, a);
        static int PowerAB(int a, int b) 
        {
            int r=(int)Math.Pow(a,b);
            Console.WriteLine(r);
            return r;
        }
        static int PowerBA(int a, int b) 
        {
            int r = (int)Math.Pow(b, a);
            Console.WriteLine(r);
            return r;
        }

    }
}

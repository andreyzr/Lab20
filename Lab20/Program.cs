using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    internal class Program
    {
        //delegate int MyDelegate();
        delegate void MyDelegate();
        //delegate int MyDelegate(int v1, int v2);
        //delegate int MyDelegate(int a, int b);
        //delegate void MyDelegate<T>(T a);               //-параметризация метода 
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = delegate (int v1, int v2)   //-Ананимные методы 
            //{
            //    Console.WriteLine("Method5");
            //    return v1 + v2;
            //};
            //myDelegate(1, 2);

            //MyDelegate myDelegate =  (int v1, int v2)=> v1 + v2;     //-Ананимные методы на основе лямда выражения (если действие одно и это команда return)

            //MyDelegate myDelegate =  ()=> 3;                         //-Ананимные методы на основе лямда выражения (если метод не пренимает аргументов)

            MyDelegate myDelegate = () =>Console.WriteLine("Hello");   //-Ананимные методы на основе лямда выражения (если метод типа void)
            myDelegate();

            //Action action = Method1;                    //-метод без аргумента              
            //action();

            //Action<string> action = Method3;             //-метод c аргументом 
            //action("Hello");

            //MyDelegate myDelegate =new MyDelegate(Method5);                  // Ссылка на метод
            //myDelegate?.Invoke(3, 4);                                        //?-проверка на null
            //MyDelegate<string> myDelegate = new MyDelegate<string>(Method3); //-параметризация метода 
            //myDelegate?.Invoke("Hello");
            Console.ReadKey();
        }
        static void Method1()
        {
            Console.WriteLine("Method 1");
        }
        static void Method2()
        {
            Console.WriteLine("Method 2");
        }
        static void Method3(string name)
        {
            Console.WriteLine("Method 3");
            Console.WriteLine(name);
        }
        static string Method4(string name)
        {
            Console.WriteLine("Method 4");
            Console.WriteLine(name);
            return name;
        }
        static int Method5(int v1, int v2)
        {
            Console.WriteLine("Method 5");
            return v1 + v2;
        }
        static int Method6(int a, int b)
        {
            Console.WriteLine("Method 6");
            return a * b;
        }
        static string Method7(string name, int v)
        {
            Console.WriteLine("Method 7");
            Console.WriteLine(name + v);
            return name + v;
        }
        static string Method8(int v, string name)
        {
            Console.WriteLine("Method 8");
            Console.WriteLine(name + v);
            return name + v;
        }
        static void Method9(string name, int v)
        {
            Console.WriteLine("Method 9");
            Console.WriteLine(name + v);
        }
        static bool Method10(int v)
        {
            Console.WriteLine("Method 10");
            return v % 3 == 0;
        }
    }
}

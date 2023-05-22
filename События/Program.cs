using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace События
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(1000);
            bank.Notify += Log;
            bank.Put(1000);
            bank.Get(500);
            Console.ReadKey();
        }
        static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Bank
    {
        public delegate void LogDelegate(string message);
        public event LogDelegate Notify;
        private int Summa;
        public Bank(int Summa)
        {
            this.Summa = Summa;
        }
        public void Put(int S)
        {
            Summa += S;
            Notify?.Invoke($"Пополнение.Баланс{Summa}");
        }
        public void Get(int S)
        {
            Summa -= S;
            Notify?.Invoke($"Списание.Баланс{Summa}");
        }
    }

}

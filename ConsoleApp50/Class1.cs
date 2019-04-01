using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные");
            Product kaha = new Product();
            kaha.SetInfo();
            kaha.GetInfo();
            Console.ReadKey();
        }
    }
}

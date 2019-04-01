using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    class Product
    {
        public string Name { get; set; }
        public string Cypher { get; set; }
        public int Count { get; set; }

        public Product()
        {
            Name = " ";
            Cypher = " ";
            Count = 0;
        }

        public void SetInfo()
        {
            Console.WriteLine("Введите название: ");
            Name = Console.ReadLine();

            Console.WriteLine("Введите шифр: ");
            Cypher = Console.ReadLine();

            Console.WriteLine("Введите количество: ");
            Count = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Наиминование: {Name}");
            Console.WriteLine($"Номер счёта: {Cypher}");
            Console.WriteLine($"Сумма: {Count}\n");
        }

    }
}

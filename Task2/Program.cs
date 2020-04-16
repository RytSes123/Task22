using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int AA = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            int BB = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum is:{ AA + BB}");
            Console.ReadKey();
        }
    }
}

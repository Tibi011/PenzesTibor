using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Elso szam: ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Masodik szam: ");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int c = a % b;
            Console.WriteLine($"{a}:{b}={a/b}, maradek {c}");


            Console.ReadKey();
        }
    }
}

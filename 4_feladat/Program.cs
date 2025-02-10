using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int a = 0;
            int db = 0;
            int db2 = 0;
            Console.WriteLine($"Generalt szamok: ");
            for (int i = 0; i <= 20; i++)
            {
                a=r.Next(1, 101);
                if (a % 2 == 0)
                {
                    db++;
                }
                else if (a % 2 != 0)
                {
                    db2++;
                }
                Console.Write($"{a} ");
                
            }
            Console.WriteLine("");
            Console.WriteLine($"Paros szamok: {db}");
            Console.WriteLine($"Paratlan szamok: {db2}");


            Console.ReadKey();
        }
    }
}

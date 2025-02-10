using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a neved: ");
            string a=Console.ReadLine();
            Console.Write("Add meg a korod: ");
            int b=int.Parse(Console.ReadLine());

            if (b >= 18)
            {
                Console.WriteLine($"{a} nagykorú ({b})");
            }
            else
            {
                Console.WriteLine($"{a} kiskorú ({b})");
            }

            Console.ReadKey();
        }
    }
}

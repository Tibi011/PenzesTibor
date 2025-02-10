using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Egy kg alma ara: ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Hany kg almat veszel: ");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine($"Ennyi alma ara {a*b} korona");

            Console.ReadKey();
        }
    }
}

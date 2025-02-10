using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonusz_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r=new Random();
            int a = 0;
            int osszeg = 0;

            for (int i = 0; i < 5; i++)
            {
                a= r.Next(1, 91);
                Console.WriteLine(a);
                if(a % 2 == 0)
                {
                    Console.WriteLine("Paros");
                }
                else if(a % 2 != 0)
                {
                    Console.WriteLine("Paratlan");
                }
                osszeg += a;



                

            }


            Console.WriteLine($"Kihuzott szamok osszege: {osszeg}");

            Console.ReadKey();
        }
    }
}

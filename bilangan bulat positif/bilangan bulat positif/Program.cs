using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilangan_bulat_positif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan bilangan: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if (angka > 0)
            {
                Console.WriteLine("Bilangan posiif");
            }
            else if (angka < 0)
            {
                Console.WriteLine("Bilangan negatif");
            }
            else
            {
                Console.WriteLine("Bilangan nol");
            }
        }
    }
}

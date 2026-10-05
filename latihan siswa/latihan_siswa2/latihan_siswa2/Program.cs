using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_siswa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan suhu: ");
            int suhu = Convert.ToInt32(Console.ReadLine());

            if (suhu >= 30)
            {
                Console.WriteLine("Panas");
            }
            else if (suhu >= 20)
            {

                Console.WriteLine("sejuk");
            }
            else
            {

                Console.WriteLine("Dingin");
            }

        }
    }
}

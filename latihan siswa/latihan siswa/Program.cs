using System;

namespace latihan_siswa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // no. 1
            // membuat progam genap dan ganjil

            Console.Write("Masukan bilangan: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if (angka > 0)
            {
                Console.WriteLine("Genap");
            }
            else
            {
                Console.WriteLine("Ganjil");
            }


            
        }   
    }
}

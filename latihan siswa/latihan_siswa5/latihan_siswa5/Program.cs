using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_siswa5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== KALKULATOR ===");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Keluar");

            Console.Write("Pilih menu: ");
            int pilihankalkulator = Convert.ToInt32(Console.ReadLine());

            if (pilihankalkulator >= 1 && pilihankalkulator <= 3)
            {
                Console.Write("Masukkan bilangan pertama: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan bilangan kedua: ");
                int b = Convert.ToInt32(Console.ReadLine());

                switch (pilihankalkulator)
                {
                    case 1:
                        Console.WriteLine("Hasil = " + (a + b));
                        break;

                    case 2:
                        Console.WriteLine("Hasil = " + (a - b));
                        break;

                    case 3:
                        Console.WriteLine("Hasil = " + (a * b));
                        break;
                }
            }
            else if (pilihankalkulator == 4)
            {
                Console.WriteLine("Keluar");
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_siswa4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1.tambah");
            Console.WriteLine("2.tampil");
            Console.WriteLine("3.edit");
            Console.WriteLine("4.hapus");
            Console.WriteLine("5.keluar");

            Console.Write("pilih menu: ");
            int pilihan1 = Convert.ToInt32(Console.ReadLine());

            switch (pilihan1)
            {
                case 1:
                    Console.WriteLine("menu tampil");
                    break;

                case 2:
                    Console.WriteLine("menu tampil");
                    break;

                case 3:
                    Console.WriteLine("menu edit");
                    break;

                case 4:
                    Console.WriteLine("menu hapus");
                    break;

                case 5:
                    Console.WriteLine("keluar");
                    break;

                default:

                    Console.WriteLine("pilihan tidak valid");
                    break;
            }

        }
    }
}

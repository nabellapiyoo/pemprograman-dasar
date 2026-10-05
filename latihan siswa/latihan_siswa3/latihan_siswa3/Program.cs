using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_siswa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan total belanja: ");
            double total = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1.umum");
            Console.WriteLine("2.member");
            Console.Write("pilih jenis pelanggan: ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            double diskon = 0;
            switch (pilihan)
            {
                case 1:
                    diskon = 0;
                    break;
                case 2:
                    diskon = 0.05;
                    break;

                default:
                    Console.WriteLine("pilihan tidak valid");
                    return;

            }
            double potongan = total * diskon;
            double bayar = total - potongan;

            Console.WriteLine("diskon : " + potongan);

            Console.WriteLine("bayar : " + bayar);

        }
    }
}

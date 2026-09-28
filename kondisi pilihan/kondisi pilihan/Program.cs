using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kondisi_pilihan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // percabangan (kondisi_pilihan)

            Console.Write("Masukan nilai siswa: ");
            int nilai = int.Parse(Console.ReadLine());

            if (nilai >= 75)
            {
                Console.WriteLine("Selamat Anda dinyatakan LULUS");

            }
            else
            {
                Console.WriteLine("Mohon maaf, Anda harus mengikkuti REMIDI");
            }
            Console.Write("mAUKAN nilai ujian: ");
            int nilai = int.Parse(Console.redaline());

            string grade;

            if (nilai >= 90)
            {
                grade = "A (Sangat Baik)";
            }
            else if (nilai >=80)
            {
                grade = "B (Baik)";
            }
        }
    }
}

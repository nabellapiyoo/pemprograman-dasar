using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Praktik 1 
            // Nama : Nabella Safitri
            // Kelas : X PPLG 2
            // membuat project console
            Console.WriteLine("Selamat Datang Di Pemprogaman Dasar C#");
            Console.WriteLine("SMK N 1 KANDEMAN");// perintah menampilkan teks di console

            // Praktik 2
            // Nama : Nabella Safitri
            // Kelas : X PPLG 2
            // PERBEDAAN Write dan WriteLine
            Console.Write("nama :  ");
            Console.Write("Nabella");
            Console.WriteLine("");
            Console.WriteLine("Kelas: X PPLG 2");
            Console.WriteLine("Materi: C#");

            // Praktik 3
            // Nama : Nabella Safitri
            // Kelas : X PPLG 2
            // membuat dan memanggil variabel
            string nama = "Nabella";
            int umur = 15;
            double tinggi = 150;
            char kelas = 'X';
            bool aktif = true;
            Console.WriteLine("Nama : " + nama);
            Console.WriteLine("Umur: " + umur);
            Console.WriteLine("Tinggi: " + tinggi);
            Console.WriteLine("Kelas: " + kelas);
            Console.WriteLine("Aktif: " + aktif);

            // Praktik 4
            // Nama : Nabella Safitri
            // Kelas : X PPLG 2
            // input nama dan umur 
            Console.WriteLine("Masukan Nama: ");
            string namasiswa = Console.ReadLine();
            Console.Write("Masukan umur: ");
            int umursiswa = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("=== DATA SISWA ===");
            Console.WriteLine("Nama : " + namasiswa);
            Console.WriteLine("umur : " + umursiswa + "tahun");

            // Praktik 5
            // Nama : Nabella Safitri
            // Kelas : X PPLG 2
            // progam biodata sederhana 
            Console.Write("Nama      : ");
            string namasaya = Console.ReadLine();

            Console.Write("Kelas     : ");
            string kelassaya = Console.ReadLine();

            Console.Write("Jurusan     : ");
            string jurusansaya = Console.ReadLine();

            Console.Write("Umur      : ");
            int umursaya = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("=== BIODATA ===");
            Console.WriteLine("Nama     : " + namasaya);
            Console.WriteLine("Kelas    : " + kelassaya);
            Console.WriteLine("Jurusan  : " + jurusansaya);
            Console.WriteLine("Umur     : " + umursaya + "tahun");
                
            

            // Menampilkan pesan "Hello, World" di konsol
            // Dibuat oleh Nabella Safitri
            // Kelas X PPLG 2
            Console.WriteLine("HelloWorld");
            Console.WriteLine("Hello Duniya");
            Console.WriteLine("= IDENTITAS SISWA =");
            Console.WriteLine("Nama= Nabella Safitri");
            Console.WriteLine("Kelas= X PPLG");
            Console.WriteLine("Jurusan= PPLG");
        }
    }
}

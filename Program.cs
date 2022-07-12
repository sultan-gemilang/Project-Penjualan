using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Penjualan
{
    class Program
    {
        static List<string> daftarPenjualan = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu

            Console.WriteLine("Pilih Menu Aplikasi\n");

            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan p = new Penjualan();
            
            Console.WriteLine("Tambah Data Penjualan\n");

            Console.WriteLine("Nota: ");
            p.nota = Console.ReadLine();

            Console.WriteLine("Tanggal: ");
            p.tanggal = Console.ReadLine();
            
            Console.WriteLine("Customer: ");
            p.nama = Console.ReadLine();

            Console.WriteLine("Jenis: ");
            p.jenis = Console.ReadLine();

            Console.WriteLine("Total Nota: ");
            p.total = Console.ReadLine();

            daftarPenjualan.Add(p.nota);
            daftarPenjualan.Add(p.tanggal);
            daftarPenjualan.Add(p.nama);
            daftarPenjualan.Add(p.jenis);
            daftarPenjualan.Add(p.total);

            //daftarPenjualan.Add(p); napa nggak bisa ya?

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();

            
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", i, daftarPenjualan[i]);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

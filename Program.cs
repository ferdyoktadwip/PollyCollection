using System;
using Collection.induk;
using Collection.anak;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) -- Polymorphism, Abstraction & Collection ";

        
            KaryawanTetap karyawantetap = new KaryawanTetap();
            karyawantetap.Nik = "231-0199-800";
            karyawantetap.Nama = "Ferdy Okta Dwi Prasetya";
            karyawantetap.GajiBulanan = 3000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.Nik = "300-320-000";
            karyawanharian.Nama = "Yuan Shinta Bella";
            karyawanharian.JumlahJamKerja = 8;
            karyawanharian.UpahPerJam = 20000;

            Sales sales = new Sales();
            sales.Nik = "444-323-453";
            sales.Nama = "Cindy Widyawati";
            sales.JumlahPenjualan = 40;
            sales.Komisi = 50000;
            // objek class collection
            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik: {1} Nama: {2} Gaji: {3:N0}",
                    noUrut,
                    karyawan.Nik,
                    karyawan.Nama,
                    karyawan.TotalGaji());

                noUrut++;
            }
            

            Console.ReadKey();
        }
    }
}

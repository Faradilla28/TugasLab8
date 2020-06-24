using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab8

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection";
            Console.WriteLine("           FARADILLA           ");
            Console.WriteLine("           19.11.2838           ");
            Console.WriteLine("");

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "7074000110010166";
            karyawanTetap.Nama = "Ujang";
            karyawanTetap.GajiBulanan = 5000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "7485014384280002";
            karyawanHarian.Nama = "Dadang";
            karyawanHarian.JumlahJamKerja = 12;
            karyawanHarian.UpahPerJam = 25000;

            Sales sales = new Sales();
            sales.Nik = "7404071707980002";
            sales.Nama = "Galang Arifin";
            sales.JumlahPenjualan = 25;
            sales.Komisi = 40000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}

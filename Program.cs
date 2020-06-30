using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace OOPCollection2
{
    public class Program
    {
        static void Main(string[] args)
        {
            karyawantetap[] karyawantetap = new karyawantetap[20];
            karyawanharian[] karyawanharian = new karyawanharian[20];
            sales[] sales = new sales[20];

            List<karyawan> listkaryawan = new List<karyawan>();

            int menu, kr;
            int i = 0, j = 0, k = 0;
            do
            {
            awal:
                Console.WriteLine("PILIH MENU APLIKASI DATA KARYAWAN\n");
                Console.WriteLine("\n1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar\n");

                Console.Write("Nomor Menu [1..4] : ");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("TAMBAH DATA KARYAWAN");
                            Console.WriteLine("Silahkan pilih jenis karyawan yang ingin di input");
                            Console.WriteLine("\n[1] Karyawan Tetap | [2] Karyawan Harian | [3] Sales");
                            Console.Write("\nKaryawan yang akan ditambah : ");
                            Console.WriteLine("Atau pilih [4] untuk kembali ke menu");

                            kr = Convert.ToInt32(Console.ReadLine());

                            switch (kr)
                            {
                                case 1:
                                    i++;
                                    karyawantetap[i] = new karyawantetap();

                                    Console.Clear();
                                    Console.WriteLine("Masukkan Data Karyawan Tetap\n");
                                    Console.Write("Nik : ");
                                    karyawantetap[i].nik = Console.ReadLine();
                                    Console.Write("Nama : ");
                                    karyawantetap[i].nama = Console.ReadLine();
                                    Console.Write("Gaji Bulanan : ");
                                    karyawantetap[i].gajibulanan = Convert.ToDouble(Console.ReadLine());
                                    karyawantetap[i].status = "Karyawan Tetap";

                                    listkaryawan.Add(karyawantetap[i]);
                                    Console.WriteLine("\n");
                                    break;

                                case 2:
                                    j++;
                                    karyawanharian[j] = new karyawanharian();

                                    Console.Clear();
                                    Console.WriteLine("Masukkan Data Karyawan Harian\n");
                                    Console.Write("Nik : ");
                                    karyawanharian[j].nik = Console.ReadLine();
                                    Console.Write("Nama : ");
                                    karyawanharian[j].nama = Console.ReadLine();
                                    Console.Write("Upah per jam : ");
                                    karyawanharian[j].upahperjam = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Jam kerja : ");
                                    karyawanharian[j].jumlahjamkerja = Convert.ToDouble(Console.ReadLine());
                                    karyawanharian[j].status = "Karyawan Harian";

                                    listkaryawan.Add(karyawanharian[j]);
                                    Console.WriteLine("\n");
                                    break;

                                case 3:
                                    k++;
                                    sales[k] = new sales();

                                    Console.Clear();
                                    Console.WriteLine("Masukkan Data Sales\n");
                                    Console.Write("Nik : ");
                                    sales[k].nik = Console.ReadLine();
                                    Console.Write("Nama : ");
                                    sales[k].nama = Console.ReadLine();
                                    Console.Write("Jumlah Penjualan : ");
                                    sales[k].jumlahpenjualan = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Komisi : ");
                                    sales[k].komisi = Convert.ToDouble(Console.ReadLine());
                                    sales[k].status = "Sales";

                                    listkaryawan.Add(sales[k]);
                                    Console.WriteLine("");
                                    break;

                                case 4:
                                    Console.Clear();
                                    goto awal;
                            }
                        }
                        while (kr != 4);
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Hapus Karyawan\n");
                        Console.Write("Masukkan Nik Karyawan yang ingin di hapus : ");
                        string hapus = Console.ReadLine();

                        if (listkaryawan.Any(n => n.nik == hapus))
                        {
                            listkaryawan.RemoveAll(x => x.nik == hapus);
                            Console.WriteLine("Data karyawan berhasil dihapus!\n");
                        }
                        else
                        {
                            Console.WriteLine("Data karyawan tidak ditemukan");
                        }

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("DATA KARYAWAN\n");
                        int noUrut = 0;

                        foreach (karyawan karyawan in listkaryawan)
                        {
                            noUrut++;
                            Console.WriteLine("{0}. NIK : {1} | Nama : {2} | Gaji : {3:N0} | {4}", noUrut, karyawan.nik, karyawan.nama, karyawan.gaji(), karyawan.status);
                        }

                        Console.WriteLine("");
                        break;

                    case 4:
                        Console.WriteLine("SAMPAI JUMPA LAGI! ^_^");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Tidak ada pilihan dalam menu!");
                        break;
                }

            }
            while (menu != 4);
            Console.WriteLine("");
            Environment.Exit(0);
        }
    }
}
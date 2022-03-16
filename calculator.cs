//NIM  : 21.11.4352
//NAMA : Reksa Panduasa
using System;

namespace Tugas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Menu Kalkulator :\n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian\n");

            Console.Write("Input nomer menu [1..4]: ");
            int pilihan = int.Parse(Console.ReadLine());

            if (pilihan == 1)
            {
                Console.Write("Inputkan nilai A = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai B = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b) + "\n");
            }
            else if (pilihan == 2)
            {
                Console.Write("Inputkan nilai A = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai B = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b) + "\n");
            }
            else if (pilihan == 3)
            {
                Console.Write("Inputkan nilai A = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai B = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian " + a + " x " + b + " = " + Perkalian(a, b) + "\n");
            }
            else if (pilihan == 4)
            {
                Console.Write("Inputkan nilai A = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai B = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian " + a + " : " + b + " = " + Pembagian(a, b) + "\n");
            }
            else
            {
                Console.WriteLine("\nMaaf, pilihan yang anda pilih tidak tersedia\n");
            }

            Console.WriteLine("Tekan tombol apa saja untuk menutup tapi jangan tombol power yak:v");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static double Pembagian(double a, double b)
        {
            return a / b;
        }
    }
}

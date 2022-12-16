//Muhammad Fadhil... Dengan NIM 2007111386
using System;

namespace uts
{
    class TukarMataUang
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rate USD ke RP :");
            Console.Write("");
            double HargaUSD = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Jumlah USD :");
            Console.Write("");
            double JumlahRP = Convert.ToDouble(Console.ReadLine());

            double Hasil = HargaUSD * JumlahRP;
            Console.WriteLine("Hasil Konversi Mata Uang USD ke Rupiah : Rp. "+Hasil);
  
        }
    }
}

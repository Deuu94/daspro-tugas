//Muhammmad Fadhil... Dengan NIM 2207111386
using System;

namespace uts
{
    class Kartunama
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama : ");
            string nama = Console.ReadLine();
            Console.WriteLine("Nim  : ");
            string nim = Console.ReadLine();
            Console.WriteLine("Konsentrasi  : ");
            string konsentrasi = Console.ReadLine();
            mahasiswaBaru mhs = new mahasiswaBaru(nama, nim, konsentrasi);
            mhs.Kartunama();
        }  
    }
    class mahasiswaBaru
    {
        string nama;
        string nim;
        string konsentrasi; 

        public mahasiswaBaru(string Nama, string NIM, string Konsentrasi)
        {
            nama = Nama;
            nim = NIM;
            konsentrasi = Konsentrasi;
        }
        public void Kartunama()
        {
            Console.WriteLine();
            Console.WriteLine("|***************************|");
            Console.WriteLine("|Nama : {0,20}|",nama);
            Console.WriteLine("|     : {0,20}|",nim);
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|{0,27}|",konsentrasi);
            Console.WriteLine("|***************************|");
        }
    }
}
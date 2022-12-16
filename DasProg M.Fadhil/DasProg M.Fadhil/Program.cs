// Muhammad Fadhil dengan nim 2207111386

using System;

namespace DasProg_M.Fadhil
{
    class Program
    {
        // tipe data ada int, string, bool
           static int kesempatan = 3;
           static int  level = 1;
           static bool BGameSelesai = true;
            
        static void Main(string[] args)
        {
            //while menyatakan ketika

            while (kesempatan > 0){
                Intro();

                PlayGame();

                if(level > 5){
                    Console.WriteLine("Menang semua level selesai, anda WIN");
                    break;
                }
            }

            Console.WriteLine("Permainanan Selesai");
        }

        static void Intro(){
            Console.WriteLine("anda adalah agen rahasia yang bertugas mendapatkan  data dari server");
            Console.WriteLine("akses ke server membutuhkan password yang tidak di ketahui");   
        }

        static void PlayGame(){ //tipe data int di gunakan untuk menyatakan blg
            int kodeA;
            int kodeB;
            int kodeC;
            int jumlahkode;
            String tebakanA;
            String tebakanB;
            String tebakanC;

            int hasilTambah;
            int hasilKali;

            Random rng = new Random();

            kodeA = rng.Next(1,level + 1);
            kodeB = rng.Next(1,level + 1);
            kodeC = rng.Next(1,level + 1);

            jumlahkode = 3;

            hasilTambah = kodeA+kodeB+kodeC;
            hasilKali = kodeA*kodeB*kodeC;

            Intro();

            Console.WriteLine("Password terdiri dari "+jumlahkode+" angka");
            Console.WriteLine("jika ditambah hasilnya "+hasilTambah);
            Console.WriteLine("jika dikali hasilnya "+hasilKali);

            Console.Write("masukan kode pertama : ");
            tebakanA = Console.ReadLine();
            Console.Write("masukan kode kedua : ");
            tebakanB = Console.ReadLine();
            Console.Write("masukan kode ketiga : ");
            tebakanC = Console.ReadLine();

            Console.WriteLine("Tebakan kamu "+tebakanA+""+tebakanB+""+tebakanC+"?");

            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString()){
                Console.WriteLine("Tebakan Kamu Benar..\n\n");
                
                level += 1;
                Console.WriteLine("Level"+level);
            }else
            {
                Console.WriteLine("Tebakan kamu salah..\n\n");
                kesempatan = kesempatan - 1;
            }

        }
    }
}
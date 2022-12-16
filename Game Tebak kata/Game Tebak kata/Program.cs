// Muhammad Fadhil dengan Nim 2207111386

using System;
using System.Collections.Generic;
namespace Game_Tebak_kata
{
    class Program
    {
        static int Kesempatan = 5;
        static String KataMistery = "haikyuu";
        static List<string> ListTebakan = new List<String>{};

        static void Main(string[] args)
        {
            intro();
            PlayGame();
            EndGame();
        }

        static bool CekJawaban(string Katarahasia, List<string> List)
        {
            bool status = false;
            for (int i = 0; i <Katarahasia.Length; i++)
            {
                string c = Convert.ToString(Katarahasia[i]);
                if(List.Contains(c))
                {
                    status = true;
                } else
                {
                    return status = false;
                }
            }
            return status;
        }

        static string cekhuruf(string Katarahasia, List<string> list)
        {
            string X =  "";

            for (int i = 0; i < Katarahasia.Length;i++)
            {
                string c = Convert.ToString(Katarahasia[i]);
                if(list.Contains(c))
                {
                    X = X + c;
                } else
                {
                    X = X +"-";
                }
            }
            return X;
        }

        static void intro()
        {
            Console.WriteLine("Hari ini kita akan bermain tebak kata");
            Console.WriteLine($"Kamu punya {Kesempatan} kesempatan digunakan untuk menjawab pertanyaan ini");
            Console.WriteLine("klunya kali ini adalah nama Anime ");
            Console.WriteLine($"kata ini terdiri dari {KataMistery.Length} huruf");
            Console.WriteLine("Anime apa yang dimaksud (pilih a-z)");
            Console.WriteLine("Semoga Berhasil :)");
            Console.ReadKey();
        }

        static void PlayGame()
        {
            while (Kesempatan>0)
            {
                String input = Console.ReadLine();
                ListTebakan.Add(input);
                if(CekJawaban(KataMistery, ListTebakan))
                {
                    Console.WriteLine("Selamat! anda berhasil");
                    Console.WriteLine($"kata misteri hari ini adalah {KataMistery}");
                    break;
                } else if(KataMistery.Contains(input))
                {
                    Console.WriteLine("Huruf itu berada di kata ini");
                    Console.WriteLine("Sekarang tebak huruf lain");
                    Console.WriteLine(cekhuruf(KataMistery, ListTebakan));
                }else
                {
                    Console.WriteLine("huruf itu tidak berada di kata ini");
                    Kesempatan--;
                    Console.WriteLine($"Kesempatan anda tersisa {Kesempatan}");
                }
                if(Kesempatan == 0)
                {
                    EndGame();
                    break;
                }
            }
        }

        static void EndGame()
        {
            Console.WriteLine("Permainan berakhir");
        }
    }
}

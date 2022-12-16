// Muhammad Fadhil dengan NIM 2207111386

using System;

namespace Battle_Tank_M.Fadhil
{
    class Program
    {
         static char[,] tank = {
            {' ','1','2','3','4'},
            {'1','^','^','^','^'},
            {'2','^','^','^','^'},
            {'3','^','^','^','^'},
            {'4','^','^','^','^'},
        };

         static int[,] ans = {
            {2,2},
            {2,3},
            {3,1},
        };

        static int[,] recent = {
            {0,0},
            {0,0},
            {0,0},
        };

        static int[] tebakan = {0,0};
        static int Jumlah = 0;
        static bool Game = true;
        static int Benar = 0;

        static void Main(string[] args)
        {
           while(Game)
            {
                drawTank();
                try
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Silahkan Pilih baris Dan Kolom.. GOOD LUCK!!!");
                    Console.Write("Pilih baris: "); tebakan[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Pilih kolom: "); tebakan[1] = Convert.ToInt32(Console.ReadLine());
                }catch(Exception){
                    Console.WriteLine("Upsss.. Tebakan yang kamu pilih salah");
                    Console.WriteLine("Giliran Pemain Berikutnya");
                }
                Benar = cekTank();
                if(Benar == 2)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Nice Tank nya HANCUR");
                }
                else
                if(Benar == 1)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Yeayy Tanknya MELEDAK!");
                    Jumlah++;
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("HAHAHA! Tebakan Salah");
                }
                if(Jumlah >= 3)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("\nMenang! Congrats Tank Sudah Hancur semua..");
                    Game=false;
                }
                Console.WriteLine();
            }
        }

        static void drawTank()
        {
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    Console.Write(tank[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int cekTank()
        {
            for(int i=0;i<3;i++)
            {
                if(recent[i,0] == tebakan[0] && recent[i,1] == tebakan[1])
                {
                    return 2;
                }
            }
            for(int i=0;i<3;i++)
            {
                if(ans[i,0] == tebakan[0] && ans[i,1] == tebakan[1])
                {
                    tank[tebakan[0],tebakan[1]] = 'X';
                    recent[i,0] = tebakan[0];
                    recent[i,1] = tebakan[1];
                    return 1;
                }
                else
                {
                    tank[tebakan[0],tebakan[1]] = '0';
                }
            }
            return 0;
        }
    }
}

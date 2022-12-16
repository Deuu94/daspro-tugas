// by muhammad fadhil dengan nim : 2207111386

using System;

namespace DasPro
{
 class Program
 {
  static void Main(string[] args) 
  {
    /*
    contoh pembuatan int biasa
    int a = 8;
    int g = 4;

    contoh pembuatan int jika belum di perlukan
    int d;
    int w;
    */
 
    //contoh pembuatan const int artinya nilainya tak aakan berubah
    const int a = 1;
    const int b = 2;
    const int c = 3;
    
    int tambah = a+b+c;
    int kali = a*b*c;
    int kurang = a-b-c;
    int bagi = a/b/c;

   Console.WriteLine("anda adalah agen rahasia yang bertugas mendapatkan  data dari server");
   Console.WriteLine("akses ke server membutuhkan password yang tidak di ketahui");
   
   Console.WriteLine("");
   Console.WriteLine("-jika ditambah hasilnya " + tambah);
   Console.WriteLine("-jika dikalikan hasilnya " + kali);
   Console.WriteLine("-jika dikurangkan hasilnya " + kurang);
   Console.WriteLine("-jika dibagi hasilnya " + bagi);
   
   Console.WriteLine("");
   Console.WriteLine("Enter Code");

  }
 }
}
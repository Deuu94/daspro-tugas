using System;

namespace Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat Datang Di ANVENTURE GAME!!");
            Console.WriteLine("Siapa Nama Petualang kali ini?");
            Novice Player = new Novice();
            Player.Name = Console.ReadLine();
            Console.WriteLine("Petualang "+Player.Name+", Kamu siap untuk Pertualangan Kali ini?[ya/tdk]");
            string bready = Console.ReadLine();
            if (bready == "ya")
            {
                Console.WriteLine("Petualang "+Player.Name+" Memasuki Dunia Monster");
                Enemy Enemy1 = new Enemy("BIG SLIME");
                Console.WriteLine(Player.Name+" Menemukan "+Enemy1.Name);
                Console.WriteLine(Enemy1.Name+" Menyerang kamu");
                Console.WriteLine("Pilih Aksi Berikut:");
                Console.WriteLine("1. Serangan Biasa");
                Console.WriteLine("2. Serangan Api");
                Console.WriteLine("3. Bertahan");
                Console.WriteLine("4. Mundur");

                while (!Player.IsDead && !Enemy1.IsDead)
                {
                    string PlayerAction = Console.ReadLine();
                    switch(PlayerAction)
                    {
                        case "1" :
                        Console.WriteLine(Player.Name+" Kamu Melakukan Serangan Biasa");
                        Enemy1.GetHit(Player.AttackPower);
                        Player.Experienc += 0.3f;
                        Enemy1.Attack(Enemy1.AttackPower);
                        Player.GetHit(Enemy1.AttackPower);
                        Console.WriteLine("Darah Mu : "+Player.Health+">> Darah Musuh : "+Enemy1.Health+"\n");
                        break;
                        case "2" :
                        Player.Fire();
                        Player.Experienc += 0.9f;
                        Enemy1.GetHit(Player.AttackPower);
                        Console.WriteLine("Darah Mu : "+Player.Health+"  << >> Darah Musuh : "+Enemy1.Health+"\n");
                        break;
                        case "3" :
                        Player.Restored();
                        Console.WriteLine("Memulihkan Energi");
                        Enemy1.Attack(Enemy1.AttackPower);
                        Player.GetHit(Enemy1.AttackPower);
                        break;
                        case "4" :
                        Console.WriteLine(Player.Name+" Mundur terlebih dahulu");
                        break;
                    }
                    continue;
                }
                
                Console.WriteLine(Player.Name+" Mendapatkan"+Player.Experienc+"EXP");
            }
            else
            {
                Console.WriteLine("Bye.... :(");
                Console.Read();
            }
        }
    }

    class Novice
    {
        public int Health { get; set;}
        public string Name { get; set;}
        public float Experienc { get; set;}
        public int AttackPower { get; set;}
        public int SlotSkill { get; set;}
        public bool IsDead { get; set;}
        Random rnd = new Random();

        public Novice()
        {
            Health = 100;
            SlotSkill = 0;
            AttackPower = 1;
            IsDead = false;
            Experienc = 0f;
            Name = "Pemula";
        }

        public void Fire()
        {
            if(SlotSkill > 0)
            {
                Console.WriteLine("Fireee Ball!!");
                AttackPower = AttackPower + rnd.Next(3,11);
                SlotSkill--;
            }
            else
            {
                Console.WriteLine("Energi kamu belum cukup");
            }
        }

        public void GetHit(int HitValue)
        {
            Console.WriteLine(Name+" Terkena serangan sebesar "+HitValue);
            Health = Health - HitValue;

            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Restored()
        {
            SlotSkill = 3;
            AttackPower = 1;
        }

        public void Die()
        {
            Console.WriteLine("Kamu Mati.. GAME SELESAI!");
            IsDead = true;
        }
    }

    class Enemy
    {
        public string Name { get; set;}
        public int Health { get; set;}
        public int SlotSkill { get; set;}
        public int AttackPower { get; set;}
        public bool IsDead { get; set;}
        Random rnd = new Random();

        public Enemy(string Nama)
        {
            Health = 50;
            Name = Nama;
        }

        public void Attack(int damage)
        {
            AttackPower = rnd.Next(1,10);
        }

        public void GetHit(int HitValue)
        {
            Console.WriteLine(Name+" Terkena Serangan sebesar "+HitValue);
            Health = Health - HitValue;

            if(Health <= 0)
            {
            Health = 0;
            Die();
            }
        }

        public void Die()
        {
            Console.WriteLine(Name +" Matiii");
            IsDead = true;
        }
    }
}

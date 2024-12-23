using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_Free_Food
{
    class Game
    {
        public static Localization sl = new Localization();
        //public static Player player = new Player();
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.WriteLine(sl.welcomeTo + sl.title + "\n" + sl.introduction);
            A:
            var rl = Console.ReadLine();
            if (rl == null || rl == "" || rl.Length > 10)
            {
                Console.WriteLine(sl.nameError);
                goto A;
            }
            Player.name = rl;
            Console.WriteLine(sl.nameSuccess(Player.name) + sl.enterHalt);
            Console.ReadKey();
            for (int i = 0; i < sl.myNameIs.Length; i++)
            {
                Console.Write(sl.myNameIs[i]);
                int delay = (int)(150 * Math.Pow(2, i / 4.0));
                System.Threading.Thread.Sleep(delay);
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine(sl.playerData(Player.name, Player.cash, Player.health, Player.damage));
        }
    }
    static class Player
    {
        public static string name = "";
        public static int cash = 0;
        public static int health = 20;
        public static int damage = 0;
    }
}
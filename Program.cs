using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project_Free_Food
{
    class Game
    {
        public static Localization sl = new Localization();
        //public static Player player = new Player();
        static void Main(string[] args)
        {
            DetermineSave();
        }

        public static void DetermineSave()
        {
            Player.LoadData();
            if (Player.Data.Name == "")
            {
                FirstTimePlayer();
            }
            else
            {
                ContinueGame();
            }
        }

        public static void ContinueGame()
        {
            Console.WriteLine(sl.welcomeTo + sl.title + " " + sl.enterHalt);
            Console.ReadKey();
            Console.WriteLine(sl.playerData(Player.Data.Name, Player.Data.Cash, Player.Data.Health, Player.Data.Damage));
            while (true)
            {
                GenerateStoryelement();
                Console.ReadKey();
            }
        }

        static void GenerateStoryelement()
        {
            Console.WriteLine(sl.defaultEncounterStrings[new Random().Next(0, sl.defaultEncounterStrings.Length)]);
        }

        static void FirstTimePlayer()
        {
            Console.WriteLine(sl.welcomeTo + sl.title + "\n" + sl.introduction);
            A:
            var rl = Console.ReadLine();
            if (rl == null || rl == "" || rl.Length > 10)
            {
                Console.WriteLine(sl.nameError);
                goto A;
            }
            Player.Data.Name = rl;
            Console.WriteLine(sl.nameSuccess(Player.Data.Name) + sl.enterHalt);
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
            Console.WriteLine(sl.playerData(Player.Data.Name, Player.Data.Cash, Player.Data.Health, Player.Data.Damage));
            Player.SaveData();
            ContinueGame();
        }
    }
    public static class Player
    {
        public static PlayerData Data { get; set; } = new PlayerData();

        public static void SaveData()
        {
            var json = JsonSerializer.Serialize(Data);
            File.WriteAllText("save.json", json);
        }

        public static void LoadData()
        {
            if (File.Exists("save.json"))
            {
                var json = File.ReadAllText("save.json");
                Data = JsonSerializer.Deserialize<PlayerData>(json);
            }
            else
            {
                // Initialize default values if no save file exists
                Data.Name = "";
                Data.Cash = 0;
                Data.Health = 0;
                Data.Damage = 0;
            }
        }
    }

    public class PlayerData
    {
        public string Name { get; set; }
        public int Cash { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
    }
}
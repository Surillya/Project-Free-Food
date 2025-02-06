using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Free_Food
{
    class Localization
    {
        public string enterHalt = "↓";
        public string welcomeTo = "Welcome to ";
        public string title = "Project Free Food";
        public string introduction = "It looks like you're here for the first time... Whassa name?";
        public string nameError = "Please enter a valid name. Your name may not contain more than 10 letters.";
        public string myNameIs = "My name is";

        public string[] defaultEncounterStrings = new string[]
        {
            "You arrive at a " + locationType[new Random().Next(0, locationType.Length)] + ".",
            "A " + badCreatureType[new Random().Next(0, badCreatureType.Length)] + " appears in front of you.",
            "You find yourself in a "  + locationType[new Random().Next(0, locationType.Length)] + ".",
            "A " + goodCreatureType[new Random().Next(0, goodCreatureType.Length)] + " approaches you.",
            "You hear a strange noise coming from the distance."
        };

        public static string[] locationType = new string[]
        {
            "forest",
            "city",
            "desert",
            "mountain",
            "cave"
        };

        public static string[] badCreatureType = new string[]
        {
            "aggressive dog",
            "feral cat",
            "wild boar",
            "angry bear",
            "swarm of bees",
            "venomous snake",
            "rabid raccoon",
            "homeless person",
            "gang member",
            "wild turkey"
        };

        public static string[] goodCreatureType = new string[]
        {
            "friendly shopkeeper",
            "kind stranger",
            "helpful tourist",
            "neighborly postman",
            "compassionate paramedic",
            "trustworthy police officer",
            "friendly library assistant",
            "accommodating restaurant host",
            "assisting social worker",
            "kind-hearted park ranger"
        };

        public string playerData(string name, int cash, int health, int damage)
        {
            int currentHealth = health - damage;
            return "Name: " + name + "\n    " + cash + "¥\n    Health: " + currentHealth + "/" + health;
        }

        public string nameSuccess(string playerName)
        {
            return playerName + " hmm? What an... Interesting name indeed. Now, I'm sure you'll find what you need! ";
        }
    }
}

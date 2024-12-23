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

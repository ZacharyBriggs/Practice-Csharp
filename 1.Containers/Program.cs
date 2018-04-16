using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1.Containers
{
    public class Stat
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }

        public static explicit operator Stat(int val)
        {
            Stat temp = new Stat();
            temp.Value = val;
            return temp;
        }

        public static explicit operator Stat(string name)
        {
            Stat temp = new Stat();
            temp.Name = name;
            return temp;
        }
    }

    public class Character
    {

        public Dictionary<string, Stat> SavingThrows = new Dictionary<string, Stat>();
        public int ExperiencePoints;
        public string CharacterName;
        public int Level;
        public Character(string name, int exp, int level)
        {
            CharacterName = name;
            ExperiencePoints = exp;
            Level = level;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<String, Stat> playerStats = new Dictionary<string, Stat>();
            var health = new Stat()
            {
                Name = "Health",
                Value = 10,
                Description = "Wholeness of Entities Ability to Participate"
            };
            var attack = new Stat() {Name = "Attack Power",Value = 5, Description = "How much 'This' Entityl well affect other's ability to participate"};
            var attackCooldown = new Stat() {Name = "Attack Cooldown", Value = 5, Description = "Frequency of affecting other's abiliit to participate"};
            var charismaOther = new Stat() {Name = "Charisma", Value = 3, Description = "Likelihood of someone afecting your ability to participate"};
            var speed = new Stat() {Name = "Speed", Value = 10, Description = "How fast you move"};
            playerStats.Add(health.Name, health);
            playerStats.Add(attack.Name, attack);
            playerStats.Add(attackCooldown.Name, attackCooldown);
            playerStats.Add(charismaOther.Name, charismaOther);
            playerStats.Add(speed.Name, speed);
            */

            Dictionary<string, Stat> SavingThrows = new Dictionary<string, Stat>();
            SavingThrows.Add("Strength", new Stat { Name = "Strength", Value = 0, Description = "" });
            SavingThrows.Add("Dexterity", new Stat { Name = "Dexterity", Value = 0, Description = "" });
            SavingThrows.Add("Constitution", new Stat { Name = "Constitution", Value = 0, Description = "" });
            SavingThrows.Add("Intelligence", new Stat { Name = "Intelligence", Value = 0, Description = "" });
            SavingThrows.Add("Wisdom", new Stat { Name = "Wisdom", Value = 0, Description = "" });
            SavingThrows.Add("Charisma", new Stat { Name = "Charisma", Value = 0, Description = ""});
            foreach (var stat in SavingThrows)
            {
                Console.WriteLine(stat.Key);
            }

        }
    }
}

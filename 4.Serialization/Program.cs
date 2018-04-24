using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using _1.Containers;

namespace _4.Serialization
{
    class Program
    {

        static void Main(string[] args)
        {
            string winDir = System.Environment.GetEnvironmentVariable("windir");
            Stats SavingThrows = new Stats();
            SavingThrows.stats.Add(new Stat { Name = "Strength", Value = 1, Description = "" });
            SavingThrows.stats.Add(new Stat { Name = "Dexterity", Value = 0, Description = "" });
            SavingThrows.stats.Add(new Stat { Name = "Constitution", Value = 0, Description = "" });
            SavingThrows.stats.Add(new Stat { Name = "Intelligence", Value = 0, Description = "" });
            SavingThrows.stats.Add(new Stat { Name = "Wisdom", Value = 0, Description = "" });
            SavingThrows.stats.Add(new Stat { Name = "Charisma", Value = 0, Description = "" });
            string json = JsonConvert.SerializeObject(SavingThrows);
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "json.txt");
            System.IO.File.WriteAllText(path, json);
            var data = File.ReadAllText(path);
            var newstring = JsonConvert.DeserializeObject(data);
        }
    }
}

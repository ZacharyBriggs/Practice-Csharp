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
            StreamWriter writer = new StreamWriter("C:\\Users\\s178020\\Documents\\Visual Studio 2015\\Projects\\Practice-Csharp\\4.Serialization\\stats.txt");
            writer.WriteLine(json);
            writer.Close();
            /*StreamReader reader = new StreamReader(winDir + "C:\\Users\\s178020\\Documents\\Visual Studio 2015\\Projects\\Practice-Csharp\\4.Serialization\\stats.txt");
            try
            {
                do
                {
                    addListItem(reader.ReadLine());
                }
                while (reader.Peek() != -1);
            }

            catch
            {
                addListItem("File is empty");
            }

            finally
            {
                reader.Close();
            }*/
            var a = 1;
        }
    }
}

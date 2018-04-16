using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using _1.Containers;

namespace _2.CombatForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            character = new Character("Dummy", 0, 0);
            character.SavingThrows.Add("Strength", new Stat { Name = "Strength", Value = 0, Description = "" });
            character.SavingThrows.Add("Dexterity", new Stat { Name = "Dexterity", Value = 0, Description = "" });
            character.SavingThrows.Add("Constitution", new Stat { Name = "Constitution", Value = 0, Description = "" });
            character.SavingThrows.Add("Intelligence", new Stat { Name = "Intelligence", Value = 0, Description = "" });
            character.SavingThrows.Add("Wisdom", new Stat { Name = "Wisdom", Value = 0, Description = "" });
            character.SavingThrows.Add("Charisma", new Stat { Name = "Charisma", Value = 0, Description = "" });

        }

        public List<Character> myCharacters = new List<Character>();
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach (var name in comboBox1.Items)
            {
                if (character.CharacterName == name)
                {
                    foreach (var currentCharacter in myCharacters)
                    {
                        if (character.CharacterName == currentCharacter.CharacterName)
                        {
                            character = currentCharacter;
                        }
                    }
                }
            }
            foreach (var stat in character.SavingThrows)
            {
                richTextBox1.Text += stat.Key + " " + stat.Value.Value + "\n";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            foreach (var stat in character.SavingThrows)
            {

                int choice = r.Next(1, 99);
                stat.Value.Value = choice;
            }
            richTextBox1.Text += "Stats randomized.\n";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            myCharacters.Add(character);
            comboBox1.Items.Add(character.CharacterName);
            richTextBox1.Text += "Character saved.\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stat a = (Stat) 1;
            Stat b = (Stat) "Gob";
        }
    }
}

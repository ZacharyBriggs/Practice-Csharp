using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace _3.Interfaces
{
    static class Other
    {
        public interface IDamageable
        {
            bool TakeDamage(int amount);
            int ArmorClass { get; set; }
        }

        public interface IDamager
        {
            int HitModifier { get; set; }

        }
        public class Entity : IDamageable, IDamager
        {
            private int health;
            private string name;
            private int armorclass;

            public int Health
            {
                get { return health; }
                set { health = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int ArmorClass
            {
                get { return armorclass; }

                set { armorclass = value; }
            }

            public int HitModifier
            {
                get { return armorclass; }

                set { armorclass = value; }
            }

            public bool TakeDamage(int amount)
            {
                amount -= this.ArmorClass;
                if (amount < 0)
                {
                    amount = 0;
                }
                this.Health -= amount;
                return true;
            }

            public class Assassin : Entity
            {
                public bool TakeDamage(int amount)
                {
                    this.Health -= amount;
                    if (amount < 0)
                    {
                        amount = 0;
                    }
                    return true;
                }
            }
            public class Ninja : Entity
            {
                public bool TakeDamage(int amount)
                {
                    this.Health -= amount;
                    if (amount < 0)
                    {
                        amount = 0;
                    }
                    return true;
                }
            }
            public class Nord : Entity
            {
                public bool TakeDamage(int amount)
                {
                    this.Health -= amount;
                    if (amount < 0)
                    {
                        amount = 0;
                    }
                    return true;
                }
            }
            public class Soldier : Entity
            {
                public bool TakeDamage(int amount)
                {
                    this.Health -= amount;
                    if (amount < 0)
                    {
                        amount = 0;
                    }
                    return true;
                }
            }
            public class Robot : Entity, IDamager
            {
                public int HitModifier
                {
                    get { return armorclass; }

                    set { armorclass = value; }
                }

                public bool TakeDamage(int amount)
                {
                    this.Health -= amount;
                    if (amount < 0)
                    {
                        amount = 0;
                    }
                    return true;
                }
            }
            public class Witcher : Entity, IDamager
            {
                public int HitModifier
                {
                    get { return armorclass; }

                    set { armorclass = value; }
                }

                public bool TakeDamage(int amount)
                {
                    this.Health -= amount;
                    if (amount < 0)
                    {
                        amount = 0;
                    }
                    return true;
                }
            }
            public class Spartan : Entity, IDamager
            {
                public int HitModifier
                {
                    get { return armorclass; }

                    set { armorclass = value; }
                }

                public bool TakeDamage(int amount)
                {
                    this.Health -= amount;
                    if (amount < 0)
                    {
                        amount = 0;
                    }
                    return true;
                }
            }
        }

        public class Combat
        {
            public List<Entity> Damageables = new List<Entity>();
            public List<Entity> Damagers = new List<Entity>();
            public void Start()
            {
                var ezio = new Entity.Assassin() { Name = "Ezio", Health = 100, ArmorClass = 0 };
                var scorpion = new Entity.Ninja() { Name = "Scorpion", Health = 100, ArmorClass = 0 };
                var nord = new Entity.Nord() { Name = "Dovahkiin", Health = 100, ArmorClass = 0 };
                var soldier = new Entity.Soldier() { Name = "Shepard", Health = 100, ArmorClass = 0 };
                Damageables.Add(ezio);
                Damageables.Add(scorpion);
                Damageables.Add(nord);
                Damageables.Add(soldier);
                var zero = new Entity.Robot() { Name = "Zero", Health = 100, ArmorClass = 0, HitModifier = 10 };
                var geralt = new Entity.Witcher() { Name = "Geralt", Health = 100, ArmorClass = 0, HitModifier = 10 };
                var kratos = new Entity.Spartan() { Name = "Kratos", Health = 100, ArmorClass = 0, HitModifier = 10 };
                Damagers.Add(zero);
                Damagers.Add(geralt);
                Damagers.Add(kratos);
            }

            public void Fight(Entity damager, Entity damageable)
            {
                //Calculate hit or miss
                var rand = new Random();
                int roll = rand.Next(1, 21);
                if (roll > 21 - (damager.HitModifier - damageable.ArmorClass));
                {
                    damageable.TakeDamage(20);
                    Console.WriteLine(damager.Name + " attacked " + damageable.Name);
                    Console.WriteLine(damageable.Health);
                }
            }
        }
    }
}

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
        public class Entity : IDamageable
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
                    return true;
                }
            }
            public class Ninja : Entity
            {
                public bool TakeDamage(int amount)
                {
                    return true;
                }
            }
            public class Nord : Entity
            {
                public bool TakeDamage(int amount)
                {
                    return true;
                }
            }
            public class Soldier : Entity
            {
                public bool TakeDamage(int amount)
                {
                    return true;
                }
            }
            public class Robot : Entity , IDamager
            {
                public int HitModifier
                {
                    get { return armorclass; }

                    set { armorclass = value; }
                }

                public bool TakeDamage(int amount)
                {
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
                    return true;
                }
            }
        }

        public class Combat
        {
            public void Start()
            {
                List<Entity> Damageables = new List<Entity>();
                var ezio = new Entity.Assassin() {Name = "Ezio", Health = 100, ArmorClass = 0};
                var scorpion = new Entity.Ninja() {Name = "Scorpion", Health = 100, ArmorClass = 0};
                var nord = new Entity.Nord() {Name = "Dovahkiin", Health = 100, ArmorClass = 0};
                var soldier = new Entity.Soldier() {Name = "Shepard", Health = 100, ArmorClass = 0};
                Damageables.Add(ezio);
                Damageables.Add(scorpion);
                Damageables.Add(nord);
                Damageables.Add(soldier);
                List<Entity> Damagers = new List<Entity>();
                var zero = new Entity.Robot() { Name = "Zero", Health = 100, ArmorClass = 0};
                var geralt = new Entity.Witcher() {Name = "Geralt", Health = 100, ArmorClass = 0};
                var kratos = new Entity.Spartan() {Name = "Kratos", Health = 100, ArmorClass = 0};
                Damagers.Add(zero);
                Damagers.Add(geralt);
                Damagers.Add(kratos);
            }

            public void Fight(Entity damager, Entity damageable)
            {
                //Calculate hit or miss
                damageable.TakeDamage(20);
            }
        }
    }
}

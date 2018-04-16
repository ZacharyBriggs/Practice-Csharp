using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.IntroToCsharp
{
    public abstract class Item
    {
        protected string Name { get; set; }
        protected int Id { get; set; }
    }

    public abstract class Weapon : Item
    {
        public int Power;

        public virtual void DoDamage(int amount)
        {

        }
    }

    public class BusterSword : Weapon
    {
        public BusterSword(int power)
        {
            this.Power = power;
        }
        public void Swing()
        {

        }

        public override void DoDamage(int amount)
        {
            base.DoDamage(amount);
        }
    }

    public class GatlingGun : Weapon
    {
        public GatlingGun(int power)
        {
            this.Power = power;
        }
        public void Shoot()
        {

        }
        public virtual void DoDamage(int amount)
        {

        }
    }

    public abstract class Potion : Item
    {
        protected int Power;

        protected virtual void Consume()
        {

        }
    }

    public class Ether : Potion
    {
        public Ether(int power)
        {
            this.Power = power;
        }
        protected virtual void Consume()
        {

        }

    }

    public class Elixir : Potion
    {
        public Elixir(int power)
        {
            this.Power = power;
        }
        protected virtual void Consume()
        {

        }
    }
}

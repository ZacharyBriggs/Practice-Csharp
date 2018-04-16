using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.IntroToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Item
    {
        protected string Name;
        protected int Id;
    }
    class Weapon
    {
        public int Power;

        public virtual void DoDamage(int amount)
        {

        }
    }
}

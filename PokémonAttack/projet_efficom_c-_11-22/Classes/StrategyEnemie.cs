using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_efficom_c__11_22.Classes
{
    internal class StrategyEnemie : IStrategy
    {
        public void Attack(Character c, FightCreator f)
        {
            int damage = f.Enemie.Attack();
            c.TakeDamage(damage);
            Console.WriteLine("\nEnemie attack you for " + damage + " damage");
            c.ShowStats();
        }
    }
}

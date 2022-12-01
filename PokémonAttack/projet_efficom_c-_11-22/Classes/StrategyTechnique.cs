using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_efficom_c__11_22.Classes
{
    internal class StrategyTechnique : IStrategy
    {
        public void Attack(Character c, FightCreator f)
        {
            int damage = f.Technique.Attack();
            f.Enemie.TakeDamage(damage);
            Console.WriteLine("\nYou attack the enemie with your technique for " + damage + " damage");
            f.Enemie.ShowStats();
        }
    }
}

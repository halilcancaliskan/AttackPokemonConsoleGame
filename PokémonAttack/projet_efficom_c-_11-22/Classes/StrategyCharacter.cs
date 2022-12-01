using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_efficom_c__11_22.Classes
{
    internal class StrategyCharacter : IStrategy
    {

        public void Attack(Character c, FightCreator f)
        {
            int damage = f.Weapon.Attack();
            f.Enemie.TakeDamage(damage);
            Console.WriteLine("\nYou attack the enemie for " + damage + " damage");
            f.Enemie.ShowStats();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_efficom_c__11_22.Classes
{
    internal interface IStrategy
    {
        void Attack(Character c, FightCreator f);
    }
}

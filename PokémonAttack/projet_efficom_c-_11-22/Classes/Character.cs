using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_efficom_c__11_22.Classes
{
    internal class Character
    {
        protected static Character? instance = null;
        protected int life;

        protected Character()
        {
            life = 200;
        }

        public static Character Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Character();
                }
                return instance;
            }
        }

        public int Life
        {
            get { return life; }
            set { life = value; }
        }

        public void TakeDamage(int damage)
        {
            life -= damage;
        }

        public void ShowStats()
        {
            if (life > 0)
            {
                Console.WriteLine("You have " + life + " life left");
            }
            else
            {
                Console.WriteLine("You are dead");
            }
        }
    }
}

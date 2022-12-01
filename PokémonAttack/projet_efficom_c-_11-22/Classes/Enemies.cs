using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_efficom_c__11_22.Classes
{
    // Orc;life=20;Min=1;Max=20
    internal class Enemies : IFightTrait
    {
        private string name;
        private int min;
        private int max;
        private int life;

        public Enemies(string name, int life, int min, int max)
        {
            this.name = name;
            this.life = life;
            this.min = min;
            this.max = max;
            this.PresentMe();
        }

        public static Enemies Create()
        {
            string weaponLine = Utils.RandomSelectInFile(@"../../../Conf/Fichier_texte_ennemis.txt");
            string[] weaponLineSplit = weaponLine.Split(';');
            string name = weaponLineSplit[0];
            int life = int.Parse(weaponLineSplit[1].Split('=')[1]);
            int min = int.Parse(weaponLineSplit[2].Split('=')[1]);
            int max = int.Parse(weaponLineSplit[3].Split('=')[1]);
            return new Enemies(name, life, min, max);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Min
        {
            get { return min; }
            set { min = value; }
        }

        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public int Life
        {
            get { return life; }
            set { life = value; }
        }

        public int Attack()
        {
            Random random = new Random();
            int damage = random.Next(min, max);
            return damage;
        }
        
        public void TakeDamage(int damage)
        {
			life -= damage;
        }

        public void ShowStats()
        {
            if (life > 0)
            {
                Console.WriteLine("The " + name + " has " + life + " life left");
            }
            else
            {
                Console.WriteLine("The " + name + " is dead");
            }
        }

        private void PresentMe() {
            Console.WriteLine("--==###==--\n");
            Console.WriteLine("A " + name + " appear");
            Console.WriteLine("It have " + life + " HP");
        }
    }
}

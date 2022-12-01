using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_efficom_c__11_22.Classes
{
    // use FightTrait interface
    internal class Weapons : IFightTrait
    {
        private string name;
        private int min;
        private int max;

    

        public Weapons(string name, int min, int max)
        {
            this.name = name;
            this.min = min;
            this.max = max;
        }
        public static Weapons Create()
        {
            string weaponLine = Utils.RandomSelectInFile(@"../../../Conf/Fichier_texte_armes.txt");
            string[] weaponLineSplit = weaponLine.Split(';');
            string name = weaponLineSplit[0];
            int min = int.Parse(weaponLineSplit[1].Split('=')[1]);
            int max = int.Parse(weaponLineSplit[2].Split('=')[1]);
            return new Weapons(name, min, max);
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

        public int Attack()
        {
            Random random = new Random();
            int damage = random.Next(min, max);
            return damage;
        }
    }
}

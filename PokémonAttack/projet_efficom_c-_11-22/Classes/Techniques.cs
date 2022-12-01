using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_efficom_c__11_22.Classes
{
    // Coup brutal;Puissance=2;Epee
    internal class Techniques : IFightTrait
    {
        private string name;
        private int min;
        private int max;

        public Techniques(string name, int min, int max)
        {
            this.name = name;
            this.min = min;
            this.max = max;
        }

        public static Techniques Create(Weapons w)
        {
            string techniqueLine = Utils.RandomSelectInFileBetweenWeaponLine(@"../../../Conf/Fichier_texte_techniques.txt", w.Name);
            string[] techniqueLineSplit = techniqueLine.Split(';');
            string name = techniqueLineSplit[0];
            int min = (int)(Convert.ToDouble(techniqueLineSplit[1].Split('=')[1].Replace('.', ',')) * w.Min);
            int max = (int)(Convert.ToDouble(techniqueLineSplit[1].Split('=')[1].Replace('.', ',')) * w.Max);
            return new Techniques(name, min, max);
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

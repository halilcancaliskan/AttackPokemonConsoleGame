using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_efficom_c__11_22.Classes
{
    internal class FightCreator
    {
        private Weapons weapon;
        private Enemies enemie;
        private Techniques? technique;

        public FightCreator()
        {
            this.CreateWeapon();
            this.CreateEnemie();
            if(Utils.WeaponPresentInFile(weapon.Name)) 
            {
                this.CreateTechnique();
            }
            else
            {
                this.technique = null;
            }
        }

        public Weapons Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public Enemies Enemie
        {
            get { return enemie; }
            set { enemie = value; }
        }

        public Techniques Technique
        {
            get { return technique; }
            set { technique = value; }
        }

        private void CreateEnemie() // Sorcier;PdV=40;Min=10;Max=60
        {
            this.enemie = Enemies.Create();
        }

        private void CreateWeapon()
        {
            this.weapon = Weapons.Create();
        }

        private void CreateTechnique()
        {
            this.technique = Techniques.Create(weapon);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_efficom_c__11_22.Classes
{
    internal class Context
    {
        private IStrategy strategy;
        private FightCreator fight;
        private bool technicIsUsed;
        

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
            this.fight = null;
            this.technicIsUsed = false;
        }
        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void Fight(Character c)
        {
            strategy.Attack(c, this.fight);
        }

        public void ResetFight()
        {
            this.technicIsUsed = false;
            this.fight = new FightCreator();
            this.strategy = new StrategyEnemie();
            this.ShowTraits();
        }

        public void AskTechnique()
        {
            Console.WriteLine("\nDo you want to use a technique ? (y/n)");
            string answer = "";
            do
            {
                if (answer != "")
                {
                    Console.WriteLine("Please answer with y or n");
                }
                answer = Console.ReadLine();
            } while (answer != "y" && answer != "n");
            if (answer == "y")
            {
                this.SetStrategy(new StrategyTechnique());
                this.TechnicIsUsed = true;
            }
            else
            {
                {
                    this.SetStrategy(new StrategyCharacter());
                }
            }
        }

        private void ShowTraits()
        {
            Console.WriteLine("\nYour weapon: " + fight.Weapon.Name + " (Min:" + fight.Weapon.Min + " - Max:" + fight.Weapon.Max + ")");
            if (fight.Technique != null)
            {
                Console.WriteLine("Your technique: " + fight.Technique.Name + " (Min:" + fight.Technique.Min + " - Max:" + fight.Technique.Max + ")");
            }
        }

        public IStrategy Strategy { get => strategy; set => strategy = value; }

        public bool TechnicIsUsed { get => technicIsUsed; set => technicIsUsed = value; }

        public FightCreator FightCreator { get => fight; set => fight = value; }
    }
}

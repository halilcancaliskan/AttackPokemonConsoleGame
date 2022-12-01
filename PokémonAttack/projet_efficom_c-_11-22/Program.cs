/*
// Example #2
// Read each line of the file into a string array. Each element
// of the array is one line of the file.
using projet_efficom_c__11_22.Classes;

string[] lines = System.IO.File.ReadAllLines(@"../../../Conf/Fichier_texte_armes.txt");

// Display the file contents by using a foreach loop.
System.Console.WriteLine("Contents of WriteLines2.txt = ");
foreach (string line in lines)
{
    // Use a tab to indent each line of the file.
    Console.WriteLine("\t" + line);
}

// Keep the console window open in debug mode.
Console.WriteLine("Press any key to exit.");
System.Console.ReadKey();*/

using projet_efficom_c__11_22.Classes;


Context context = new Context(new StrategyEnemie());

while (Character.Instance.Life > 0)
{
    context.ResetFight();
    do
    {
        if (context.Strategy is StrategyCharacter || context.Strategy is StrategyTechnique)
        {
            context.SetStrategy(new StrategyEnemie());
        }
        else if (context.Strategy is StrategyEnemie)
        {
            if (context.FightCreator.Technique != null && !context.TechnicIsUsed)
            {
                context.AskTechnique();
            }
            else
            {
                context.SetStrategy(new StrategyCharacter());
            }
        }
        context.Fight(Character.Instance);
        Utils.PressEnterToContinue();
    } while (context.FightCreator.Enemie.Life > 0 && Character.Instance.Life > 0);
}


/*
Console.WriteLine(fightCreator.Weapon.Name);
Console.WriteLine(fightCreator.Enemie.Name);
if (fightCreator.Technique != null)
{
    Console.WriteLine(fightCreator.Technique.Name);
    Console.WriteLine(fightCreator.Technique.Min);
    Console.WriteLine(fightCreator.Technique.Max);
}
Console.WriteLine(Character.Instance.Life);*/

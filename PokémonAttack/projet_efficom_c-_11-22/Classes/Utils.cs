using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_efficom_c__11_22.Classes
{
    internal class Utils
    {
        public static string RandomSelectInFile(string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            int linesCount = lines.Count();

            Random random = new Random();
            int randomNumber = random.Next(0, linesCount);
            return lines[randomNumber];
        }

        public static bool WeaponPresentInFile(string weaponName)
        {
            {
                string[] lines = System.IO.File.ReadAllLines(@"../../../Conf/Fichier_texte_techniques.txt");
                foreach (string l in lines)
                {
                    if (l.Contains(weaponName))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public static string RandomSelectInFileBetweenWeaponLine(string fileName, string weaponName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            int linesCount = lines.Count();

            Random random = new Random();
            int randomNumber = -1;
            do
            {
                randomNumber = random.Next(0, linesCount);
            } while (!lines[randomNumber].Contains(weaponName));
            return lines[randomNumber];
        }

        public static void PressEnterToContinue()
        {
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}

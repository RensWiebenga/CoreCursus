using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WardrobeCursus
{
    public class Kid
    {
        public string name { get; set; }
        public int age { get; set; }
        public bool caught { get; set; }
        
        public bool Kick ()
        {
            caught = false;
            Random rndCaught = new Random();
            int rndCaughtNumber = rndCaught.Next(0, 10);
            if (rndCaughtNumber == 5)
            {
                caught = true;
            }
            if(caught == true)
            {
                Console.WriteLine($"{name} was caught and he needs to wait 1 sec instead of 10 because 10 seconds is cruel and unusual punishment");
                Thread.Sleep(10);
                return true;
            }
            else
            {
                Console.WriteLine($"The wardrobe was kicked by {name}");
            }

            Random rndLocked = new Random();
            int rndLockedNumber = rndLocked.Next(0, 3);

            if (rndLockedNumber == 2)
            {
                StaticWardrobe.Instance.isLocked = false;
                Console.WriteLine($"The wardrobe is now unlocked");
            }
            else
            {
                StaticWardrobe.Instance.isLocked = true;
                Console.WriteLine($"The wardrobe is still locked");
            }
            return(caught);

        }
        public void Open()
        {
            StaticWardrobe.Instance.OpenDoor(name);
            return;
        }
        public void StepInNarnia(Fight fight)
        {
            fight.changeOfWinning++;
            Console.WriteLine($"Chance of winning is: {fight.changeOfWinning} %");
            Console.WriteLine($"{name} stepped into NARNIA********************************************************************");
            Console.WriteLine($"{name} found the witch");
            Console.WriteLine($"{name} fights the witch");

            fight.percentages.Add(fight.changeOfWinning);

            

            Random rndWinFight = new Random();
            int rndWinFightNumber = rndWinFight.Next(0, 100);

            foreach (int number in fight.percentages)
            {
                if (number == rndWinFightNumber)
                {
                    fight.isBeaten = true;
                }
            }
            
            if (fight.isBeaten)
            {
                Console.WriteLine("           THE WITCH IS NOW DEAD");
                Console.WriteLine("");
                Console.WriteLine("            **********  ******");
                Console.WriteLine("        **************************");
                Console.WriteLine("      * *****************************");
                Console.WriteLine("    * ***    ****            ****    **");
                Console.WriteLine("    * ***  ****                ****  **");
                Console.WriteLine("  * *********                    ********");
                Console.WriteLine("  * *********  ****        ****  ********");
                Console.WriteLine("* ***********      **    **      ********");
                Console.WriteLine("* ***********      **    **      ********");
                Console.WriteLine("* ***********      **    **    **********");
                Console.WriteLine("* *************    ********    **********");
                Console.WriteLine("  * ***********        **      ********");
                Console.WriteLine("    * ***********    ******  **********");
                Console.WriteLine("    * ***************      ************");
                Console.WriteLine("      * *************      **********");
                Console.WriteLine("        * *************************");
                Console.WriteLine("            * *******************");
                Console.WriteLine("                * *************");
                Console.WriteLine("                  * *********");
                Console.WriteLine("                      * ***");
                Console.WriteLine("");
                Console.WriteLine("Aslan thanks you and makes a cunning remark about you being very deep in the closet");
                
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            };
            

            return;
        }
        public void StepInRegularWardrobe()
        {
            Console.WriteLine($"{name} stepped into a very boring wardrobe");
            return;
        }
        public void StepOut()
        {
            Console.WriteLine($"{name} stepped out of the wardrobe");
            return;
        }
        public void Close()
        {
            StaticWardrobe.Instance.isLocked = true;
            StaticWardrobe.Instance.CloseDoor(name);
            return;
        }
    }
}

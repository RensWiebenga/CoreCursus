using System;
using System.Collections.Generic;
using System.Threading;

namespace WardrobeCursus
{

    class Program
    {

        static void Main(string[] args)
        {
            var Jimmy = new Kid()
            {
                name = "Jimmy",
                age = 12
            };
            var Karen = new Kid()
            {
                name = "Karen",
                age = 14
            };
            var Liberace = new Kid()
            {
                name = "Liberace",
                age = 15
            };
            var Greg = new Kid()
            {
                name = "Greg",
                age = 18
            };

            List<Kid> kids = new List<Kid>() { Jimmy, Karen, Liberace, Greg};
            var caught = false;

            var fight = new Fight();
            fight.changeOfWinning = 2;
            
            
            while (fight.isBeaten == false)
            {
                
                foreach (var kid in kids)
                {

                    for (var i = 0; i < 25; i++)
                    {
                        if(fight.isBeaten == false)
                        {
                            caught = kid.Kick();
                            if (caught == false)
                            {
                                if (StaticWardrobe.Instance.isLocked == false)
                                {
                                    kid.Open();
                                    Random rndNarnia = new Random();
                                    int rndNarniaNumber = rndNarnia.Next(0, 42);
                                    if (rndNarniaNumber == 30)
                                    {
                                        kid.StepInNarnia(fight);
                                    }
                                    else
                                    {
                                        kid.StepInRegularWardrobe();
                                    }
                                    kid.StepOut();
                                    kid.Close();
                                }
                                Console.WriteLine("____________________________");
                            }
                            else
                            {
                                Console.WriteLine("____________________________");
                                Console.WriteLine("Another kid can give it a go");
                                Console.WriteLine("____________________________");
                                caught = true;
                                break;
                            }
                        }
                    }


                }
            }
            

            

        }
    }
}

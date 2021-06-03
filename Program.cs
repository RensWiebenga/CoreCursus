using System;
using System.Threading;

namespace WardrobeCursus
{

    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var myWardrobe = new Wardrobe()
            //{
            //    Material = "wood",
            //    AmountDoors = 1
            //};
            //myWardrobe.OpenDoor();
            //myWardrobe.OpenDoor();
            //myWardrobe.OpenDoor();

            StaticWardrobe.Instance.Material = "wood";
            StaticWardrobe.Instance.AmountDoors = 1;
            StaticWardrobe.Instance.OpenDoor();
            StaticWardrobe.Instance.OpenDoor();
            StaticWardrobe.Instance.CloseDoor();
            StaticWardrobe.Instance.CloseDoor();

        }
    }
}

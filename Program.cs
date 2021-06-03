using System;
using System.Threading;

namespace WardrobeCursus
{

    class Program
    {

        static void Main(string[] args)
        {
            StaticWardrobe.Instance.Material = "wood";
            StaticWardrobe.Instance.AmountDoors = 1;
            StaticWardrobe.Instance.OpenDoor();
            StaticWardrobe.Instance.OpenDoor();
            StaticWardrobe.Instance.CloseDoor();
            StaticWardrobe.Instance.CloseDoor();

        }
    }
}

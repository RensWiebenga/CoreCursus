using Microsoft.Azure.Amqp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeCursus
{
    class Wardrobe
    {
        public string Material { get; set; }
        public int AmountDoors { get; set; }
    }

    public class StaticWardrobe
    {
        public bool isLocked { get; set; }
        public string Material { get; set; }
        public int AmountDoors { get; set; }

        private static StaticWardrobe instance = new StaticWardrobe();
 
        private StaticWardrobe()
        {
        }

        public static StaticWardrobe Instance
        {
            get
            {
                return instance;
            }
        }

        public void OpenDoor(string name)
        {
            Console.WriteLine($"The door was opened by {name}");
            return;
        }

        public void CloseDoor(string name)
        {
            Console.WriteLine($"The door was close by {name}");
            return;
        }
    }
}

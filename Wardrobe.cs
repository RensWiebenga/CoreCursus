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
        public static bool _isDoorOpen;
        public string Material { get; set; }
        public int AmountDoors { get; set; }

        public void OpenDoor ()
        {

            if (_isDoorOpen)
            {
                Console.WriteLine($"the door was already open and the Material is { Material }");
            }
            else
            {
                Console.WriteLine("I've opened the door");
                _isDoorOpen = true;
            }
            
            return;
        }

    }

    public class StaticWardrobe
    {
        public static bool _isDoorOpen;
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

        public void OpenDoor()
        {
            if (_isDoorOpen)
            {
                Console.WriteLine($"the door was already open and the Material is { Material }");
            }
            else
            {
                Console.WriteLine("I've opened the door");
                _isDoorOpen = true;
            }
            return;
        }

        public void CloseDoor()
        {
            if (_isDoorOpen)
            {
                Console.WriteLine($"I've closed the door");
                _isDoorOpen = false;
            }
            else
            {
                Console.WriteLine("It was already closed");
                
            }
            return;
        }
    }
}

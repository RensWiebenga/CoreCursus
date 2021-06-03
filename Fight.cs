using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeCursus
{
    public class Fight
    {
        public bool isBeaten { get; set; }
        public int changeOfWinning { get; set; }
        public List<int> percentages = new List<int>() { 1, 2 };
    }
}

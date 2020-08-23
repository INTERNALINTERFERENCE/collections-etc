using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Constructors
    {
        private int _args { get; set; } = 100;
        private string race;

        public Constructors()
        {
            race = "human";
        }

        public Constructors(int args)
        {
            _args = args;
            if (args > 100)
                race = "orc";
            race = "human";
        }
    }
}

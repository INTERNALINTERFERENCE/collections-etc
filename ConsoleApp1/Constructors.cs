using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Constructors
    {
        private string race { get; set; }

        public Constructors()
        {
            race = "human";
        }

        public Constructors(int args)
        {
            if (args > 100)
                race = "orc";
            race = "human";
        }
    }
}

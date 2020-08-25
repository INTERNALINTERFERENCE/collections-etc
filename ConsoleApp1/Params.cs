using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Params
    {
        public double Average(params int[] numbers)
        {
            double sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Palindrome
    {
        //1001
        public void checkPalindrome(string number)
        {
            string value1 = null;
            string value2 = null;

            for (int i = 0; i < number.Length; i++)
            {
                value1 += number[i];
                
            }

            for(int q = number.Length; q > 0; q--)
            {
                value2 += number[q - 1];
            }


            string result = value1 == value2 ? "Yes, it's a Palindrome" : "No, it's not a Palindrome";
            Console.WriteLine(result);
        }      
        
        public void checkPalindrome_v2(string number)
        {
            string result = isPolindrome(number) ? "Yes, it's a Palindrome" : "No, it's not a Palindrome";
            Console.WriteLine(result);
        }

        private bool isPolindrome(string input)
        {
            int halfLength = input.Length / 2;
            for (int i = 0; i < halfLength; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absolute_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int number1 = 6832;
                int number2 = -392;

                int absoluteValue1 = AbsoluteValue(number1);
                int absoluteValue2 = AbsoluteValue(number2);

                Console.WriteLine($"Absolute value of {number1} is {absoluteValue1}");
                Console.WriteLine($"Absolute value of {number2} is {absoluteValue2}");
            Console.ReadLine();
        }

            static int AbsoluteValue(int number)
            {
                if (number < 0)
                {
                    return -number;
                }
                else
                {
                    return number;
                }
            }
     
    }
}

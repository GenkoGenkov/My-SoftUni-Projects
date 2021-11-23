using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] valuesToConvert = { "5.34", "16.85", "1.ash", "asfs", "-8.64", "4", "780000000" };

            foreach (var item in valuesToConvert)
            {
                try
                {
                    double forced = Math.Pow(Convert.ToDouble(item), 35);

                    if (double.IsNegativeInfinity(forced) || double.IsPositiveInfinity(forced))
                    {
                        throw new OverflowException("Value is greater than max value or lower than min value");
                        
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikeWay
{
    internal class ValidationMethods
    {

        string text;
        /// <summary>
        /// Method to valid correct double user input
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double DoubleValid(double number)
        {
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please enter correct number or decimal number: ");
            }
            return number;
        }
        /// <summary>
        /// Method to valid if input string is not null or empty
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public string EmptyStringValid(string txt)
        {
            
            while (string.IsNullOrEmpty(txt = Console.ReadLine().ToLower().Trim()))
            {
                Console.WriteLine("Input cannot be empty, please enter again: ");
            }
            return txt;
        }
        /// <summary>
        /// Method to valid correct string user input
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public string StringValid(string txt)
        {

            while (string.IsNullOrEmpty(txt = Console.ReadLine().ToLower().Trim()))
            {
                Console.WriteLine("Please enter correct text: ");
            }
            return txt;
        }
    }
}

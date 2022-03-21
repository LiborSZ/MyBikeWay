using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikeWay
{
    internal class ValidationMethods
    {
        public double DoubleValid(double number)
        {
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please enter correct number: ");
            }
            return number;
        }

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

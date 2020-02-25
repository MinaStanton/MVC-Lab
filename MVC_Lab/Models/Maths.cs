using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Lab.Models
{
    public class Maths
    {



        public static string Add(int num1, int num2)
        {
            int total = num1 + num2;
            return total.ToString();
        }

        public static string Divide(int num1, int num2)
        {
            double quotient = num1 / num2;
            double remainder = num1 % num2;

            return $"{quotient} with a remainder of {remainder}";
        }
    }
}

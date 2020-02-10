using System;
using System.Collections.Generic;
using System.Text;

namespace Disemvowel_Trolls
{
    public class SquareEveryDigit
    {
        // Clumsy code but with too many explicit conversions. Atleast implemented a string builder to reduce overhead
        // Code needs refactorying
        
        public static int SquareDigits(int n)
        {
            var sb = new StringBuilder();
            foreach(var number in n.ToString())
            {
                var newNumber = Int32.Parse(number.ToString());
                var sum = newNumber * newNumber;
                sb.Append(sum.ToString());
            }

            return Int32.Parse(sb.ToString());
        }

    }
}

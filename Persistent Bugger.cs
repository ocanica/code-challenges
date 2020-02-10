using System;
using System.Collections.Generic;
using System.Text;

namespace Disemvowel_Trolls
{
    public class Persistent_Bugger
    {
        // Unable to complete challenge. Unable to track the number of recursive calls. Exit condition is too obtuse.
        // Can potentially call the recursive function within the foreach loop and use a counter variable to track the number of calls
        public static int Persistence(long n)
        {
            var sum = 1;
            var numbers = n.ToString();
            if (numbers.Length < 2)
                return 0;

            foreach(var number in numbers)
            {
                sum *= int.Parse(number.ToString());
            }

            return Persistence(sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Disemvowel_Trolls
{
    public class Your_Order_Please
    {
        // Need to refactor to incorporate char.IsDigit(), would make identifing digit easier
        // Did not use string.Contains() as this only returns a boolean value
        public static string Order(string str)
        {
            var strArr = str.Split(' ');
            var numbers = "123456789";
            var newStrArr = new string[strArr.Length];
            foreach(var word in strArr)
            {
                foreach(var letter in word)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (letter == numbers[i])
                            newStrArr[int.Parse(numbers[i].ToString())-1] = word;
                    }
                }
            }
            return string.Join(" ", newStrArr);
        }
    }
}

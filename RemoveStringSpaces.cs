using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            static string NoSpace(string input)
            {
                string result = "";
                foreach(var letter in input)
                {
                    if (letter != ' ')
                        result += letter;
                }
                return result;
            }
        }
    }
}

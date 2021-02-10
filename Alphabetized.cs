using System;

namespace Alphabetized
{
    public static class Sort
    {
        //Write a method to return a string in alphabetical order.
        public static string StringSort(string inputString)
        {
            // "cat" => "act"

            string outputString = "";

            for(char i = 'A'; i <= 'z'; i++)
            {
                for(int y = 0; y < inputString.Length ; y++)
                {
                    if(inputString[y] == i)
                    {
                        outputString += inputString[y];
                    }
                }
            }

            return outputString;
        }
    }
}

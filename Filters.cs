using System;
using System.Collections.Generic;
using System.Text;

namespace WhiteboardEx_SD9
{
    public class Filters
    {
        public static bool StringContains(string little, string big)
        {
            // input validation
            if (string.IsNullOrEmpty(little) || string.IsNullOrEmpty(big)) return false;

            //String placeholders
            string SS; // Search String 
            string ST; // Search Target


            // checks size of the strings together, assigns the smaller string to the search string.
            // if strings equal size, then comparison is made no need to go any further.
            if(little.Length == big.Length)
            {
                if (little == big)
                {
                    return true;
                }
                return false;
            }
            if (little.Length < big.Length)
            {
                SS = little.ToUpper();
                ST = big.ToUpper();
            } else
            {
                SS = big.ToUpper();
                ST = little.ToUpper();
            }

            //Begin searching for first letter.
            for (int i = 0; i < ST.Length ; i++ )
            {
                //Check to see if length of string can still be contained, if not return false.
                //Prevents going out of bounds inside second array.
                if (ST.Length - i < SS.Length)
                {
                    return false;
                }
                if (SS[0] != ST[i])
                {
                    continue;
                }
                // Checks char before word, to ensure its the START of the word.
                if(i > 0)
                {
                    if(ST[i - 1] != ' ')
                    {
                        continue;
                    }
                }
                // If it finds the first letter, find the rest of the word. Returns true.
                for (int y = 0; y < SS.Length ; y++)
                {
                    if (SS[y] != ST[i + y]) break;
                    //Checks if its end of word or string in the search string.
                    if (y == SS.Length - 1)
                    {
                        //Checks to see if it's the end of the first string, keeps second if statement from going out of bounds.
                        if(i + SS.Length == ST.Length)
                            return true;
                        if (ST[i + SS.Length] == ' ')
                            return true;
                    }
                }
            }
            // If it goes through the entire string, no match return false.
            return false;
        }
    }
}

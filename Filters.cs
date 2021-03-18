using System;
using System.Collections.Generic;
using System.Text;

namespace WhiteboardEx_SD9
{
    public class Filters
    {
        // First attempt
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

        // This method simply uses the helper method "contains" with some input validation
        // to return a true or false value.
        // Decided to stop looking here as Contains() does not care about word beginning or ending,
        // EX will return true for "Fox" in "Foxtrot".
        public static bool StringContains2(string little, string big)
        {
            

            // input validation
            if (string.IsNullOrEmpty(little) || string.IsNullOrEmpty(big)) return false;

            //String placeholders
            string SS; // Search String 
            string ST; // Search Target


            // checks size of the strings together, assigns the smaller string to the search string.
            // if strings equal size, then comparison is made no need to go any further.
            if (little.Length == big.Length)
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
            }
            else
            {
                SS = big.ToUpper();
                ST = little.ToUpper();
            }

            return ST.Contains(SS);
        }

        //Made improvements to the first StringContains Method
        public static bool StringContains3(string little, string big)
        {
            // input validation
            if (string.IsNullOrEmpty(little) || string.IsNullOrEmpty(big)) return false;

            //String placeholders
            string SS; // Search String 
            string ST; // Search Target

            // checks size of the strings together, assigns the smaller string to the search string.
            // if strings equal size, then comparison is made no need to go any further.
            if (little.Length == big.Length)
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
            }
            else
            {
                SS = big.ToUpper();
                ST = little.ToUpper();
            }

            //Begin searching for first letter.
            for (int i = 0; i < ST.Length; i++)
            {
                // Checks char before word, to ensure its the START of the word.
                if (i > 0 && ST[i - 1] != ' ')
                {
                    continue;
                }
                //Check to see if length of string can still be contained, if not return false.
                //Prevents going out of bounds inside second array.
                if (ST.Length - i < SS.Length)
                {
                    return false;
                }
                
                // If it finds the first letter, find the rest of the word. Returns true.
                for (int y = 0; y < SS.Length; y++)
                {
                    if (SS[y] != ST[i + y]) break;
                    //Checks if its end of word or string in the search string.
                    if (y == SS.Length - 1)
                    {
                        // True return conditions.
                        if (i + SS.Length == ST.Length || ST[i + SS.Length] == ' ')
                            return true;
                    }
                }
            }
            // If it goes through the entire string, no match return false.
            return false;
        }

        // 4th attempt, wanted to try another method of finding a string.
        // Same method in theory as the first try, simply separating both strings into words and checking those together.
        // Won't find different chars inbetween words, ie: The!Fox and The Fox are the same in the eyes of Split().
        // Was fun to try, however I think my third attempt is the best for finding a string in a string.
        public static bool StringContains4(string little, string big)
        {
            // input validation
            if (string.IsNullOrEmpty(little) || string.IsNullOrEmpty(big)) return false;

            //String placeholders
            string SS; // Search String 
            string ST; // Search Target


            // checks size of the strings together, assigns the smaller string to the search string.
            // if strings equal size, then comparison is made no need to go any further.
            if (little.Length == big.Length)
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
            }
            else
            {
                SS = big.ToUpper();
                ST = little.ToUpper();
            }
            // Seperate target string into multiple smaller strings.
            string[] SSArr = SS.Split(' ' , '.' , '!' , '?' , ';' , ':' , '"');
            string[] STArr = ST.Split(' ' , '.' , '!' , '?' , ';' , ':' , '"');

            

            // Scan the first string array for the search string(s)
            for(int i = 0 ; i < STArr.Length ; i++)
            {
                if (SSArr[0] == STArr[i])
                {
                    for (int j = 0; j < SSArr.Length; j++)
                    {
                        if (SSArr[j] != STArr[i + j]) break;
                    }
                    return true;
                }
            }
            return false;
        }

        // String Length method we had in the mock whiteboarding session
        public static int StringLength(string input)
        {
            // Checks if empty and shaves extraneous spaces.
            if(string.IsNullOrEmpty(input)) return 0;
            string temp = input.Trim();

            int charCount = 0;

            foreach(char x in temp)
            {
                charCount++;
            }

            return charCount;
        }

        // Reverse string method we had in the mock whiteboarding session.
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";

            string output = "";

            for(int i = input.Length - 1; i >= 0 ; i--)
            {
                output += input[i];
            }

            return output;
        }

        // Longest word in string method we had in the mock whiteboarding session.
        public static string LongestWord(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";

            string output = "";

            string[]inputArr = input.Split(' ', '.', '!', '?', ';', ':', '"');

            foreach(string x in inputArr)
            {
                // For strings of the same length, keep the first string.
                // If I was to return all strings of the same length if they are the longest strings I would consider using an str array as return type to store them.
                if(x.Length > output.Length)
                {
                    output = x;
                }
            }
            return output;
        }

        public static bool IsPallendrone(string input)
        {
            // Input validation and trimming any extraneous spaces.
            if (string.IsNullOrEmpty(input)) return false; // First for input validation.
            input = input.Trim();
            if (string.IsNullOrEmpty(input)) return false; // Returns false if string is ONLY spaces. The trim would have left it empty.

            // Comparing each char from the beginning to the end.
            // Returns false if one is ever not equal.
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i].ToString().ToUpper() != input[input.Length - i - 1].ToString().ToUpper())
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CharInString(string cIn, string input)
        {
            // Input validation
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(cIn)) return false;
            if (cIn.Length > 1) return false;

            // Grabs first character for easier comparison.
            char c = cIn[0];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == c) return true;
            }
            return false;
        }
    }
}

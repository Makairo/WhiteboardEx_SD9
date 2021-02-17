using System;

namespace WhiteboardEx_SD9
{
    public class ToCase
    {
        //Method to return camel case string from input string.
        // "The Cat In The Hat" should return "theCatInTheHat"
        public static string CamelCase(string input)
        {
            string inputString = input.Trim();
            string outputString = "";
            char temp = ' ';
            string tempStr = " ";
            for (int i = 0;i<input.Length; i++)
            {
                
                    if (inputString[i] == ' ')
                    {
                        while(inputString[i] == ' ')
                        {
                            i++;
                        }
                        temp = inputString[i];
                        tempStr = temp.ToString();
                        tempStr = tempStr.ToUpper();
                        outputString += tempStr;
                        continue;
                    }
                    if (i != ' ')
                    {
                        temp = inputString[i];
                        tempStr = temp.ToString();
                        tempStr = tempStr.ToLower();
                        outputString += tempStr;
                        continue;
                    }
                
            }
            return outputString;
        }
        public static string PascalCase(string input)
        {
            string inputString = input.Trim();
            string outputString = "";
            char temp = ' ';
            string tempStr = " ";
            for (int i = 0; i < input.Length; i++)
            {
                if (i==0)
                {
                    temp = inputString[i];
                    tempStr = temp.ToString();
                    tempStr = tempStr.ToUpper();
                    outputString += tempStr;
                    continue;
                }
                if (inputString[i] == ' ')
                {
                    temp = inputString[i + 1];
                    tempStr = temp.ToString();
                    tempStr = tempStr.ToUpper();
                    outputString += tempStr;
                    i++;
                    continue;
                }
                if (i != ' ')
                {
                    temp = inputString[i];
                    tempStr = temp.ToString();
                    tempStr = tempStr.ToLower();
                    outputString += tempStr;
                    continue;
                }
            }
            return outputString;
        }
    }
}

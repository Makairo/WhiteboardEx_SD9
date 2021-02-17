using System;

namespace WhiteboardEx_SD9
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

        public static int[] sortArray(int[] inputArray)
        {
            int tempx = 0;
            int tempy = 0;
            bool sorted = true;
            // Will only exit when array is sorted.
            do
            {
                sorted = true;
                // Subtracting 2 here from length as I'm accessing the last value in the array when I process 
                // the index of length - 1, so the last value does not need to be processed.

                // Will only exit if an iteration of the for loop never runs the IF statement.
                for (int i = 0; i < inputArray.Length - 1; i++)
                {
                    if (inputArray[i] > inputArray[i + 1])
                    {
                        // Transferring values to temporary values, reassigning array.
                        tempx = inputArray[i];
                        tempy = inputArray[i + 1];
                        inputArray[i] = tempy;
                        inputArray[i + 1] = tempx;
                        sorted = false;
                    }
                }
            } while (sorted == false);


            foreach (int y in inputArray)
            {
                Console.Write($"{y} ");
            }
            Console.WriteLine("\n");

            return inputArray;
        }

        public static int[] mergeSortArray(int[] inputArray)
        {
            int sum = 0;
            int median;
            int numValues = inputArray.Length;
            bool sorted;
            int tempx;
            int tempy;

            int[] sortedArray = new int[numValues];

            foreach (int i in inputArray)
            {
                sum += i;
            }

            median = sum / numValues;

            int c1 = 0;
            int c2 = numValues - 1;
            foreach (int i in inputArray)
            {
                if (i <= median)
                {
                    sortedArray[c1] = i;
                    c1++;
                    continue;
                }
                if (i > median)
                {
                    sortedArray[c2] = i;
                    c2--;
                    continue;
                }
            }
            do
            {
                sorted = true;

                for (int i = 0; i < numValues - 1; i++)
                {
                    if (sortedArray[i] > sortedArray[i + 1])
                    {
                        // Transferring values to temporary values, reassigning array.
                        tempx = sortedArray[i];
                        tempy = sortedArray[i + 1];
                        sortedArray[i] = tempy;
                        sortedArray[i + 1] = tempx;
                        sorted = false;
                    }
                }
            } while (sorted == false);

            foreach (int y in sortedArray)
            {
                Console.Write($"{y} ");
            }
            Console.WriteLine("\n");

            return sortedArray;
        }
    }
}

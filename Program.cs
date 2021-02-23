using System;
using static WhiteboardEx_SD9.Sort;
using static WhiteboardEx_SD9.OddOrEven;
using static WhiteboardEx_SD9.ToCase;
using static WhiteboardEx_SD9.Primes;
using static WhiteboardEx_SD9.Filters;
using static WhiteboardEx_SD9.TupleMath;



namespace WhiteboardEx_SD9
{
    /*
            StringContains("Fox", "The Fox");
            StringContains("fox", "The Fox ran away.");
            exampleClass EX1 = new exampleClass(68, 722);

            (int xVal, int yVal) = EX1;

            Console.WriteLine($"{xVal}",yVal);
            int x = 100;
            Console.WriteLine("Whiteboard solutions container.");
            //DoWork();
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"\nInput: {i}, Prime: {IsPrime(i)}");
            }
            Console.WriteLine($"\nThe sum of primes from 2 to {x} is: {SumOfPrimes(x)}");

            int[] testArray = { 5,89,76,56,34,23,12,34,56,73,85,25,36,86,25,99,54,24,25,26,76,76,76,57,3,4,6,45,76,57,37,25,59};

            Console.WriteLine(sortArray(testArray));
            halfMergeSortArray(testArray);
    */
    class Program
    {

        static void Main(string[] args)
        {
            int[] testArray = { 5, 7, 2, 3, 4, 1 };
            Console.WriteLine(findInArray(4, testArray));
            getOperands();
        }
    }
}


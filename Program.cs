using System;
using static WhiteboardEx_SD9.Sort;
using static WhiteboardEx_SD9.OddOrEven;
using static WhiteboardEx_SD9.ToCase;
using static WhiteboardEx_SD9.Primes;



namespace WhiteboardEx_SD9
{

    class Program
    {
        static void DoWork()
        {
            Console.WriteLine("String sort method: \n");

            Console.WriteLine("Input: Andrew");
            Console.WriteLine($"Output: {StringSort("Andrew")}");

            Console.WriteLine("Input: ThisIsAString");
            Console.WriteLine($"Output: {StringSort("ThisIsAString")}");

            Console.WriteLine("\nOdd or Even methods: \n");
            Console.WriteLine("Input: 5");
            Console.WriteLine($"Output: {IsOdd(5)}");
            Console.WriteLine("Input: 6");
            Console.WriteLine($"Output: {IsOdd(6)}");
            Console.WriteLine("Input: 52");
            Console.WriteLine($"Output: {IsOdd(52)}");
            Console.WriteLine("Input: 101");
            Console.WriteLine($"Output: {IsOdd(101)}");

            Console.WriteLine("\nTo camelcase method: \n");
            Console.WriteLine("Input: This Is A String");
            Console.WriteLine($"Output: {CamelCase("This Is A String")}");
            Console.WriteLine("Input: I like using camel case");
            Console.WriteLine($"Output: {CamelCase("I like using camel case")}");

        }
        static void Main(string[] args)
        {
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

            int[] testArray = { 5,89,76,56,34,23,12,34,56,73,85,25,36,86,25,99,54,24,25,26,76,76,76,57};

            sortArray(testArray);
            mergeSortArray(testArray);
        }
    }
}


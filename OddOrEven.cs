using System;

namespace OddOrEven
{
    class OddOrEven
    {


        static bool IsOdd(int inputValue) => inputValue % 2 != 0;

        static bool IsEven(int inputValue) => inputValue % 2 == 0;


        static void Main(string[] args)
        {
            Console.WriteLine("OddOrEven Test!");

            for (int i = 0; i < 10; i++)
            {
                string result = "";
                if (IsEven(i)) result = "Even";
                if (IsOdd(i)) result = "Odd";
                Console.WriteLine($"{i} is {result}.");
            }
        }

        
    }
}

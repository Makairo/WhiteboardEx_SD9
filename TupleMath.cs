using System;
using System.Collections.Generic;
using System.Text;

namespace WhiteboardEx_SD9
{
    public class TupleMath
    {
        public static string userInput()
        {
            try
            {
                string userIn = "";
                userIn = Console.ReadLine();
                return userIn;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input was not valid: {ex.Message}. Please try again.");
                return userInput();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong, please try again. Message: {ex.Message}.");
                return userInput();
            }
        }
        public static Tuple<int, int> getOperands()
        {
            try
            {
                Console.WriteLine("Enter first operand: ");
                int x = checked(Int32.Parse(userInput()));
                Console.WriteLine("Enter second operand: ");
                int y = checked(Int32.Parse(userInput()));
                return Tuple.Create(x, y);
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return getOperands();
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return getOperands();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return getOperands();
            }
        }
        public static int doAddition(Tuple<int, int> operand)
        {
            try
            {

                return checked(operand.Item1 + operand.Item2);
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return doAddition(getOperands());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return doAddition(getOperands());
            }
        }
        public static int doSubtraction(Tuple<int, int> operand)
        {
            try
            {

                return checked(operand.Item1 - operand.Item2);
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return doSubtraction(getOperands());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return doSubtraction(getOperands());
            }
        }
        public static int doMultiplication(Tuple<int, int> operand)
        {
            try
            {

                return checked(operand.Item1 * operand.Item2);
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return doMultiplication(getOperands());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return doMultiplication(getOperands());
            }
        }
        public static int doDivision(Tuple<int, int> operand)
        {
            try
            {
                return checked(operand.Item1 / operand.Item2);
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return doDivision(getOperands());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return doDivision(getOperands());
            }
        }
        public static int doRemainder(Tuple<int, int> operand)
        {
            try
            {
                return checked(operand.Item1 % operand.Item2);
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return doRemainder(getOperands());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return doRemainder(getOperands());
            }
        }
        public static Tuple<int, int> checkForZero(Tuple<int, int> operand)
        {
            try
            {
                // Grabs second value, checks for divide by zero.
                int y = operand.Item2;
                while (y == 0)
                {
                    Console.WriteLine("Cannot divide by zero. Input new value for second operand: ");
                    y = checked(int.Parse(Console.ReadLine()));
                }
                //Will repeat as long as y == 0, then reassigns the tuple to the ajusted value.
                return Tuple.Create(operand.Item1, y);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return checkForZero(operand);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return checkForZero(operand);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}. Please try again.");
                return checkForZero(operand);
            }
        }
    }
}

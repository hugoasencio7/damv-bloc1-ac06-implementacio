using System;
namespace SumTwoNumbers
{
    public class SumTwoNumbers
    {
        public static void Main()
        {
            // PRECONDITION: The user is prompted to input two integers.

            const string MSG_INPUT1 = "Enter the first integer: ";
            const string MSG_INPUT2 = "Enter the second integer: ";
            const string MSG_RESULT = "The sum is: ";

            int num1, num2, sum;

            Console.WriteLine(MSG_INPUT1);
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MSG_INPUT2);
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;

            Console.WriteLine(MSG_RESULT + sum);

            // POSTCONDITION: 'sum' contains the sum of 'num1' and 'num2', and it is
            // displayed.
        }
    }
}

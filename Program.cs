using System;

public class Program
{
    public static void Main()
    {
        /*The user is prompted to input three real numbers.*/
        const string MSG_INPUT1 = "Enter the first number:";
        const string MSG_INPUT2 = "Enter the second number:";
        const string MSG_INPUT3 = "Enter the third number:";
        const string MSG_RESULT = "The average is:";

        double num1, num2, num3, average;

        Console.WriteLine(MSG_INPUT1);
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(MSG_INPUT2);
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(MSG_INPUT3);
        num3 = Convert.ToDouble(Console.ReadLine());
        average = (num1 + num2 + num3) / 3;
        Console.WriteLine(MSG_RESULT + " " + average);
        /*'average' contains the arithmetic mean of the three numbers, and it is displayed.*/
    }
}
using System;

public class Program
{
    public static void Main()
    {
        /*The user is prompted to input an amount in euros.*/
        const double exchange_rate = 1.12;
        const string MSG_INPUT = "Enter amount in euros:";
        const string MSG_RESULT = "Amount in euros:";

        double euros, dollars;

        Console.WriteLine(MSG_INPUT);
        euros = Convert.ToDouble(Console.ReadLine());
        dollars = euros * exchange_rate;
        Console.WriteLine(MSG_RESULT + " " + dollars);
        /*'dollars' contains the converted amount, and it is displayed.*/
    }
}
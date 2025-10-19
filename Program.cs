using System;

public class Program
{
    public static void Main()
    {
        /*The user is prompted to input a temperature in Celsius.*/
        const string MSG_INPUT = "Enter temperature in Celsius:";
        const string MSG_RESULT = "Temperature in Kelvin:";

        double celsius, kelvin;

        Console.WriteLine(MSG_INPUT);
        celsius = Convert.ToDouble(Console.ReadLine());
        kelvin = celsius + 273.15;
        Console.WriteLine(MSG_RESULT + " " + kelvin);
        /*'kelvin' contains the converted temperature, and it is displayed.*/
    }
}
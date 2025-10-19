using System;

public class Program
{
    public static void Main()
    {
        /*The user is prompted to input the width and height of a rectangle.*/
        const string MSG_INPUT_WIDTH = "Enter the width of the rectangle:";
        const string MSG_INPUT_HEIGHT = "Enter the height of the rectangle:";
        const string MSG_RESULT = "The area of the rectangle is:";

        double width, height, area;

        Console.WriteLine(MSG_INPUT_WIDTH);
        width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(MSG_INPUT_HEIGHT);
        height = Convert.ToDouble(Console.ReadLine());
        area = width * height;
        Console.WriteLine(MSG_RESULT + " " + area);
        /*'area' contains the product of 'width' and 'height' and it is displayed*/
    }
}
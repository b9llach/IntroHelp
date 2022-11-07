using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class DebugSix04
{
    public static void Main()
    {
        List<int> numbers = new List<int>() { }; // init new list that contains type int
        int x = 20;
        int num;
        string inString;
        Console.Write("Please enter a number or 999 to quit...");
        inString = ReadLine(); // user input = inString
        num = Convert.ToInt32(inString); // num = our user input converted to num
        while ((x > numbers.Count) && num != 999) {
            numbers.Add(num); // appened / add on our number to the end of our list, puts it in the list
            Write("Please enter a number or 999 to quit...");
            inString = ReadLine();
            num = Convert.ToInt32(inString); // set num = user input converted to an int
        }
        WriteLine("The numbers are:");
        numbers.ForEach(f => Console.Write($"{f,6}")); // for each element in our list of numbers, print it with 6 spaces to the right

        WriteLine();
        WriteLine($"The average is {numbers.Average()}"); // prints average
    }
}

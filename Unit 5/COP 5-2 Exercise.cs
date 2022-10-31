using System;
using static System.Console;
class SumInts
{
    static void Main()
    {
        int total = 0; // set variable of type int = 0
        // we use while (true) because this loop will run for forever since true is always == to true
        while (true) 
        {
            Write("Enter number (999=done) >> "); // prints to screen
            int x = Convert.ToInt32(ReadLine()); // takes user input, converts it to int, sets x equal to it
            if (x == 999) break; // if x (our user input) is equal to 999, we `break`.
            // break is a keyword to BREAK out of a loop, to stop wherever you are in the loop
            total += x; // total = total + x, += is just a shortcut to add on top of itself
        }
        WriteLine($"Total: {total}"); // prints the sum of all the numbers
    }
}

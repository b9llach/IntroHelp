/*
The program requires the user to guess the number of days it takes to make X amount of money when doubling the value every day. 
The starting value is $0.01. 
The program indicates if the guess is too high, or too low. 
*/
using System;
using static System.Console;
using System.Globalization;
class DebugFive4
{
    static void Main()
    {
        // const means constant, can not change value of variable
        const double LIMIT = 1000000.00; // set variable of type double = 1000000.00
        const double START = 0.01; // set variable of type double = 0.01
        double total = START; // set variable of type double = value of START
        int count = 0; // set variable of type int = 0
        WriteLine($"How many days do you think it will take to reach"); // prints to screen
        WriteLine($"{LIMIT.ToString("C")} starting with {START.ToString("C")} and doubling it everday?"); // prints to screen
        while (true) // while (true) which means this loop will not end until we break out of it
        {
            if (total > LIMIT) // if total is greater then limit
            { 
                break; // break out of the current loop we are in: while (true)
            }
            count += 1; // count = count + 1
            total *= 2; // total = total * 2
        }
        int guess = Convert.ToInt32(Console.ReadLine()); // takes user input, converts it to int, sets guess to it
        if (guess == count) // if guess is equal to count
        {
            WriteLine("Your guess was correct."); // prints to screenn
            WriteLine($"It takes {count} days to reach {LIMIT.ToString("C", CultureInfo.GetCultureInfo("en-US"))}"); // prints to screen
        }
        else if (guess > count) // if guess was greater then count
        {
            WriteLine("Your guess was too high."); // prints to screen
            WriteLine($"It takes {count} days to reach {LIMIT.ToString("C", CultureInfo.GetCultureInfo("en-US"))}"); // prints to screen
        }
        else
        {
            WriteLine("Your guess was too low."); // prints to screen
            WriteLine($"It takes {count} days to reach {LIMIT.ToString("C", CultureInfo.GetCultureInfo("en-US"))}"); // prints to screen
        }
    }
}

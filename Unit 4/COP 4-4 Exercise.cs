using System;
using static System.Console;
class Hurricane
{
    static void Main()
    {
        int speed; // declare an int variable
        Write("Speed >> "); // print to screen
        speed = Convert.ToInt32(ReadLine()); // takes user input, converts it to an int, and sets speed equal to it

        // so with this if statement, we also have else if. these are just other conditions that are being checked
        // once 1 condition is met, that is the end of the if condition, and it will break out of it.
        // so even if our speed is 157, it will not go on to say its also cat. 4,3,2,1 and not a hurricane
        // so for this, we are just checking if speed is greaten then or equal to the speed regarding the category
        // >= means greater then or equal to
        if (speed >= 157)
        {
            WriteLine("This is a category 5 hurricane"); // prints speed >= 157
        }
        else if (speed >= 130)
        {
            WriteLine("This is a category 4 hurricane"); // prints speed >= 130 but speed < 157
        }
        else if (speed >= 111)
        {
            WriteLine("This is a category 3 hurricane"); // prints speed >= 111 but speed < 130
        }
        else if (speed >= 96)
        {
            WriteLine("This is a category 2 hurricane"); // prints speed >= 96 but speed < 111
        }
        else if (speed >= 74)
        {
            WriteLine("This is a category 1 hurricane"); // prints speed >= 74 but speed < 96
        }
        else
        {
            WriteLine("This is not a hurricane"); // prints speed < 74
        }

    }
}

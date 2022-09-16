using System;
using static System.Console;
using System.Globalization;
class MarshallsRevenue
{
    static void Main()
    {

        const int interior = 500; // set a const int for the price of the interior
        const int exterior = 750; // set a const int for the price of the exterior
        int num_interior; // declare a variable so we can keep the value of how many numbers of interior we need
        int num_exterior; // declare a variable so we can keep the value of how many numbers of exterior we need

        Write("Enter the number of interior murals scheduled >> "); // prints to screen
        num_interior = Convert.ToInt32(ReadLine()); // takes the users input, converts it to an integer, and sets the value of num_interior equal to it
        Write("Enter the number of exterior murals scheduled >> ");
        num_exterior = Convert.ToInt32(ReadLine()); // takes the users input, converts it to an integer, and sets the value of num_exterior equal to it

        WriteLine($"{num_interior} interior murals are scheduled at {interior.ToString("C", CultureInfo.GetCultureInfo("en-US"))} each for a total of {(interior * num_interior).ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
        // $ for formatting, `(interior * num_interior).ToString("C", CultureInfo.GetCultureInfo("en-US"))` multiplies the price by the number of interior to get the total cost for interior

        WriteLine($"{num_exterior} exterior murals are scheduled at {exterior.ToString("C", CultureInfo.GetCultureInfo("en-US"))} each for a total of {(exterior * num_exterior).ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
        // $ for formatting, `(interior * num_interior).ToString("C", CultureInfo.GetCultureInfo("en-US"))` multiplies the price by the number of exterior to get the total cost for exterior

        WriteLine($"Total revenue expected is {((exterior * num_exterior) + (interior * num_interior)).ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
        // $ for formatting, `((exterior * num_exterior) + (interior * num_interior)).ToString("C", CultureInfo.GetCultureInfo("en-US"))` adds the total cost between the interior and exterior 
        // to get the final amount

        // if statements work based on if a condition is true, this one is simple math
        // if the number of interior is greater then the number of exterior, then print it is true
        if (num_interior > num_exterior)
        {
            WriteLine("It is True that there are more interior murals scheduled than exterior ones."); // this will print if the condition is true
        }
        // else executes when the statement given is not true, and has no other conditions to check or those conditions are not true
        else
        {
            WriteLine("It is False that there are more interior murals scheduled than exterior ones."); // this will print if all conditions are false
        }
    }
}

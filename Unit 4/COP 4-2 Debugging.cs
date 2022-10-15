// Program asks user to enter three integers
// Program displays a message indicating whether the numbers
// are in sequential order,
// in reverse order
// or in neither order
using System;
using static System.Console;
class DebugFour2
{
    static void Main()
    {
        int num1, num2, num3; // create 3 variables of type int
        Write("Enter first number >> "); // prints to screen
        num1 = Convert.ToInt32(ReadLine());
        Write("Enter second number >> "); // prints to screen
        num2 = Convert.ToInt32(ReadLine());
        Write("Enter third number >> "); // prints to screen
        num3 = Convert.ToInt32(ReadLine());

        if (num1 <= num2 && num2 <= num3) // if num1 is less then or equal to num2, and num2 is less then or equal to num3
        {
            // in this case, if we entered 1, 2, 3, we would hit this part of the if statement
            // we can also enter 2, 2, 3, since 2 is less then or equal to 2, and 3 is greater then 2
            // entering 2, 2, 2 also works here because all of the number can be equal due to <= and not just <
            WriteLine("Numbers are in sequential order");
        }
        else if (num1 >= num2 && num2 >= num3)
        {
            // in this case, if we entered 3, 2, 1 we would hit this part of the if statement
            // we can also enter 3, 2, 2 since 3 is greater then or equal to 2, and 2 is less then or equal to 2
            WriteLine("Numbers are in reverse order");
        }
        else
        {
            // if neither of those conditions are met, we hit this part
            // if we entered 4, 6, 5, we would get this far, since neither of those other conditions are met
            WriteLine("Numbers are in neither sequential nor reverse order");
        }
    }
}

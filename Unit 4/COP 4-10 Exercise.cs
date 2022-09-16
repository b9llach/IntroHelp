using System;
using static System.Console;
class CheckMonth2
{
    static void Main()
    {
        int month, day; // declare two int vars
        Write("Enter birth month >> "); // prints to screen
        month = Convert.ToInt32(ReadLine()); // converts user input to int, sets month equal to it
        Write("Enter birth day >> "); // prints to screen
        day = Convert.ToInt32(ReadLine()); // converts user input to int, sets day equal to it
        // a switch statement evaluates an expression, matching the expression's value against a series of case clauses, and executes statements
        // so say you entered the month 1, it will execute the code within case 1
        // the default all the way at the end of the switch statement is incase you enter a number that does not have a case assigned to it
        // a switch case is kind of just a bunch of if and else if statements put together
        switch (month)
        {
            case 1:
                if (day >= 1 && day <= 31)// makes sure that the day actually exists within the month
                {
                    WriteLine($"{month}/{day} is a valid birthday");
                }
                else
                {
                    WriteLine("Invalid date");
                }
                break; // this just exits the switch statement and shows that we ended our code for that case
            case 2:
                if (day >= 1 && day <= 29)// makes sure that the day actually exists within the month
                {
                    WriteLine($"{month}/{day} is a valid birthday");
                }
                else
                {
                    WriteLine("Invalid date");
                }
                break; // this just exits the switch statement and shows that we ended our code for that case
            case 3:
                if (day >= 1 && day <= 31)// makes sure that the day actually exists within the month
                {
                    WriteLine($"{month}/{day} is a valid birthday");
                }
                else
                {
                    WriteLine("Invalid date");
                }
                break; // this just exits the switch statement and shows that we ended our code for that case
            case 4:
                if (day >= 1 && day <= 30)// makes sure that the day actually exists within the month
                {
                    WriteLine($"{month}/{day} is a valid birthday");
                }
                else
                {
                    WriteLine("Invalid date");
                }
                break; // this just exits the switch statement and shows that we ended our code for that case
            case 5:
                if (day >= 1 && day <= 31)// makes sure that the day actually exists within the month
                {
                    WriteLine($"{month}/{day} is a valid birthday");
                }
                else
                {
                    WriteLine("Invalid date");
                }
                break; // this just exits the switch statement and shows that we ended our code for that case
            case 6:
                if (day >= 1 && day <= 30)// makes sure that the day actually exists within the month
                {
                    WriteLine($"{month}/{day} is a valid birthday");
                }
                else
                {
                    WriteLine("Invalid date");
                }
                break; // this just exits the switch statement and shows that we ended our code for that case
            case 7:
                if (day >= 1 && day <= 31)// makes sure that the day actually exists within the month
                {
                    WriteLine($"{month}/{day} is a valid birthday");
                }
                else
                {
                    WriteLine("Invalid date");
                }
                break; // this just exits the switch statement and shows that we ended our code for that case
            case 8:
                if (day >= 1 && day <= 31)// makes sure that the day actually exists within the month
                {
                    WriteLine($"{month}/{day} is a valid birthday");
                }
                else
                {
                    WriteLine("Invalid date");
                }
                break; // this just exits the switch statement and shows that we ended our code for that case
            case 9:
                if (day >= 1 && day <= 30)// makes sure that the day actually exists within the month
                {
                    WriteLine($"{month}/{day} is a valid birthday");
                }
                else
                {
                    WriteLine("Invalid date");
                }
                break; // this just exits the switch statement and shows that we ended our code for that case
            case 10:
                if (day >= 1 && day <= 31)// makes sure that the day actually exists within the month
                {
                    WriteLine($"{month}/{day} is a valid birthday");
                }
                else
                {
                    WriteLine("Invalid date");
                }
                break; // this just exits the switch statement and shows that we ended our code for that case
            case 11:
                if (day >= 1 && day <= 30)// makes sure that the day actually exists within the month
                {
                    WriteLine($"{month}/{day} is a valid birthday");
                }
                else
                {
                    WriteLine("Invalid date");
                }
                break; // this just exits the switch statement and shows that we ended our code for that case
            case 12:
                if (day >= 1 && day <= 31) // makes sure that the day actually exists within the month
                {
                    WriteLine($"{month}/{day} is a valid birthday");
                }
                else
                {
                    WriteLine("Invalid date");
                }
                break; // this just exits the switch statement and shows that we ended our code for that case
            default:
                WriteLine("Invalid date"); // we know it is an invalid without checking the day because the user did not enter a valid month in
                break;
        }
    }
}

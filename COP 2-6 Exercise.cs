using System;
using static System.Console;
using System.Globalization;
class MoveEstimator
{
    static void Main()
    {
        Write("Hours >> "); // prints to screen
        int hours = Convert.ToInt32(ReadLine()); // this takes the users input, converts it to an integer, and assigns that value to the variable `hours`
        Write("Miles >> "); // prints to screen
        int miles = Convert.ToInt32(ReadLine()); // this takes the users input, converts it to an integer, and assigns that value to the variable `miles`
        WriteLine($"For a move taking {hours} hours and going {miles} miles the estimate is {((hours * 150) + (miles * 2) + 200).ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
        // like before, we use $ for formatting. see within the {} i have my variable names, it will
        // print the value of the variable in place of that
        // for the math here, it said $150 an hour, so i am multiply the number of hours by 150
        // then for miles, it said $2 a mile, so i am multiply that by 2
        // i then add both of those together and add $200 as it said the base rate was
        // we then have that ToString method again, which will just convert the integer into currency, so 4060 would be $4,060.00
    }
}

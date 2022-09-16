using System;
using static System.Console;
using System.Globalization;
class ProjectedRaises
{
    static void Main()
    {
        const double r = .04; // i have this because it was telling me i needed a const double with the value .04, im not really sure why its even needed but whatever
        const double raise_perc = 1.04; // this is the actual 4% raise we need to include, 1.04 bc we are just taking the current value and adding 4% to it
        double e1 = 25000; // employee 1 starting salary
        double e2 = 38000; // employee 2 starting salary
        double e3 = 51000; // employee 3 starting salary

        WriteLine($"Next year's salary for the first employee will be {(e1 * raise_perc).ToString("C", CultureInfo.GetCultureInfo("en-US"))}"); // prints employee 1's salary after raise

        WriteLine($"Next year's salary for the second employee will be {(e2 * raise_perc).ToString("C", CultureInfo.GetCultureInfo("en-US"))}"); // prints employee 2's salary after raise

        WriteLine($"Next year's salary for the third employee will be {(e3 * raise_perc).ToString("C", CultureInfo.GetCultureInfo("en-US"))}"); // prints employee 3's salary after raise

        // (e3 * raise_perc) this math just gets the salary after the raise, so 25000 will turn into 26000
        // so that first line would print `Next year's salary for the first employee will be $26,000`
        // .ToString("C", CultureInfo.GetCultureInfo("en-US")) this part turns it from an integer into a string
        // an integer is just a whole number, 0, 1, 2, etc. , a string is a phrase, word or sentence 
        // you create a string by doing
        // string my_string_name = "";
        // but in this case, .ToString does it for us
        // the rest of the shit after it will convert it to like an actual money amount, it just adds the $ and commas where they belond
        // the $ at the beginning of the string allows you to format. formatting just means putting the values of variables within a string
    }
}

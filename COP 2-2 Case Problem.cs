using System;
using static System.Console;
using System.Globalization;
class MarshallsRevenue
{
    static void Main()
    {
        // Write your main here
        const int interior = 500;
        const int exterior = 750;
        int num_interior;
        int num_exterior;
        Write("Enter the number of interior murals scheduled >> ");
        num_interior = Convert.ToInt32(ReadLine());
        Write("Enter the number of exterior murals scheduled >> ");
        num_exterior = Convert.ToInt32(ReadLine());
        WriteLine($"{num_interior} interior murals are scheduled at {interior.ToString("C", CultureInfo.GetCultureInfo("en-US"))} each for a total of {(interior*num_interior).ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
        WriteLine($"{num_exterior} exterior murals are scheduled at {exterior.ToString("C", CultureInfo.GetCultureInfo("en-US"))} each for a total of {(exterior*num_exterior).ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
        WriteLine($"Total revenue expected is {((exterior * num_exterior) + (interior * num_interior)).ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
        if (num_interior > num_exterior)
        {
            WriteLine("It is True that there are more interior murals scheduled than exterior ones.");
        } else
        {
            WriteLine("It is False that there are more interior murals scheduled than exterior ones.");
        }
    }
}

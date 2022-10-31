using System;
using System.Linq;
using static System.Console;
class MarshallsRevenue
{
    static void Main()
    {
        // i am not sure why at all but for me it fails on the third test case in cengage but it worked fine
        // for me trying it out on my own so i dont really know

        // <int, int, int>, the first two are the input types, the last is output, we return int
        // i guess dont worry about this but its a little trick i guess
        var filter = new Func<int, int, int>((min, max) => // this is just a cheat to filter between min and max
        {
            var i = min - 5;
            while (i < min || i > max)
            {
                i = Convert.ToInt32(ReadLine());
                if (i < min || i > max)
                {
                    WriteLine("Invalid");
                }
            }
            return i;
        });
        // const can never change value 
        const int _EXTERIOR_PRICE = 750; 
        int INTERIOR_PRICE = 500; // set variable of type int =
        int EXTERIOR_PRICE = 750; // set variable of type int =
        int numInterior; // set variable of type int =
        int numExterior; // set variable of type int =
        int revenueInterior; // set variable of type int =
        int revenueExterior; // set variable of type int =
        int total; // set variable of type int =
        bool isInteriorGreater;
        int month = filter(1, 12); // set variable of type int = return value of filter
        Write("Enter number of interior murals scheduled >> "); // prints to screen
        numInterior = filter(0, 30); // set variable of type int = return value of filter
        Write("Enter number of exterior murals scheduled >> "); // prints to screen
        numExterior = filter(0, 30); // set variable of type int = return value of filter
        if (new[] { 12, 2 }.Contains(month)) // if month equals 1 or 2
        {
            WriteLine("0 exterior murals are scheduled for a total of $0.00"); // prints to screen
        }
        else // if month is not equal to 1 or 2
        {
            if (new[] { 4, 5, 9, 10 }.Contains(month)) // if month is equal to 4,5,9,10
            {
                EXTERIOR_PRICE = 699; // price is now 699
            }
            if (new[] { 7, 8 }.Contains(month)) // if month is equal to 7 or 8
            {
                INTERIOR_PRICE = 450; // price is now 450
            }
            revenueInterior = numInterior * INTERIOR_PRICE; // revInt is equal to numInt times INT_PRI
            revenueExterior = numExterior * EXTERIOR_PRICE; // revExt is equal to numExt times EXT_PRI
            total = revenueInterior + revenueExterior; // total is equal to revInt plus revExt
            isInteriorGreater = numInterior > numExterior; // if numInt is greater then numExt, isInteriorGreater = true, else falses
            WriteLine($"{numInterior} interior murals are scheduled at {INTERIOR_PRICE.ToString("C")} for a total of {revenueInterior.ToString("C")}");  // prints to screen
            WriteLine($"{numExterior} exterior murals are scheduled at {_EXTERIOR_PRICE} for a total of {revenueExterior.ToString("C")}");  // prints to screen
            WriteLine("Total revenue expected is {0}", total.ToString("C"));  // prints to screen
            WriteLine("It is {0} that there are more interior murals scheduled than exterior ones.", isInteriorGreater);  // prints to screen
        }
    }
}

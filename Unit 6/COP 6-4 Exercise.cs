using static System.Console;
using System.Linq;
class CheckZips
{
    static void Main()
    {
        // adding [] after defining the type makes it an array, to put items in the array, you put them in {} shown below
        string[] zips = {"12789", "54012", "54481", "54982", "60007", "60103", "60187", "60188", "71244", "90210"}; 
        // create an array which contains type string
        string z = ReadLine(); // sets the variable z = to user input
        if (zips.Contains(z)) // if z is in the string array zips, if it contains it
        {
            WriteLine($"Delivery to {z} ok"); // z is in our array of zips
        }
        else
        {
            WriteLine($"Sorry - no delivery to {z}"); // z is not in our array of zips
        }

    }
}

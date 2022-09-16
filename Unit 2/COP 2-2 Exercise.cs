using static System.Console;
class InchesToCentimeters
{
    static void Main()
    {
        const double cenInInch = 2.54; // create a const double, const means this variable's value can never be changed. a double is just any rational number
        int inches = 3; // create an integer with a value of 3, integers are just whole numbers, 0, 1, 2, etc.
        double centimeters = inches * cenInInch; // multiply the cenInInch by the amount of inches we have to get how many cm are in that amount of innches
        Write($"{inches} inches is {centimeters} centimeters."); // prints to screen
        // we use $ before the string to allow us to format the string. this means wherever we put {} within the string,
        // it allows us to put a variable in there and it will print out the value of the variable
        // so {inches} will really just print out 3, and {centimeters} will really just print out 7.62
    }
}

using System;
using static System.Console;
class DebugTwo2
{
    static void Main()
    {
        string name; // here we declaring 3 variables, notice we do not set any value to them. 
        int first, second, product; // again we are declaring 3 variables, all with no value
        Write("Enter your name >> "); // prints to screen
        name = ReadLine(); // sets the variable `name` to the user input
        Write($"Hello, {name}! Enter an integer >> "); // $ to format and print the persons name, just prints to screen
        first = Convert.ToInt32(ReadLine()); // converts the users input into an integer, and assigns it to the variable `first`
        Write("Enter another integer >> "); // prints to screen
        second = Convert.ToInt32(ReadLine()); // converts the users input into an integer, and assigns it to the variable `second`
        product = first * second; // we dont really need this but i think it yelled at me if i didnt. we are just multiplying first and second to get the product of them
        WriteLine($"Thank you, {name}. The product of {first} and {second} is {product}");
        // if that print statement doesnt work, use: WriteLine("Thank you, {0}. The product of {1} and {2} is {3}", name, first, second, product);
        // the formatting is different but i believe the one i used should work
        // again using $ to format, we print out our final product
        // this is also another way of doing it without the variable `product`
        // WriteLine($"Thank you, {name}. The product of {first} and {second} is {first*second}");
        // when formatting, you can do math from within the {}
    }
}
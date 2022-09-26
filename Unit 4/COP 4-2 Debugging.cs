using static System.Console; // allows us to use Write without having to do Console.Write, puts us in console namespace

int num1, num2, num3; // declare 3 vars that are ints

Write("Enter first number >> "); // print to screen
num1 = Convert.ToInt32(ReadLine()); // takes in user input, convert it an int, set it to num1
Write("Enter second number >> "); // print to screen
num2 = Convert.ToInt32(ReadLine()); // takes in user input, convert it an int, set it to num2
Write("Enter third number >> "); // print to screen
num3 = Convert.ToInt32(ReadLine()); // takes in user input, convert it an int, set it to num3

if (num1 <= num2 && num2 <= num3) // checks if num1 is less then or equal to num2 AND (&& means and) num2 is less then or equal to num3
{
    WriteLine("Numbers are in sequential order");  // prints to screen
}
else if (num1 >= num2 && num2 >= num3) // checks if num1 is greater then or equal to num2 AND (&& means and) num2 is greater then or equal to num3
{
    WriteLine("Numbers are in reverse order"); // prints to screen
}
else // neither condition has been met
{
    WriteLine("Numbers are in neither sequential nor reverse order"); // print to screen
}



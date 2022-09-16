// heres other helpful shit to know
using System;
using static System.Math;
using static System.Console;

// the keyword `using` you'll see at the top of (most likely) every program youll write for this class is
// sort of a way to include other functions, classes, and variables
// using System; allows use to a wide variety of tools that without it, we couldnt be able to use
// this keyword `static` after the keyword `using` allows us to import specific types, in this case console
// this is why you can use ReadLine() and Write("") without having to put `Console.` before it
// this is also known as the scope, everything in programming is relative to what you have access to.
// by using the keyword `using`, youre basically importing other functionality into your code
// if you dont get this, dont worry, you dont need to know it right now



// please try everything in here on your own, it helps you learn
// install microsoft visual studio 2022, and when it asks you what type of development you want
// select desktop development with c#, then click install



// basic data types
double my_double = 3.14; // a double is a decimal number, its pretty simple
float my_float = 1.61f; // a float is also a decimal, but the max value of a float is smaller then a double (yes numbers have max values). notice the f to clarify its a float
int my_int = 7; // an integer is just a whole number, thats it
decimal my_decimal = 14.53M; // a decimal is literally just a decimal, notice the M to clarify it is a decimal
// there are more data types for numbers, here is a link to all of them with their perspective mins and maxes:
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

string my_string = "hello world!"; // a string can be a phrase, sentence, a letter, or simply nothing inside of it at all. notice how we use double quotes
char my_char = 'A'; // a char is just a singular character, thats it.
bool my_bool = false; // a bool is just true or false, its values can only be `true` or `false`



// math within C#
// in order to access all of the math functionality, we did
// using static System.Math; at the top of the file
// simple math can be done with the following operators
// *, +, -, /, %
// the % is modulus, which is division but it returns the remainder
// so 10 % 3 is 1 because 3 goes into 10 3 times but has 1 remaining

WriteLine(10 * 2); // 20
WriteLine(15 / 5); // 3
WriteLine(13 - 8); // 5
WriteLine(15 + 7); // 22
WriteLine(16 % 6); // 4

// some other functions from System.Math
WriteLine(Abs(-45)); // absolute value, 45
WriteLine(Floor((decimal)5 / 3)); // (decimal) just forces 5 / 3 to be a decimal and not a float or a double. this is called type casting; floor rounds down, 5.9 will become 5
WriteLine(Ceiling((decimal)5 / 3)); // (decimal) just forces 5 / 3 to be a decimal and not a float or a double. this is called type casting; ceiling rounds up, 5.1 will become 6


// basic control flow
bool test_bool = true; // setting the value of condition to `true`, this is a bool

// this is an if statement. if some condition is true, it executes certain code
// in this case, our test_bool value was true, notice how we use `==` this is a comparion operator
// == just means equals to, other operators consist of `>` greater then, `<` less then, `>=` greater then or equal to,
// `<=` less then or equal to, `!=` not equal to
if (test_bool == true)                
{
    // since test_bool was equal to the value `true`, code within { .. } will run
    WriteLine("test_bool was true!");
    // this will then print out `test_bool was true!`

}
// say our test_bool was set to false, then our condition `test_bool == true` wouldnt be true
// if statements have another part called else, which allows us to execute other code incase the condition statement isnt true
else {
    WriteLine("test_bool was not true!");
}




// now lets try this again but instead with an if, else if, and else
// if statements can also be done with math like if 10 > 5, that is true
int test_int = 19;

// since test_int is not greater then 25, it will not print `test_int is greater then 25`
if (test_int > 25)
{
    WriteLine("test_int is greater then 25");
} 
// since test_int IS greater then 16, this code will execute. else if just allows for another condition to be checked
else if (test_int > 16)
{
    WriteLine("test_int is greater then 16, but not 25");
} else
{
    WriteLine("test_int is less then 16");
}

// you can also do this with any of the other operators > < == != but you can do that on your own time



// while loops
int x = 10;

// while some condition is true, execute the following code 
// in this case, while x > 10, we print out what x is
// afterwards, we subtract 1 from x
while (x>0)
{
    WriteLine($"x is {x}");
    x--; // this shortcut `--` really means `x = x-1`, we are just subtracting 1 from x. this also works with adding one, you would just do x++
}

// if you wanted to make a while loop run for over you would just do:
// while (true) since true is never false   




// for loops also loop while a condition is true, but usually these have a range
// we set i to 0, while i is less then 10, we execute the following code then add one
// this code will print out: 0,1,2,3,4,5,6,7,8,9
// we dont hit 10 because 10 is not less then 10
for (int i = 0; i < 10; i++)
{
    WriteLine(i);
}
// we can also iterate through a string like this
string test_string = "hello, world!";
for (int i=0; i<test_string.Length; i++)
{
    WriteLine(test_string[i]); // ok so the [i] is grabbing the i-th element in the string
    // in programming we start out at 0 instead of one
    // so if we wanted to 0th element if our string `test_string`, we would get 'h'
    // to do that would we do `test_string[0]`
    // so when we print `test_string[i]`, whatever i is, it will print the character from the string
    // test_string[4] would print out 'o'
    // test_string[5] would print out ','
    // test_string[7] would print out 'w'
    // hopefully you get it, if not look up indexing strings
}





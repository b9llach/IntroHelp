using System;
using static System.Console;
class DailyTemps
{
    static void Main()
    {
        int temp = 0; // set variable of type int = 0
        int temp_total = 0; // set variable of type int = 0
        int num_total = 0; // set variable of type int = 0
        while (true) // while (true) means the loop will never end unless we break out of it
        {
            Console.WriteLine("Enter a temp (-20 - 130) >> "); // prints to screen
            temp = Convert.ToInt32(Console.ReadLine()); // takes user input, converts it to int
            if (temp == 999) // if temp (our user input) equals 999
            {
                break; // break out of the current loop we are in which is: while (true)
            }
            else if (temp >= -20 && temp <= 130) // if temp is greater then or equal to -20, and less then or equal to 130
            {
                temp_total += temp; // temp_total = temp_total + temp
                num_total += 1; // num_total = num_total + 1
            }
            else // there is an invalid temperature, not in between -20 and 130
            {
                Console.WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature."); // prints to screen
            }
        }
        Console.WriteLine($"Number of temps: {num_total}\nAverage: {(float)temp_total / num_total}");
        // prints to screen the number of temps, and calculates the average
    }
}

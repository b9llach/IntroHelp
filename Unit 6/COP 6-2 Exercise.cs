using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class TestScoreList
{
    static void Main()
    {
        List<int> list = new List<int>(); // create a new list that holds ints in it
        for (int i = 0; i < 8; i++)
        {
            list.Add(int.Parse(ReadLine())); // append or add onto the end of the list a number that the user enters
        }
        double avg = list.Average(); // get the average of all numbers in the list, returns a double
        for (int i = 0; i < 8; i++)
        {
            WriteLine($"Test # {i}: {list[i]} From average: {list[i] - avg} "); // print the distance from average each int in the list it
        }

    }
}

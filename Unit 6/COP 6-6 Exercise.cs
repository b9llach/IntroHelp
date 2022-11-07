using System;
using static System.Console;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
class ChatAWhile
{
    static void Main()
    {
        // dictionaries, just like in real life, have a key and a value, or a word and a definition
        // in our case, the key points to a value.
        // create a new dictionary with a key of type string, and a value of type double
        Dictionary<string, double> areaToPMR = new Dictionary<string, double>() {
        {"262", .07}, // our key is 262, our value is .07. notice 262 is a string, .07 is a double
        {"414", .10},
        {"608", .05},
        {"715", .16},
        {"815", .24},
        {"920", .14}
        };
        // go get a value of a key, you can do:
        // areaToPMR["262"];
        // if you printed that, it would print .07, and it would be of type double
        string areaCode = ReadLine(); // takes user input and sets it = areaCode
        List<string> keyList = new List<string>(areaToPMR.Keys); // gets a list of all of the keys of our dictionary, and puts them into a list
        if (keyList.Contains(areaCode)) // if areaCode is in our list of keys called keyList
        {
            int length = Convert.ToInt32(ReadLine()); // len of phone call in minutes
            Console.WriteLine($"Your phone call to area {areaCode} costs {areaToPMR[areaCode].ToString("C")} per minute For {length} minutes the total is {(areaToPMR[areaCode] * length).ToString("C")}");
        }
        else
        {
            Console.WriteLine($"Sorry - no calls allowed to area {areaCode}");
        }
    }
}

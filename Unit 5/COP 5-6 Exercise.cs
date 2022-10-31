using static System.Console;
class DisplayMultiplicationTable
{
    static void Main()
    {
        // this one is confusing, youre creating a 2d array, basically like an x and y grid using 2 for loops
        // for every iteration in the first for loop, an entire row is created in the second for loop

        for (int h = 0; h < 11; ++h) // will go 0 - 10
        {
            for (int v = 0; v < 11; ++v) // will go 0 - 10
            {
                if (h == 0 && v == 0) // if h is equal to 0 and v is equal to 0
                {
                    Write(" {0,3} ", " "); // prints to screen, {0,3} where 0 is the format, and 3 is the amount of spaces over
                }
                else if (h == 0 && v != 0) // if h isequal to 0 and v is not equal 0
                {
                    Write(" {0,3} ", v); // prints to screen, {0,3} where 0 is the format, and 3 is the amount of spaces over
                }
                else // if h is not equal to 0 and v is 0
                {
                    if (v == 0) // if v is equal to 0
                    {
                        Write(" {0,3} ", h); // prints to screen, {0,3} where 0 is the format, and 3 is the amount of spaces over
                    }
                    else // if v is not equal to 0
                    {
                        Write(" {0,3} ", h * v); // prints to screen, {0,3} where 0 is the format, and 3 is the amount of spaces over
                    }
                }
            }
            WriteLine(""); // prints to screen nothing
        }
    }
}

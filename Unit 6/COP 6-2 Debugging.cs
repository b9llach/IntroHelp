// Program averages four numbers
using static System.Console;
class DebugSix02
{
    static void Main()
    {
        int[] numbers = { 12, 15, 22, 88 }; // int array with values 12, 15, 22, 88
        double average;
        double total = 0;
        Write("\nThe numbers are...");
        for (int x = 0; x < numbers.Length; ++x) {
            Write($"{numbers[x], 6}"); // prints numbers[x] with 6 spaces after it
        }
        WriteLine();
        for (int x = 0; x < numbers.Length; ++x) {
            total += numbers[x]; // total = total + numbers[x]
        }
        average = total / numbers.Length; // gets average by dividing total by length of array
        Write($"The average is {average}"); // prints average
    }
}

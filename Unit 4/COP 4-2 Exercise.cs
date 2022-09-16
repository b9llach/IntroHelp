using static System.Console;
class Twitter
{
    static void Main()
    {
        Write("Message: "); // prints to the screen

        // since ReadLine() returns a string, we can check the length of our message.
        // .Length is an integer so we can compare it to 140 without having to do Convert.ToInt32()
        // if statements check if the given condition is true, in our case (ReadLine().Length > 140)
        if (ReadLine().Length > 140) // if our message length > 140
        {
            WriteLine("The message is too long"); // prints to the screen when the message is > 140 characters
        }
        else // if our message length is 140 or less
        {
            WriteLine("The message is okay"); // prints to the screen when the message is not > 140 characters
        }
    }
}

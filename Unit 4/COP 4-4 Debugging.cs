// Program asks user to enter three integers
// Program displays a message indicating whether the numbers
// are in sequential order,
// in reverse order
// or in neither order
using System;
using static System.Console;
using System.Globalization;
class DebugFour4
{
    static void Main()
    {
        double sales, commission; // unassigned double variable
                                  // const variables value's can not be changed after first assignment
        const int LOWSALES = 1000; // defining const int
        const int MEDSALES = 5000; // defining const int
        const int HIGHSALES = 10000; // defining const int
        const double LOWPCT = 0.05; // defining const double
        const double MEDPCT = 0.07; // defining const double
        const int BONUS1 = 1000; // defining const int
        const int BONUS2 = 1500; // defining const int
        WriteLine("What was the sales amount? "); // print to screen
        sales = Convert.ToDouble(ReadLine()); // converts user input to a double, and set sales equal to it
        commission = LOWPCT * Math.Min(sales, LOWSALES); // sets commission to whichever value is lower, sales or LOWSALES
        if (sales <= LOWSALES) // if sales is less then or equal to lowsales
        {
            // commission += (sales - LOWSALES) * LOWPCT is just commission = commission + (sales - LOWSALES) * LOWPCT
            commission += (sales - LOWSALES) * LOWPCT; // += is a short cut to add the variable onto itself. for example x+=1 is just x = x + 1
        }
        else if (sales <= MEDSALES) // if sales is less then or equal to medsales
        {
            commission += ((sales - LOWSALES) * MEDPCT); // again using += shortcut
        }

        else if (sales <= HIGHSALES) // if sales is less then or equal to highsales
        {
            commission += ((sales - LOWSALES) * MEDPCT) + BONUS1;
        }
        else // if no other condition is being met, we use this
        {
            commission += ((sales - LOWSALES) * MEDPCT) + BONUS1 + BONUS2; // again using += shortcut
        }

        WriteLine($"Sales: {sales.ToString("C")}\nCommission: {commission.ToString("C")}"); // prints to screen
    }
}

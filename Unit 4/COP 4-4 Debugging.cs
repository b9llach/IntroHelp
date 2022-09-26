using static System.Console; // puts us in console namespace

double sales, commission; // unassigned double variable
// const variables value's can not be changed after first assignment
const int LOWSALES = 1000;
const int MEDSALES = 5000;
const int HIGHSALES = 10000;
const double LOWPCT = 0.05;
const double MEDPCT = 0.07;
const int BONUS1 = 1000;
const int BONUS2 = 1500;
WriteLine("What was the sales amount? "); // print to screen
sales = Convert.ToDouble(ReadLine()); // converts user input to a double, and set sales equal to it
commission = LOWPCT * Math.Min(sales, LOWSALES); // sets commission to whichever value is lower
if (sales <= LOWSALES) // if sales is less then or equal to lowsales
{
    commission += (sales - LOWSALES) * LOWPCT; // += is a short cut to add the variable onto itself. for example x+=1 is just x = x + 1
    // so commission += (sales - LOWSALES) * LOWPCT is just commission = commission + (sales - LOWSALES) * LOWPCT
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
    commission += ((sales - LOWSALES) * MEDPCT) + BONUS1 + BONUS2;
}

WriteLine($"Sales: {sales.ToString("C")}\nCommission: {commission.ToString("C")}"); // prints to screen
using static System.Console;
using System;
namespace CSharp_1
    /*This program documents    string-to-double conversion
     *                          reading user input
     *                          and a failed while loop*/
{

    class Hello { 
          enum Months {JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG,
        SEP, OCT, NOV, DEC }
            static void Main(string[] args) {
            int lastYear = 25;
            string strThisYear;
            Months currentMonth = Months.APR;
            WriteLine("Current Month is: " + currentMonth);
            WriteLine("Enter 'y' to continue.");
            char input = Console.ReadKey().KeyChar;
          
            while (input == 'y') {
                Write("Enter the number of contestants from this year: ");
                strThisYear = ReadLine();
                WriteLine("You entered " + strThisYear);
                double thisYear = Double.Parse(strThisYear);
                bool isThisYearMore = thisYear > lastYear;
                WriteLine("This year greater than last is: " + isThisYearMore);
                const double TAX_RATE = .081;
                Write("enter the amount you want to find the tax for:");
                string strAmount = ReadLine();
                double amount = Double.Parse(strAmount);
                WriteLine("You entered " + amount);
                WriteLine("Total with tax is at 8.1% is " + ((amount += amount * TAX_RATE).ToString("C")));
                WriteLine("Do another calculation?");
                input = Console.ReadKey().KeyChar;
                    }   

            }
           
      
            
        }
    }


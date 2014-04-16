using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the function with the parameters
            ChangeMaker(3.18);
            Console.WriteLine();
            ChangeMaker(0.99);
            Console.WriteLine();
            ChangeMaker(12.93);
            Console.ReadKey();
        }

        //Making ChangeMaker function
        static void ChangeMaker(double amount)
        {
            //Print amount first, as it is modified in the code
            Console.WriteLine("Amount: $" + amount);
            //Declaring variables
            var quarNum = 0;
            var dimeNum = 0;
            var nickNum = 0;
            var pennNum = 0;
            
            //While amount is more than .25, it takes off a quarter from the amount and adds it to the quarter vaiable
            while (amount > 0.25)
            {
                    quarNum++;
                    amount -= 0.25;
            }
            //While amount is more than .10, it takes off a dime from the amount and adds it to the dime variable
            while (amount > 0.10)
            {
                dimeNum++;
                amount -= 0.10;
            }
            //While amount is more than .05, it takes off a nickel from the amount and adds it to the nickel variable
            while (amount > 0.05)
            {
                nickNum++;
                amount -= 0.05;
            }
            //While amount is more than .01, it takes off a penny from the amount and adds it to the penny variable
            while (amount > 0)
            {
                pennNum++;
                amount -= 0.01;
            }
            //Print amount of quarters, dimes, nickels, and pennys.
            Console.WriteLine("Quarters: "+quarNum);
            Console.WriteLine("Dimes: "+dimeNum);
            Console.WriteLine("Nickels: "+nickNum);
            Console.WriteLine("Pennies: "+pennNum);
        }
    }
}

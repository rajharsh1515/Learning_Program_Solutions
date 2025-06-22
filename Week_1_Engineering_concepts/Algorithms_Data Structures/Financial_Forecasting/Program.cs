using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Forecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter initial amount: ");
            double initialAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter annual growth rate (e.g. 0.05 for 5%): ");
            double growthRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number of years to forecast: ");
            int years = Convert.ToInt32(Console.ReadLine());

            double futureValue = CalculateFutureValueRecursive(initialAmount, growthRate, years);

            Console.WriteLine($"\nFuture Value after {years} years: {futureValue:F2}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static double CalculateFutureValueRecursive(double currentValue, double growthRate, int yearsLeft)
        {
            if (yearsLeft == 0)
                return currentValue;

            return CalculateFutureValueRecursive(currentValue * (1 + growthRate), growthRate, yearsLeft - 1);
        }
    }
}
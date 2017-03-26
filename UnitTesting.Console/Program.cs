using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Core;

namespace UnitTesting.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = "46621468";
            var input = System.Console.ReadLine();
            var calculator = new VerificationDigitCalculator();
            var result = calculator.CalculateVerificationDigit(input);
            System.Console.WriteLine(result);
        }
    }
}

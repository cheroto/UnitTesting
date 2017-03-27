using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Core
{
    public class VerificationDigitCalculator
    {
        public string CalculateVerificationDigit(string input)
        {
            if (input.Length != 8)
            {
                throw new FormatException("Incorrect input size.");
            }
            var inputTempArray = input.ToCharArray();
            var inputArray = new int[inputTempArray.Length];
            var sum = 0;
            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                try
                {
                    sum += Convert.ToInt32(inputTempArray[i].ToString()) * (inputArray.Length - i + 1);
                }
                catch (FormatException)
                {
                    throw new FormatException("Invalid Input.");
                }
            }
            var remainder = sum % 11;
            if (remainder > 9)
            {
                return "X";
            }
            return remainder.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Core
{
    public class VerificationDigitCalculator
    {
        public int CalculateVerificationDigit(string input)
        {
            var inputTempArray = input.ToCharArray();
            var inputArray = new int[inputTempArray.Length];
            var sum = 0;
            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                sum += Convert.ToInt32(inputTempArray[i].ToString()) * (inputArray.Length - i + 1);
            }
            var remainder = sum % 11;
            return remainder;
        }
    }
}

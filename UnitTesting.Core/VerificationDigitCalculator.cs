//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UnitTesting.Core
//{
//    class VerificationDigitCalculator
//    {
//        public int CalculateVerificationDigit
//        //var input = "46621468";
//        var input = System.Console.ReadLine();
//        var inputTempArray = input.ToCharArray();
//        var inputArray = new int[8];
//        var sum = 0;
//            for (int i = inputArray.Length -1; i >= 0; i--)
//            {
//                sum += Convert.ToInt32(inputTempArray[i].ToString()) * (inputArray.Length - i + 1);
//            }
//    var remainder = sum % 11;
//    System.Console.WriteLine(remainder);
//    }
//}

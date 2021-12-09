using System;
using System.Text.RegularExpressions;

namespace ASP_MVC_Beginner_Testing.Models{
    public class BinaryCalculator{
        public string inputNumber{get; set;}

        public static string ConvertFromBinary(string binaryInput){
            string binaryPattern = "[0-1]{8}";
            MatchCollection binaryMatchCollection = Regex.Matches(binaryInput, binaryPattern);
            string convertedToText = "";

            for (int count = 0; count < binaryMatchCollection.Count; count++) { 
                string singleBinary = binaryMatchCollection[count].Value;
                int decimalNumber = Convert.ToInt32(singleBinary, 2);
                convertedToText += Convert.ToChar(decimalNumber);
            }
            Console.WriteLine(convertedToText);
            return convertedToText;
        }
    }
}
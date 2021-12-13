using System;
using System.Text.RegularExpressions;

namespace ASP_MVC_Beginner_Testing.Models{
    public class BinaryCalculator{
        public string inputNumber{get; set;}

        // Converts string of binary to ascii. Assumes 8 bits per character.
        public static string ConvertBinaryToString(string input){
            string binaryPattern = "[0-1]{8}";
            MatchCollection binaryMatchCollection = Regex.Matches(input, binaryPattern);
            string convertedToText = "";

            for (int count = 0; count < binaryMatchCollection.Count; count++) { 
                string singleBinary = binaryMatchCollection[count].Value;
                int decimalNumber = Convert.ToInt32(singleBinary, 2);
                convertedToText += Convert.ToChar(decimalNumber);
            }
            Console.WriteLine(convertedToText);
            return convertedToText;
        }

        // Converts string of ascii to binary. Assumes 8 bits per character.
        public static string ConvertStringToBinary(string input){
            string convertedToBinary = "";
            for(int i=0; i<input.Length; i++){
                int charValue = Convert.ToInt32(input[i]);
                string binaryUnfinished = Convert.ToString(charValue, 2);
                convertedToBinary += binaryUnfinished.PadLeft(8, '0');
                convertedToBinary += " ";
            }
            Console.WriteLine(convertedToBinary);
            return convertedToBinary;
        }
    }
}
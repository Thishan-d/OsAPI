using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OSWebApi.Services
{
    public class CustomStringService : ICustomStringService
    {

        public string ReverseString(string inputString)
        {
            var stringBuilderText = new StringBuilder();
            int num = inputString.Length;
            while (num != 0)
            {
                stringBuilderText.Append(inputString[num - 1]);
                num--;
            }
            return stringBuilderText.ToString();
        }

        public string ConvertVowelsToLowercase(string inputString)
        {
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            foreach (char vowel in vowels)
            {
                string ToBeRepalced = vowel.ToString();
                string RepalcedBy = vowel.ToString().ToLower();
                inputString = inputString.Replace(ToBeRepalced, RepalcedBy);
            }

            return inputString;
        }

        public string ConvertConsonantsToUppercase(string inputString)
        {
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            var stringBuilderText = new StringBuilder(inputString);

            for (int i = 0; i < inputString.Length; i++)
            {
                char compairChar = stringBuilderText[i];
                if (!vowels.Contains(compairChar))
                {
                    char ch = Char.ToUpper(stringBuilderText[i]);
                    stringBuilderText[i] = ch;
                }
            }

            return stringBuilderText.ToString();
        }

        public string IgnoreNumbersInWord(string inputString)
        {
            var stringBuilderText = new StringBuilder();
            foreach (char tempChar in inputString)
            {
                if (!Char.IsDigit(tempChar))
                {
                    stringBuilderText.Append(tempChar);
                }
            }

            return stringBuilderText.ToString();
        }

        public string ConnvertString(string inputString)
        {
            char[] customChars = new char[] {'A','a'};
            var myString = new StringBuilder(inputString);
            for(int i=0; i< inputString.Length; i++)
            {
                if(!customChars.Contains(myString[i]))
                {
                    myString[i] = Char.ToUpper(myString[i]);
                }
            }
            return myString.ToString();
        }
    }
}
//https://www.geeksforgeeks.org/c-sharp-char-isdigit-method/
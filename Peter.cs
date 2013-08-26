using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class Peter
    {
        public static Boolean isPalindrome(String number)
        {
            char[] numberAsArray = number.ToArray();
            int arrayLength = numberAsArray.Length;
            int numberLength = arrayLength-1;
            double halfOfArrayLength = ((arrayLength) / 2); 
            int halfOfArrayLengthCeilled = (int)Math.Ceiling(halfOfArrayLength);

            for (int i = 0; i < halfOfArrayLengthCeilled; i++, numberLength--)
            {
                if(!isSameNumber(numberAsArray[i], numberAsArray[numberLength])){
                    return false;
                }

                if(isMoreThanHalfChecked(numberLength, i))
                {
                    break;
                }
            }
        
            return true;
        }

        private static Boolean isSameNumber(char value1, char value2){
            if (value1 == value2)
            {
                return true;
            }

            return false;
        }

        private static Boolean isMoreThanHalfChecked(int numberLength, int currentPosition)
        {
            if (numberLength < currentPosition)
            {
                return true;
            }
            return false;
        }

        public static String reverseNumber(String number)
        {
            char[] numberAsArray = number.ToArray();
            int numberLength = numberAsArray.Length - 1;
            String reverseNumber = null;
            

            for(int i = numberLength; i >= 0; i--){
                reverseNumber += numberAsArray[i];
            }

            return reverseNumber;

        }

        public static String makeAddition(String number, String reverseNumber)
        {
            int result = int.Parse(number) + int.Parse(reverseNumber);

            return result.ToString();
        }

        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int numberOfAdditions = 0;
            String reversedNumber;

            while (!isPalindrome(input))
            {
               reversedNumber = reverseNumber(input);
               input = makeAddition(input, reversedNumber);
               numberOfAdditions++;
            }

            Console.Write(input + " " + numberOfAdditions);

            
           
        }

    }
}

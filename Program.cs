using System;
using System.Collections.Generic;

namespace CreditCardChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CREDIT CARD CHECKER");
            Console.WriteLine("Input your credit card number");

            //take input from the user, convert it to int64 and remove the last digit of the unput and save it in a variable
            long creditCardNumber = long.Parse(Console.ReadLine());
            long creditCardLastNumber = creditCardNumber % 10;
            creditCardNumber = creditCardNumber / 10;

            //create a list and store the digits of the credit card number
            List<long> creditCardNumberList = new List<long>();
            while (creditCardNumber > 0)
            {
                creditCardNumberList.Add(creditCardNumber % 10);
                creditCardNumber = creditCardNumber / 10;
            }

            //starting with the first number in the list, multiply every second number by two
            for (int i = 0; i < creditCardNumberList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    creditCardNumberList[i] = creditCardNumberList[i] * 2;
                }
            }

            //if you get a two digit number, then add the two digits
            for (int i = 0; i < creditCardNumberList.Count; i++)
            {
                if (creditCardNumberList[i] > 9)
                {
                    creditCardNumberList[i] = creditCardNumberList[i] % 10 + creditCardNumberList[i] / 10;
                }
            }

            //add all the numbers in the list together
            long creditCardNumberSum = 0;
            foreach (long number in creditCardNumberList)
            {
                creditCardNumberSum += number;
            }

            //add the creditCardLastNumber to the sum
            creditCardNumberSum += creditCardLastNumber;

            if (creditCardNumberSum % 10 == 0)
            {
                Console.WriteLine("The credit card is VALID");
            }
            else
            {
                Console.WriteLine("The credit card is INVALID");
            }

            Console.ReadLine();
        }
    }
}
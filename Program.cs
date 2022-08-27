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

            /*//create a list to store the digits of the credit card number
            var creditCardNumberList = new List<long>();
            //loop through the credit card number and add the digits to the list
            while (creditCardNumber > 0)
            {
                creditCardNumberList.Add(creditCardNumber % 10);
                creditCardNumber = creditCardNumber / 10;
            }
            
            creditCardNumberList.ForEach(Console.WriteLine);*/



            //Console.WriteLine(creditCardNumberMultiplied);
            //Every time you have a two-digit number, just add those digits together for a one-digit result
            for (int i = 0; i < creditCardNumberMultiplied.ToString().Length; i++)
            {
                if (i % 2 == 0)
                {
                    creditCardNumberMultiplied += creditCardNumberMultiplied % 10;
                    creditCardNumberMultiplied = creditCardNumberMultiplied / 10;
                }
            }

            creditCardNumber = creditCardNumberMultiplied + creditCardLastNumber;
            
            //print true if the long creditCardNumber is divisible by 10
            if (creditCardNumber % 10 == 0)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }


        }
    }
}
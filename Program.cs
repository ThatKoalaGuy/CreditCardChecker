namespace CreditCardChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CREDIT CARD CHECKER");
            Console.WriteLine("Input your credit card number");

            //take input from the user, parse it into an int64 and remove the last digit and save it in a variable and remove any whitespaces
            long creditCardNumber = long.Parse(Console.ReadLine().Replace(" ", ""));


            









        }
    }
}
using System;

namespace DPO_Paygate_Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello PDO Paygate South Africa!");
            Console.WriteLine("");

            int total = Fibonacci.Calculate();

            Console.WriteLine("The sum total of Fibonacci odd numbers in the sequence is {0} where the sum total is less than 3000000", total);
            Console.ReadLine();
        }
    }
}

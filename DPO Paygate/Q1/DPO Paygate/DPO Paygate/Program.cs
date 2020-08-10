using System;

namespace DPO_Paygate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello PDO Paygate South Africa!");
            Console.WriteLine("");

            int sumOfMultiples = 0;
            for(int x = 0; x <= 900; x++)
            {
                if(x % 2 == 0 || x % 4 == 0)
                {
                    sumOfMultiples += x;
                }
                
            }

            Console.WriteLine("Total sum of multiples below 900: {0}", sumOfMultiples);
            Console.ReadLine();
        }
    }
}

using System;
using System.Globalization;
using System.Numerics;

namespace DPO_Paygate_Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello PDO Paygate South Africa!");
            Console.WriteLine("");

            const long NUMBER = 2310;
            long primeFactor = 0;
            long maxPrimeFactor = 0;
           
            for (long x = NUMBER; x > 0; x--)
            {
                //Check Factor
                if(NUMBER % x == 0)
                {
                    //Check Prime Number
                    if (IsPrimeNumber(x))
                    {
                        primeFactor = x;
                        if(primeFactor > maxPrimeFactor)
                        {
                            maxPrimeFactor = primeFactor;
                        }
                    }
                }
            }

            Console.WriteLine("Largest Prime Factor {0}", maxPrimeFactor);
            Console.ReadLine();
        }

        static bool IsPrimeNumber(long number)
        {
            bool success = true;
            for(long y = number -1; y > 1; y--)
            {
                decimal temp = number / (decimal)y;
                bool check = int.TryParse(temp.ToString(), out int result);

                if (check)
                {
                    success = false;
                    break;
                }
            }
            return success;
        }
    }
}

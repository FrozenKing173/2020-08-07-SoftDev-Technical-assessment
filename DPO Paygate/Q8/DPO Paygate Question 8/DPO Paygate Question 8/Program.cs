using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Text;

namespace DPO_Paygate_Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello PDO Paygate South Africa!");
            Console.WriteLine();

            const int NUMBER = 10000;
            StringBuilder allPrimaryNumbers = new StringBuilder();
            for(int x = NUMBER; x > 0; x--)
            {
                if (IsPrimeNumber(x))
                {
                    allPrimaryNumbers.Append(x + ",");
                }
            }

            allPrimaryNumbers.Remove(allPrimaryNumbers.Length - 1, 1);

            //Console.WriteLine(allPrimaryNumbers.ToString());
            //Console.ReadLine();

            string[] primaryNumbers = allPrimaryNumbers.ToString().Split(',');
            string[] tenLastPrimaryNumbers = new string[10];
            Array.Copy(primaryNumbers, primaryNumbers.Length - 11, tenLastPrimaryNumbers, 0, 10);
            Console.WriteLine("The last 10 prime numbers are as follows: ");
            for(int x = 0; x < tenLastPrimaryNumbers.Length; x++)
            {
                Console.Write(tenLastPrimaryNumbers[x].ToString());
                if ((x+1) < tenLastPrimaryNumbers.Length)
                    Console.Write(", ");

            }

            Console.WriteLine();
            Console.WriteLine();

            int sum = 0;
            for (int x = 0; x < tenLastPrimaryNumbers.Length; x++)
            {
                int y = int.Parse(tenLastPrimaryNumbers[x]);
                if (y % 7 == 3)
                {
                    sum += y;
                }
            }
            Console.WriteLine("The sum of values which have a remainder of 3 when devided by 7: {0}", sum);
            Console.ReadLine();
        }

        static bool IsPrimeNumber(int number)
        {
            bool success = true;
            for (int y = number - 1; y > 1; y--)
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

using System;
using System.Diagnostics;

namespace DPO_Paygate_Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello PDO Paygate South Africa!");
            Console.WriteLine("");

            bool success = false;
            int counter = 20;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (!success)
            {
                bool check = true;
                counter += 20;
                for (int x = 1; x <= 20; x++)
                {
                    if (counter % x != 0)
                    {
                        check = false;
                        break;
                    }
                       
                }

                if (check)
                    success = true;
            }
            stopwatch.Stop();

            Console.WriteLine("The smallest integer that is able toe evenly devide between [1..20] is {0} and the time it took was {1}ms", counter, stopwatch.ElapsedMilliseconds);
            Console.ReadLine();

        }
    }
}

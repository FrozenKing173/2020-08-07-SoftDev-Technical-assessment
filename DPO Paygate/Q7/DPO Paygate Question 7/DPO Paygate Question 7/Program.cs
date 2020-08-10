using System;

namespace DPO_Paygate_Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello PDO Paygate South Africa!");
            Console.WriteLine("");

            DateTime date = new DateTime().AddYears(1900).AddMonths(1).AddDays(0);
            DateTime endDate = new DateTime().AddYears(1999).AddMonths(11).AddDays(30);

            Console.WriteLine("Dates between the Twentieth Century {0} - {1}", date.ToShortDateString(), endDate.ToShortDateString());
            Console.WriteLine();

            // During twentieth century(1 Jan 1901 to 31 Dec 2000)
            // How many Saturdays fell in the second of the month
            int countSaturdays = 0;
            while (date.Year <= 2000)
            {
                if(date.Day == 2)
                {
                    if (date.DayOfWeek == DayOfWeek.Saturday)
                        countSaturdays++;
                }
              
                date = date.AddDays(1);
            }

            Console.WriteLine("Number of Saturdays that fell on the second of the month during the twentieth century {0}", countSaturdays);
            Console.ReadLine();
        }
    }
}

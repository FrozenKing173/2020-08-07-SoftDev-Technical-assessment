using System;
using System.Collections.Generic;
using System.Text;

namespace DPO_Paygate_Question_3
{
    public static class Fibonacci
    {
        private static int _sum = 0;

        static Fibonacci() { }

        public static int Calculate(int prev = 0, int next = 0)
        {
            // Base check
            // Below is hard coded to start the initial fibonacci sequence
            if (prev == 0 && next == 0)
            {
                if (1 % 2 != 0)
                {
                    _sum += 1;
                }
                return Calculate(0, 1);
            }
            
            // Process the recursive calculation
            int temp = next; 
            next = prev + next;     
            prev = temp;

            // Pre-check constraint limitation
            int constraint = _sum + next;
            if (constraint > 3000000)
                return _sum;

            // Final Check and calculation
            if (next % 2 != 0)
            {
                _sum += next;
            }
            if (next < 3000000)
            {
                return Calculate(prev, next);
            }

            // Exit recursive execution
            return _sum;
        }
    }
}

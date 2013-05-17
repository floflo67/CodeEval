using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Easy
{
    class SumOfPrimes
    {
        public SumOfPrimes()
        {
            int j = 0;
            int i = 2;
            int number = 0;
            while(j != 1000)
            {
                if(isPrime(i))
                {
                    number += i;
                    j++;
                }
                i++;
            }

            Console.WriteLine(number);
        }

        public static bool isPrime(int number)
        {
            for(int i = 2 ; i <= Math.Sqrt(number) ; i++)
            {
                if(number % i == 0)
                    return false;
            }

            return true;
        }
    }
}

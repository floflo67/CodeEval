using System.Linq;

namespace CodeEval_Easy
{
    class PrimePalindrome
    {
        public PrimePalindrome()
        {
            for(int i = 1000 ; i > 0 ; i--)
            {
                if(isPrime(i))
                {
                    if(i > 99)
                    {
                        if(i.ToString().ElementAt(0) == i.ToString().ElementAt(2))
                        {
                            System.Console.WriteLine(i);
                            break;
                        }
                    }
                }
            }
        }

        public bool isPrime(int number)
        {
            for(int i = 2 ; i <= System.Math.Sqrt(number) ; i++)
            {
                if(number % i == 0)
                    return false;
            }

            return true;
        }
    }
}

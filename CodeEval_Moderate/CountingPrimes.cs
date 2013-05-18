namespace CodeEval_Moderate
{
    class CountingPrimes
    {
        public CountingPrimes(string line)
        {
            string[] str = line.Split(new char[] { ',' });
            int N = int.Parse(str[0]);
            int M = int.Parse(str[1]);

            int s = CountPrimes(N, M);
            System.Console.WriteLine(s);
        }

        public int CountPrimes(int N, int M)
        {
            int j = 0;

            for(int i = N ; i <= M ; i++)
            {
                if(isPrime(i))
                    j++;
            }
            return j;
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

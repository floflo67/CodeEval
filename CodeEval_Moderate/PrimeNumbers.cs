namespace CodeEval_Moderate
{
    class PrimeNumbers
    {
        public PrimeNumbers(string line)
        {
            int N = int.Parse(line);
            string output = "2";
            if(N < 2)
                System.Console.WriteLine("NULL");
            else
            {
                for(int i = 3 ; i < N ; i = i + 2)
                {
                    if(isPrime(i))
                        output += "," + i;
                }
                System.Console.WriteLine(output);
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

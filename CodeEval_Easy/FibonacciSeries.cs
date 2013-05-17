namespace CodeEval_Easy
{
    class FibonacciSeries
    {
        public FibonacciSeries(string line)
        {
            int number = int.Parse(line);
            System.Console.WriteLine(fib(number));
        }

        public int fib(int value)
        {
            if(value == 0)
                return 0;
            if(value == 1)
                return 1;
            else
                return fib(value - 1) + fib(value - 2);
        }
    }
}

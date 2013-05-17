namespace CodeEval_Easy
{
    class SumOfDigits
    {
        public SumOfDigits(string line)
        {
            int result = 0;
            foreach(char c in line)
            {
                result += int.Parse(c.ToString());
            }
            System.Console.WriteLine(result);
        }
    }
}

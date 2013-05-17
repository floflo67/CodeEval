namespace CodeEval_Easy
{
    class MultiplesOfANumber
    {
        public MultiplesOfANumber(string line)
        {
            string[] str = line.Split(new char[] { ',' });
            new MultiplesOfANumber(int.Parse(str[0]), int.Parse(str[1]));
        }

        public MultiplesOfANumber(int x, int n)
        {
            for(int i = 1 ; i < x ; i++)
            {
                if(i * n >= x)
                {
                    System.Console.WriteLine(i * n);
                    break;
                }
            }
        }
    }
}

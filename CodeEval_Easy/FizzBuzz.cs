namespace CodeEval_Easy
{
    class FizzBuzz
    {
        public FizzBuzz(int A, int B, int N)
        {
            string output = "";
            for(int i = 1 ; i <= N ; i++)
            {
                if(i % A == 0 && i % B == 0)
                {
                    output += "FB ";
                }
                else if(i % A == 0)
                {
                    output += "F ";
                }
                else if(i % B == 0)
                {
                    output += "B ";
                }
                else
                {
                    output += i + " ";
                }
            }
            System.Console.WriteLine(output);
        }

        public FizzBuzz(string line)
        {
            string[] str = line.Split(new char[] { ' ' });
            new FizzBuzz(int.Parse(str[0]), int.Parse(str[1]), int.Parse(str[2]));
        }
    }
}

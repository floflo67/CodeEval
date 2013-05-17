namespace CodeEval_Easy
{
    class NModM
    {
        public NModM(string line)
        {
            string[] str = line.Split(new char[] { ',' });
            new NModM(int.Parse(str[0]), int.Parse(str[1]));
        }

        public NModM(int N, int M)
        {
            while(N >= M)
                N -= M;

            System.Console.WriteLine(N);
        }
    }
}

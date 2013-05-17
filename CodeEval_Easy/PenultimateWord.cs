namespace CodeEval_Easy
{
    class PenultimateWord
    {
        public PenultimateWord(string line)
        {
            string[] str = line.Split(new char[] { ' ' });
            int max = str.Length;

            System.Console.WriteLine(str[max-2]);
        }
    }
}

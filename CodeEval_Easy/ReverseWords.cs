namespace CodeEval_Easy
{
    class ReverseWords
    {
        public ReverseWords(string line)
        {
            string[] str = line.Split(new char[] { ' ' });
            string output = "";

            foreach(string s in str)
            {
                output = s + " " + output;
            }

            System.Console.WriteLine(output);
        }
    }
}

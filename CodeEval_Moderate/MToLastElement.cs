namespace CodeEval_Moderate
{
    class MToLastElement
    {
        public MToLastElement(string line)
        {
            string[] str = line.Split(new char[] { ' ' });
            int length = str.Length;
            int M = int.Parse(str[length - 1]);

            if(M < length)
                System.Console.WriteLine(str[length - M - 1]);
        }
    }
}

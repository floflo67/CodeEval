namespace CodeEval_Easy
{
    class SwapCase
    {
        public SwapCase(string line)
        {
            string output = "";
            foreach(char c in line)
            {
                if(System.Char.IsUpper(c))
                    output += System.Char.ToLower(c);
                else
                    output += System.Char.ToUpper(c);
            }

            System.Console.WriteLine(output);
        }
    }
}

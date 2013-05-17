namespace CodeEval_Easy
{
    class MultiplicationTables
    {
        public MultiplicationTables()
        {
            for(int i = 1 ; i <= 12 ; i++)
            {
                string output = "";
                for(int j = 1 ; j <= 12 ; j++)
                {
                    string k = (i * j).ToString();
                    while(k.Length < 4)
                        k = " " + k;

                    output += k;
                }
                System.Console.WriteLine(output);
            }
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace CodeEval_Easy
{
    class CapitalizeWords
    {
        public CapitalizeWords(string line)
        {
            string[] str = line.Split(new char[] { ' ' });
            string output = "";
            foreach(string s in str)
            {
                if(s == str.Last())
                    output += s.Substring(0, 1).ToUpper() + s.Substring(1);
                else
                    output += s.Substring(0, 1).ToUpper() + s.Substring(1) + " ";
            }
            System.Console.WriteLine(output);
        }
    }
}

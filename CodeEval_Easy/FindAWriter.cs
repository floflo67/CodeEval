using System.Collections.Generic;
using System.Linq;

namespace CodeEval_Easy
{
    class FindAWriter
    {
        public FindAWriter(string line)
        {
            string[] str = line.Split(new char[] { '|' });
            string[] indexes = str[1].Split(new char[] { ' ' });
            string output = "";

            List<int> index = new List<int>();

            foreach(string s in indexes)
            {
                int ind = 0;
                int.TryParse(s, out ind);
                if(ind != 0)
                    index.Add(ind);
            }

            foreach(int i in index)
                output += str[0].ElementAt(i - 1);

            System.Console.WriteLine(output);
        }
    }
}

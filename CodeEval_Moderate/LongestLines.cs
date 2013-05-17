using System.Collections.Generic;
using System.Linq;

namespace CodeEval_Moderate
{
    class LongestLines
    {
        public LongestLines(int N, List<string> list)
        {
            list = list.OrderByDescending(x => x.Length).ToList();
            for(int i = 0 ; i < N ; i++)
                System.Console.WriteLine(list[i]);
        }
    }
}

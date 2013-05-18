using System.Collections.Generic;
using System.Linq;

namespace CodeEval_Moderate
{
    class ArrayAbsurdity
    {
        public ArrayAbsurdity(string line)
        {
            string[] str = line.Split(new char[] { ';' });
            string[] array = str[1].Split(new char[] { ',' });
            List<string> list = new List<string>();

            foreach(string s in array)
            {
                if(list.Contains(s))
                    System.Console.WriteLine(s);
                else
                    list.Add(s);
            }
        }
    }
}

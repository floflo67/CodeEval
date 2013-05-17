using System.Collections.Generic;
using System.Linq;

namespace CodeEval_Easy
{
    class UniqueElements
    {
        public UniqueElements(string line)
        {
            string[] str = line.Split(new char[] { ',' });
            List<int> list = new List<int>();
            foreach(string s in str)
            {
                list.Add(int.Parse(s));
            }
            list = list.Distinct().ToList();
            string output = "";
            foreach(int i in list)
            {
                if(i == list.Last())
                    output += i.ToString();
                else
                    output+= i.ToString() + ",";
            }
            System.Console.WriteLine(output);
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CodeEval_Easy
{
    class SetIntersection
    {
        public SetIntersection(string line)
        {
            string[] str = line.Split(new char[] { ';' });
            string[] str1 = str[0].Split(new char[] { ',' });
            string[] str2 = str[1].Split(new char[] { ',' });

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            foreach(string s in str1)
            {
                list1.Add(int.Parse(s));
            }

            foreach(string s in str2)
            {
                list2.Add(int.Parse(s));
            }

            List<int> result = list1.Distinct().Intersect(list2.Distinct()).Distinct().ToList();

            string output = "";
            foreach(int i in result)
            {
                if(i == result.Last())
                    output += i.ToString();
                else
                    output += i.ToString() + ",";
            }
            System.Console.WriteLine(output);
        }
    }
}

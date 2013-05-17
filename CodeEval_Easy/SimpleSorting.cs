using System.Collections.Generic;
using System.Linq;

namespace CodeEval_Easy
{
    class SimpleSorting
    {
        public SimpleSorting(string line)
        {
            string[] str = line.Split(new char[] { ' ' });
            List<double> list = new List<double>();
            string output = "";

            foreach(string s in str)
            {
                list.Add(double.Parse(s));
            }

            list.Sort();

            foreach(double i in list)
            {
                if(i == list.Last())
                    output += i.ToString("0.000");
                else
                    output += i.ToString("0.000") + " ";
            }

            System.Console.WriteLine(output);
        }
    }
}

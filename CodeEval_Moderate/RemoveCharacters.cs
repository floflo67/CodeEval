using System.Collections.Generic;
using System.Linq;

namespace CodeEval_Moderate
{
    class RemoveCharacters
    {
        public RemoveCharacters(string line)
        {
            string[] str = line.Split(new char[] { ',' });
            string output = str[0];
            string temp = "";

            foreach(char c in str[1].Trim())
            {
                temp = output;
                output = "";
                for(int i = 0 ; i < temp.Length ; i++)
                {
                    if(temp[i] != c)
                        output += temp[i];
                }
            }

            System.Console.WriteLine(output);
        }
    }
}

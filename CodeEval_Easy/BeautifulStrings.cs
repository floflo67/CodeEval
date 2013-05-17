using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeEval_Easy
{
    class BeautifulStrings
    {
        public BeautifulStrings(string line)
        {
            List<char> list = line.ToLower().Where(Char.IsLetter).ToList();
            List<char> resultList = new List<char>();
            List<int> listNumber = new List<int>();
            int result = 0;

            foreach(char c in list)
            {
                if(resultList.Contains(c))
                {
                    int index = resultList.IndexOf(c);
                    listNumber[index] += 1;
                }
                else
                {
                    resultList.Add(c);
                    listNumber.Add(1);
                }
            }

            int value = 26;

            foreach(char c in resultList)
            {
                int max = 0;
                foreach(int i in listNumber)
                {
                    if(i == 0)
                        continue;
                    else
                    {
                        if(i > max)
                            max = i;
                    }
                }

                int index = listNumber.IndexOf(max);
                result += value * max;
                value--;
                listNumber[index] = 0;

            }


            Console.WriteLine(result);

        }
    }
}

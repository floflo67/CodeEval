using System.Collections.Generic;
using System.Linq;

namespace CodeEval_Moderate
{
    class Pangrams
    {
        public Pangrams(string line)
        {
            List<byte> list = returnAsListBytes(line);

            if(list.Count != 26 && list.Count != 0)
            {
                byte[] res = populateArray(list);
                char[] ch = System.Text.Encoding.ASCII.GetChars(res);

                string output = "";
                foreach(char c in ch)
                    output += c;

                System.Console.WriteLine(output.ToLower());

            }
            else if(list.Count == 0)
            {
                System.Console.WriteLine("abcdefghijklmnopqrstuvwxyz");
            }
            else
                System.Console.WriteLine("NULL");
        }

        public List<byte> returnAsListBytes(string line)
        {
            byte[] ascii = System.Text.Encoding.ASCII.GetBytes(line.ToUpper());
            List<byte> list = new List<byte>();

            foreach(byte b in ascii)
            {
                if(b >= 65 && b <= 90)
                    list.Add(b);
            }
            list = list.Distinct().ToList();
            list.Sort();
            return list;

        }

        public byte[] populateArray(List<byte> list)
        {
            int j = 0;
            byte[] res = new byte[26 - list.Count];

            for(int i = 0 ; i <= list.Count - 1 ; i++)
            {
                if(i == list.Count - 1 && list[i] < 90)
                {
                    for(int a = 90 - list[i] ; a > 0 ; a--)
                    {
                        res[j] = (byte)(90 - a + 1);
                        j++;
                    }
                }
                else if(i == 0 && list[i] > 65)
                {
                    for(int a = 0 ; list[i] > 65 + a ; a++)
                    {
                        res[j] = (byte)(65 + a);
                        j++;
                    }
                }
                else if(list.Count - 1 != i)
                {
                    int k = 1;
                    while(list[i] + k != list[i + 1])
                    {
                        byte test = (byte)(list[i] + k);
                        res[j] = test;
                        j++;
                        k++;
                    }
                }
            }
            return res;
        }
    }
}

using System.Linq;

namespace CodeEval_Moderate
{
    class ReverseAndAdd
    {
        public ReverseAndAdd(string line)
        {
            int j = 0;
            while(!isPalindrome(line) && j < 1000)
            {
                line = ReversAndAdd(line);
                j++;
            }
            System.Console.WriteLine(j +" " + line);
        }

        public bool isPalindrome(string number)
        {
            bool b = false;
            int length = number.Length;
            for(int i = 0 ; i < length ; i++)
            {
                if(number.ElementAt(i) == number.ElementAt(length - i - 1))
                    b = true;
                else
                {
                    b = false;
                    break;
                }
            }

            return b;
        }

        public string ReversAndAdd(string number)
        {
            int num = 0;

            int length = number.Length;
            string tempNum = "";
            for(int i = 1 ; i <= length ; i++)
            {
                tempNum += number.ElementAt(length - i);
            }

            num = int.Parse(tempNum) + int.Parse(number);
            return num.ToString();
        }
    }
}

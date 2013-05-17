using System.Linq;

namespace CodeEval_Easy
{
    class HexToDecimal
    {
        public HexToDecimal(string line)
        {
            int length = line.Length;
            double result = 0;
            for(int i = 0 ; i < length ; i++)
            {
                result += hexConvert(line.Substring(length - i - 1, 1), i);
            }
            System.Console.WriteLine(result);
        }

        public double hexConvert(string number, int rank)
        {
            int value = 0;
            double val = 0;
            if(number.ToLower() == "a")
                value = 10;
            else if(number.ToLower() == "b")
                value = 11;
            else if(number.ToLower() == "c")
                value = 12;
            else if(number.ToLower() == "d")
                value = 13;
            else if(number.ToLower() == "e")
                value = 14;
            else if(number.ToLower() == "f")
                value = 15;
            else
                value = int.Parse(number);
            val = value * System.Math.Pow(16, rank);
            return val;
        }
    }
}

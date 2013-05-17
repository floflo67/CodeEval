using System.Linq;

namespace CodeEval_Easy
{
    class HappyNumbers
    {
        public HappyNumbers(string line)
        {
            string output = "0";
            if(isHappy(int.Parse(line)))
                output = "1";
            System.Console.WriteLine(output);
        }

        public bool isHappy(int value)
        {
            double result = value;
            double resultTemp = 0;

            int j = 0;

            while(result != 1 && j < 40)
            {
                resultTemp = 0;
                for(int i = 0 ; i < result.ToString().Length ; i++)
                {
                    resultTemp += System.Math.Pow(double.Parse(result.ToString().Substring(i, 1)), 2.0);
                }
                j++;
                result = resultTemp;
            }

            if(result == 1)
                return true;
            return false;
        }
    }
}

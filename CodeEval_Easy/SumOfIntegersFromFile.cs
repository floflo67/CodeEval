using System.Collections.Generic;

namespace CodeEval_Easy
{
    class SumOfIntegersFromFile
    {
        public SumOfIntegersFromFile(List<int> list)
        {
            int result = 0;
            foreach(int i in list)
                result += i;

            System.Console.WriteLine(result);
        }
    }
}

using System.Linq;

namespace CodeEval_Moderate
{
    class TrailingString
    {
        public TrailingString(string line)
        {
            string[] str = line.Split(new char[] { ',' });
            if(str[0].EndsWith(str[1]))
                System.Console.WriteLine("1");
            else
                System.Console.WriteLine("0");
        }
    }
}

using System.Linq;

namespace CodeEval_Easy
{
    class RightmostChar
    {
        public RightmostChar(string line)
        {
            string[] str = line.Split(new char[] { ',' });
            int index = str[0].IndexOf(str[1]);
            System.Console.WriteLine(index);
        }
    }
}

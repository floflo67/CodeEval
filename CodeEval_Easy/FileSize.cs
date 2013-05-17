using System.IO;
using System.Collections.Generic;

namespace CodeEval_Easy
{
    class FileSize
    {
        public FileSize(string line)
        {
            FileInfo f = new FileInfo(line);
            System.Console.WriteLine(f.Length);
        }
    }
}

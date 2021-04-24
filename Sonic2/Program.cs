using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonic2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fs1 = new StreamReader(args[0]);
            StreamWriter result = new StreamWriter(args[0] + ".name");

            string s = "";
            while (s != null)
            {
                s = fs1.ReadLine();
                if (s != null)
                {
                    var ss = s.Split(',');
                    if (ss.Count() > 4)
                        if ((ss[2].Length > 3)&((ss[3].Length > 3)))
                            result.WriteLine(ss[2].Substring(1, ss[2].Length - 2)+" "+ ss[3].Substring(1, ss[3].Length - 2));
                }
            }
            result.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2
{
    internal class SplitString
    {
        public void SplitMyString()
        {
            int i;
            do
            {
                Myconsole.PrintInfo("Skriv tre meningar med mellanslag mellan\n");
                string input = Console.ReadLine();
                string[] mystring = input.Split(' ');
                i = mystring.Length;
                if (i >= 3)
                    Myconsole.PrintInfo($"Element index: {mystring[2]}");
            } while (i < 3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkNineSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberStart = 5;
            int step = 7;
            int numberMax = 103;

            for (int i = numberStart; i <= numberMax; i+=step)
            {
                Console.WriteLine(i);
            }
        }
    }
}

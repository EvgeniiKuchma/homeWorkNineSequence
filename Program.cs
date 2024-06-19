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
            int risingNumber = 7;
            int numberMax = 103;

            while (numberStart <= numberMax)
            {
                Console.WriteLine(numberStart);
                numberStart += risingNumber;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(A(7));
            Console.ReadKey();

        }
        static int A(int i)
        {
            int j = 1;
            while (i > j)
                j += i--;
            return j;
        }
    }
}

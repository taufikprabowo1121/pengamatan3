using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengamatan3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester t = new Tester();
            //output with params
            t.DisplayVals(5, 6, 7, 8);
            //output without params
            int[] explicitArray = new int[5] { 1, 2, 3, 4, 5};
            t.DisplayVals(explicitArray);

            Console.ReadKey();

        }
    }
}

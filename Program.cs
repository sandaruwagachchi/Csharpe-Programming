using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=80;
            int y=70;
            int z=56;
            int sum;
            double avg;

            sum = x + y + z;
            avg = sum / 3;

            Console.WriteLine("SUM: " + sum);
            Console.WriteLine("AVERAGE: " + avg);
            Console.ReadKey();

            

        }
    }
}

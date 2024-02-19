using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            double z;
            double sum;
            double avg;

            Console.WriteLine("Please Enter Integer Number:");
            x = Convert.ToInt32(Console.ReadKey());
            Console.WriteLine("Please Enter Integer Number:");
            y = Convert.ToInt32(Console.ReadKey());
            Console.WriteLine("Please Enter Decimal Number:");
            z = Convert.ToDouble(Console.ReadKey());



            sum = x + y + z;
            avg = sum / 3.00;

            Console.WriteLine("SUM: " + sum);
            Console.WriteLine("AVERAGE: " + avg);
            Console.ReadKey();


        }
    }
}

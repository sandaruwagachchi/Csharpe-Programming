using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   class Cylinder
    {
        double radius;
        double length;

        public Cylinder()
        {
            radius = 5;
            length = 10;  
        }
        public Cylinder(double radius,double length)
        {
            this.radius = radius;
            this.length = length;
        }

        ~Cylinder()
        {

        }

        public void calArea()
        {
            double sa = (2 * 3.14 * radius * length) + (2 * 3.14 * radius * radius);
            Console.WriteLine("Surface Area Of Cylinder: {0}", sa);

        }
        public void calVolume()
        {
            double vol = 3.14 * radius * radius * length;
            Console.WriteLine("Volume Of The Cylinder: {0}", vol);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            c1.calArea();
            c1.calVolume();

            Cylinder c2 = new Cylinder(22.5, 31.6);
            c2.calArea();
            ////////c2.calVolume();

            Console.ReadKey();
        }
    }
}

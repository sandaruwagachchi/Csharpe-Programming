using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Shape
        {
            int length;
            protected int width;
            protected int heigth;
            public int radius;

            public void getData()
            {
                Console.WriteLine("Enter Length:");
                length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Width:");
                width= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Heigth");
                heigth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Radius");
                radius = Convert.ToInt32(Console.ReadLine());
            }
        }
        class Rectangle : Shape
        {
            public void display()
            {
                Console.WriteLine("Width:{0}", width);
                Console.WriteLine("Heigth:{0}", heigth);
            }
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.getData();
            r.display();
            Console.ReadKey();
        }
    }
}

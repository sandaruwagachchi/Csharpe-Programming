using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        class Student
        {
            protected String sno;
            protected String name;


            public void inputData()
            {
                Console.WriteLine("Enter sno:");
                sno = Console.ReadLine();
                Console.WriteLine("Enter Your Name:");
                name = Console.ReadLine();

            }
           class Subject : Student
            {
                protected int sm;
                protected int mm;
                protected int em;
                double avg;
                String grade;

                public void inputMark()
                {
                    Console.WriteLine("Enter Science Mark:");
                    sm = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Maths Mark:");
                    mm = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter English Mark:");
                    em = Convert.ToInt32(Console.ReadLine());

                }
                public void calGrade()
                {
                     avg = (sm + mm + em) / 3.0;
                    if(avg<50)
                    {
                         grade = "Fail";
                    }
                    else
                    {
                         grade = "Pass";
                    }
                }
                public void displayResults()
                {
                    Console.WriteLine("Student No:{0}", sno);
                    Console.WriteLine("Name:{0}", name);
                    Console.WriteLine("Scince Mark:{0}", sm);
                    Console.WriteLine("Maths Mark:{0}", mm);
                    Console.WriteLine("Engish Mark:{0}", em);
                    Console.WriteLine("Avearge:{0}", avg);
                    Console.WriteLine("Grade:{0}", grade);
                }
            }
        }
        static void Main(string[] args)
        {
            Subject s1 = new Subject();
            s1.inputData();
            s1.i

         
        }
    }
}

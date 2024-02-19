using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Student
    {
        //member variable
        int sid;
        String name;
        int age;

        //default constructer

        public Student()
        {
            sid = 111;
            name = "xx";
            age = 11;
        }

        //paramiterized constructer

        public Student(int a,String b,int c)
        {
            sid = a;
            name = b;
            age = c;
        }

        //destructor

        ~Student()
        {

        }

        //member function
        public void input()
        {
            Console.WriteLine("Enter SID");
            sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("SID:{0}" ,sid);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
           // s1.input();
            s1.display();

            Student s2 = new Student(123,"sandaru",22);
            s2.display();

            Console.ReadKey();
        }
    }
}

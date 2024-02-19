using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    enum emptype { Clerk,Staff,Manager};
    class Employee
    {
        int eno;
        String name;
        String eType;
        double bs;
        double allowance;
        double netSalary;

        public void inputData()
        {
            Console.WriteLine("Enter Emp No");
            eno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Emo Type(Clerk,Staff,Manager");
            eType = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary");
            bs = Convert.ToDouble(Console.ReadLine());
        }
        public void calSalary()
        {
            if (eType == emptype.Clerk.ToString())
            {
                allowance = 2000;
            }
            else if (eType == emptype.Staff.ToString())
            {
                allowance = 3000;
            }
            else if (eType == emptype.Manager.ToString())
            {
                allowance = 4000;

            }
            netSalary = bs + allowance;
        }

        public void display()
        {
            Console.WriteLine("Emp No: {0}", eno);
            Console.WriteLine("Emp Name:{0}", name);
            Console.WriteLine("Basic Salary:{0}",bs);
            Console.WriteLine("Emp Type:{0}",eType);
            Console.WriteLine("Allowance:{0}",allowance);
            Console.WriteLine("Net Salary:{0}", netSalary);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.inputData();
            e.calSalary();
            e.display();
            Console.ReadKey();
        }
    }
}

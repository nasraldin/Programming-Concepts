using System;

namespace OOP
{
    class Employee
    {
        string name;
        int degree;
        double salary;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetDegree(int degree)
        {
            if (degree < 1)
                Console.WriteLine("degree is less than 1");
            this.degree = degree;
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public void EmpInfo()
        {
            Console.WriteLine($"Emp name is: {name}");
            Console.WriteLine($"Emp degree is: {degree}");
            Console.WriteLine($"Emp salary is: {salary}");
            Console.WriteLine($"------------------");
        }

        public void OverTime()
        {
            switch (degree)
            {
                case 1:
                    salary *= 1.2;
                    break;
                case 2:
                    salary *= 1.3;
                    break;
                case 3:
                    salary *= 1.4;
                    break;
                case 4:
                    salary *= 1.5;
                    break;
            }
        }
    }
}

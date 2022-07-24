using System;

namespace ConsoleApp85
{
    internal partial class Program
    {
        class Employee
        {
            private int id;
            private string name;
            private int age;
            private double salary;
            private double experince;

            public Employee(){ }

            public Employee(int id, string name, int age, double salary, double experince)
            {
                this.id = id;
                this.name = name;
                this.age = age;
                this.salary = salary;
                this.experince = experince;

            }

            public void employeeSayHello()
            {
                Console.WriteLine($"Hello my name is {this.name}.");
            }

        }
    }
}

using System;

namespace FreshFactory
{
  
        class Employee
        {
            private int id;
            private string name;
            private int age;
            private double salary;
            private double experince;
            private char gender;
            private bool IsManger;
            public Employee(){ }

            public Employee(int id, string name, int age, double salary, double experince,char gender,bool IsManger)
            {
                this.id = id;
                this.name = name;
                this.age = age;
                this.salary = salary;
                this.experince = experince; 
                this.gender = gender;
                this.IsManger = IsManger;
                

            }

            public void employeeSayHello()
            {
                Console.WriteLine($"Hello my name is {this.name}.");
            }

        }
    
}

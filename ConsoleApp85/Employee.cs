using System;

namespace FreshFactory
{
  
        class Employee
        {
            private int id;
            private string name;
            private int age;
            private double salaryPerHour;
            private double hours;
            private double experince;
            private char gender;
            private bool IsManger;
            private static int employeeCounter;
            public Employee(int id, string name,bool IsManger,double salaryPerHour)
            {
                this.id = id;
                this.name = name;
                this.IsManger = false;
                this.salaryPerHour = salaryPerHour;
                employeeCounter++;
            }

        public Double CalculateSalary()
        {
            double salary = hours * salaryPerHour;
            return salary;
        }
        public void employeeSayHello()
            {
                Console.WriteLine($"Hello my name is {this.name}.");
            }
            public string GetEmployeePostion()
              { 
            return IsManger ? "Manger" : "Prodaction-Employee";
             }
                
             public override string ToString() {
                
            return $"{name}:{id}\nage:{age}\ngender:{gender}\nposition:{GetEmployeePostion()}\nsalary:{CalculateSalary():F2}\nexperince:{experince}\n";
              }


    }

}

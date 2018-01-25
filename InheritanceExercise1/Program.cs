using System;

namespace InheritanceExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates Employee Object with name Libby and salary 2000 called employee1
            var employee1 = new Employee("Libby", 2000);
            // Instantiates TechnicalEmployee Object with name Zaynah called employee2
            var employee2 = new TechnicalEmployee("Zaynah");
            // Instantiates BusinessEmployee Object with name Winter called employee3
            var employee3 = new BusinessEmployee("Winter");

            // Output to the console window
            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
    class Employee
    {
        private static int noEmployees = 0; // total number of students - also used to generate ID 
        // Adding properties
        public int ID { get; }
        public string FullName { get; set; }
        public double BaseSalary { get; set; }
        // Adding methods
        public double getBaseSalary(){
            return this.BaseSalary;
        }
        public string getName(){
            return this.FullName;
        }
        public int getEmployeeID(){
            return this.ID;
        }
        public string toString(){
            return $"{this.ID} {this.FullName}";
        }
        public virtual string employeeStatus(){
            return $"{this.ID} {this.FullName} is in the company system";
        }
        // Adding constructors
        public Employee (string name, double baseSalary) {
            this.FullName = name;
            this.BaseSalary = baseSalary;
            this.ID = noEmployees++;
        }

    }

    class TechnicalEmployee : Employee
    {
        public int CheckIns { get; set; }
        public TechnicalEmployee (string name) : base(name, 75000) {

        }
        public override string employeeStatus(){
            return $"{this.ID} {this.FullName} has {this.CheckIns} successful check ins";
        }
    }

    class BusinessEmployee : Employee 
    {
        public int Budget { get; set; }
        public BusinessEmployee (string name) : base (name, 50000)
        {

        }
        public override string employeeStatus(){
            return $"{this.ID} {this.FullName} with a budget of {this.Budget}";
        }
    }
}

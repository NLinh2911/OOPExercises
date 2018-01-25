using System;

namespace InheritanceExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Alex", 22, "British");
            var student2 = new Student("Hieu", 21, "Vietnam");
            var student3 = new Student("Yuri", 25, "Japanese");
            var teacher1 = new Teacher("Sam", 34, "Polish");
            System.Console.WriteLine($"{teacher1.FullName} is a {teacher1.Age} year-old {teacher1.WorkStatus}");
            teacher1.GradeTest();
            student1.Eat();
            student2.Learn();
            student3.TakeTest();
        }
    }

    abstract class Person
    {
        // Adding properties
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        // abstract prop
        public abstract string WorkStatus { get; set; }
        // Adding methods
        public virtual void Speak () {
            System.Console.WriteLine("Can speak ...");
        }
        public abstract void Eat();
        // Adding constructors
        public Person (string name, int age, string nationality) {
            this.Nationality = nationality;
            this.Age = age;
            this.FullName = name;
        }
    }

    class Student : Person
    {
        public override string WorkStatus { get; set; } = "Student";
        public override void Eat(){
            System.Console.WriteLine($"{this.FullName} eats cheaply within a budget");
        }
        public void Learn (){
            System.Console.WriteLine($"{this.FullName} is learning");
        }
        public void TakeTest (){
            System.Console.WriteLine($"{this.FullName} must take a test");
        }
        public Student (string name, int age, string nationality) : base (name, age, nationality) {

        }
    }
    class Teacher : Person
    {
        public override string WorkStatus { get; set; } = "Teacher";
        public override void Eat(){
            System.Console.WriteLine($"{this.FullName} eats in the school's canteen");
        }
        public void Teach (){
            System.Console.WriteLine($"{this.FullName} is teaching");
        }
        public void GradeTest (){
            System.Console.WriteLine($"{this.FullName} must grade a test");
        }
        public Teacher (string name, int age, string nationality) : base (name, age, nationality) {

        }
    }
}

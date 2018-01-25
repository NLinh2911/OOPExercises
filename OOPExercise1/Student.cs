using System;

namespace OOPExercise1
{
    public class Student
    {
        // private fields
        private static int noStudents = 0;
        // Adding properties
        public string ID { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }

        // Adding Constructors
        public Student () {
            noStudents++;
        }
        public Student (string id, string fullname, DateTime birthdate) {
            this.ID = id;
            this.FullName = fullname;
            this.BirthDate = birthdate;
            noStudents++;
        }

        // Methods
        public static int CountStudents () {
            return noStudents;
        }
    }
}
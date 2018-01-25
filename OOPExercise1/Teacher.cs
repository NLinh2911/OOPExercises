using System;

namespace OOPExercise1
{
    public class Teacher
    {
        // private field
        private static int noTeachers = 0;
        //
        public string ID { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Role { get; set; }
        // Adding Constructors
        public Teacher () {
            noTeachers++;
        }
        public Teacher (string id, string fullname, DateTime birthdate) {
            this.ID = id;
            this.FullName = fullname;
            this.BirthDate = birthdate;
            noTeachers++;
        }
        
        // Methods
        public static int CountTeachers () {
            return noTeachers;
        }
    }
}
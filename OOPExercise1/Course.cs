using System;
using System.Collections.Generic;

namespace OOPExercise1 {
    public class Course {
        // each course has more than one teacher or teaching assistant
        // more than one student
        // private field
        private static int noCourses = 0;
        public string Title { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        // Adding Constructors
        public Course () {
            noCourses++;
        }
        public Course (string title) {
            this.Title = title;
            noCourses++;
        }
        // Methods
        public static int CountCourses () {
            return noCourses;
        }
        public int CountTeachers () {
            return this.Teachers.Count;
        }
        public int CountStudents () {
            return this.Students.Count;
        }
        public void AddTeacher (string id, string fullname, DateTime birthdate) {
            var newTeacher = new Teacher (id, fullname, birthdate);
            // update Teacher list
            this.Teachers.Add (newTeacher);
        }
        public void AddStudent (string id, string fullname, DateTime birthdate) {
            var newStudent = new Student (id, fullname, birthdate);
            // update Student list
            this.Students.Add (newStudent);
        }
        
    }
}
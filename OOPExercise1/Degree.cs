using System;
using System.Collections.Generic;

namespace OOPExercise1
{
    public class Degree
    {
        // private field
        private static int noDegrees = 0;
        public string Title { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

        // Adding Constructors
        public Degree () {
            noDegrees++;
        }
        public Degree (string title) {
            this.Title = title;
            noDegrees++;
        }
        // Methods
        public static int CountDegrees () {
            return noDegrees;
        }
        public int CountCourses () {
            return this.Courses.Count;
        }
        public Course CreateCourse (string title) {
            var newCourse = new Course(title);
            // update course list
            this.Courses.Add(newCourse);
            return newCourse;
        }
    }
}
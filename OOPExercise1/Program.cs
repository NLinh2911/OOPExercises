using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Create classes for an app that represents a school program 
            var myProgram = new UProgram("Information Technology");
            // With these methods, we pass params and instiate objects right in the method of upper-level class
            var myDegree = myProgram.CreateDegree("Bachelor");     
            var myCourse = myDegree.CreateCourse("Programming with C#");
            var myCourse2 = myDegree.CreateCourse("JavaScript for Beginner");
            // Question: should I instantiate Student separately and pass as param to AddStudent method?
            /*
            var newStudent1 = new Student(ST1, "James Smiths", new DateTime(1998, 5, 29));
            myCourse.AddStudent(newStudent1);
             */
            myCourse.AddStudent("ST1", "James Smiths", new DateTime(1998, 5, 29));
            myCourse.AddStudent("ST2", "Alex Chung", new DateTime(1998, 7, 19));
            myCourse.AddStudent("ST3", "Claire Foy", new DateTime(1998, 12, 11));
            myCourse.AddTeacher("TA1", "Chris Winston", new DateTime(1972, 3, 29));

            // display info
            System.Console.WriteLine($"The program is {myProgram.Title} and has {myProgram.CountDegrees()} degrees.");
            System.Console.WriteLine($"The program's degrees are:");
            for (int i = 0; i < myProgram.Degrees.Count; i++)
            {
                System.Console.WriteLine($"{i+1}. {myProgram.Degrees[i].Title}");
            }
            System.Console.WriteLine($"{myDegree.Title} of {myProgram.Title} has {myCourse.Title} course.");
            System.Console.WriteLine($"{myCourse.Title} has {myCourse.CountStudents()} students and {myCourse.CountTeachers()} teachers.");
            for (int i = 0; i < myCourse.Students.Count; i++)
            {
                System.Console.WriteLine($"{myCourse.Students[i].ID}. {myCourse.Students[i].FullName} - {myCourse.Students[i].BirthDate}");
            }
            var coursesString = String.Join(", ", myProgram.Degrees[0].Courses.Select(c=> c.Title));
            System.Console.WriteLine($"{myProgram.Degrees[0].Title} of {myProgram.Title} have {coursesString} courses.");
        }
    }
}

using System;
using System.Collections.Generic;

namespace OOPExercise1 {
    public class UProgram {
        // private field
        private static int noUPrograms = 0;
        public string Title { get; set; }
        public List<Degree> Degrees { get; set; } = new List<Degree>(); // must initialise first or NullReferenceException occurs 
        
        // Adding Constructors
        public UProgram () {
            noUPrograms++;
        }
        public UProgram (string title) {
            this.Title = title;
            noUPrograms++;
        }
        // Methods
        public static int CountUPrograms () {
            return noUPrograms;
        }
        public int CountDegrees () {
            return this.Degrees.Count;
        } 

        // Add a new degree to the program
        public Degree CreateDegree (string title) {
            var newDegree = new Degree(title);
            // update degree list
            this.Degrees.Add(newDegree);
            return newDegree;
        }
    }
}
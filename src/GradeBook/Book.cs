using System;
using System.Collections.Generic;



namespace GradeBook

{
    class Book {

        private List<double> grades;
        private string name;


        public Book(string name) 
        {
            this.name = name;
            grades = new List<double>();

        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);

        }


        public void showStatistics()
        {
            double result  = 0.0;
            double highGrade = double.MinValue;
            double minGrade = double.MaxValue;

            foreach(double grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
                minGrade = Math.Min(grade, minGrade);
                result+= grade;
            }
            
            result = result / grades.Count;
            Console.WriteLine(result);
            Console.WriteLine(highGrade);
            Console.WriteLine(minGrade);

        }
    }
}
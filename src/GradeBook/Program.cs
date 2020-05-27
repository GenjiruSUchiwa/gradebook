using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ecrire un programme qui permet de derterminer la moyennne des grades des étudiants en fonctions des grades de chaques étudiant
            **/

            List<double> grades = new List<double>() { 12.5, 3.2, 5.3, 4.5, 7.2 };

            double result  = 0.0;

            foreach(double grade in grades)
            {
                result+= grade;
            }
            
            result = result / grades.Count;
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using GradeBook;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ecrire un programme qui permet de derterminer la moyennne des grades des étudiants en fonctions des grades de chaques étudiant
            **/

            Book book = new Book("Arthur Conan Doyle, les Aventures de Sherlock Holmes !");

            book.AddGrade(8.2);
            book.AddGrade(5.2);
            book.AddGrade(4.2);
            book.AddGrade(3.2);
            book.AddGrade(4.2);

            book.showStatistics();

            

        }
    }
}

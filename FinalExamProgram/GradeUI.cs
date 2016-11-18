//Dawn Myers
//ITDEV 115-600
//Final Exam Program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamProgram
{
    class GradeUI
    {
        StudentS myStudentS;

        public void MainMethod()
        {
            myStudentS = new StudentS();
            string success;
            string gradeFile = "grades.txt";

            success = myStudentS.PopulateStudents(gradeFile);

            if(success == "success")
            {
                DisplayInfo();
            }
            else
            {
                Console.WriteLine("There was a failure in reading the file");
            }

            Console.Write("\nPress any key to exit...");
            Console.ReadLine();

        }

        void DisplayInfo()
        {
            Console.WriteLine("Student id\tLast Name\tAverage  \tGrade");

            for (int index = 0; index < myStudentS.ListLength; index++)
            {

                Console.WriteLine(" {0} \t {1}    \t {2}    \t {3}", myStudentS.StudentID(index), myStudentS.StudentLastName(index), myStudentS.StudentAverage(index), myStudentS.StudentGrade(index));
            }
        }
    }
}

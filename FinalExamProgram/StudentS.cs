//Dawn Myers
//ITDEV 115-600
//Final Exam Program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalExamProgram
{
    class StudentS
    {
        List<Student> theStudentList;

        public string PopulateStudents(string path)
        {
            theStudentList = new List<Student>();
            string studentText;
            FileInfo sourceFile = new FileInfo(@path);
            string success = "success";

            try
            {
                StreamReader theReader = sourceFile.OpenText(); //open the file
                studentText = theReader.ReadLine(); //puts the first line of the file's text into a string
                int numOfColumns = studentText.Split(',').Length; //assigns the column length to a variable
                string[] studentFields = new string[numOfColumns]; //creates an array to hold values based on number of columns
                Student theStudent = new Student();

                while(studentText != null)
                {
                    studentFields = studentText.Split(','); //puts each field into an element of the array
                    theStudent = new Student(studentFields[0], studentFields[1], studentFields[2]); //creates student with constructor

                    //I wanted to find a better way to do this instead of hardcoding. 
                    //First 3 elements aren't used to calculate grade.
                    //+=2 is used to skip over the current score/max score
                    //index + 3/4 is used to pass the current score/max score
                    for(int index = 0; index < numOfColumns - 3; index+=2)
                    {
                        theStudent.EnterGrade(int.Parse(studentFields[index + 3]), int.Parse(studentFields[index + 4]));
                    }

                    theStudent.CalGrade();
                    theStudentList.Add(theStudent);
                    studentText = theReader.ReadLine(); //grabs the next line of the file, and cycles through again
                }
            }

            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                success = "failure";
            }

            return success;
        }

        public int ListLength
        {
            get { return theStudentList.Count; }
        }

        public string StudentID(int index)
        {
            return theStudentList.ElementAt(index).ID;
        }
        public string StudentLastName(int index)
        {
            return theStudentList.ElementAt(index).NameLast;
        }

        public string StudentGrade(int index)
        {

            theStudentList.ElementAt(index).CalGrade();
            return theStudentList.ElementAt(index).LetterGrade;
        }

        public float StudentAverage(int index)
        {
            theStudentList.ElementAt(index).CalGrade();
            return theStudentList.ElementAt(index).Average;
        }
    }
}

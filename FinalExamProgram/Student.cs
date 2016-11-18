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
    class Student
    {
        string nameFirst;
        string nameLast;
        string studentID;
        List<int> earned;
        List<int> possible;
        float average;
        string letterGrade;

        public Student() //default constructor
        {
            studentID = null;
            earned = new List<int>();
            possible = new List<int>();
        }

        public Student(string id)  //overloaded constructor
        {
            studentID = id;
            nameFirst = null;
            nameLast = null;
            earned = new List<int>();
            possible = new List<int>();
        }

        public Student(string id, string first, string last)  //overloaded constructor
        {
            nameFirst = first;
            nameLast = last;
            studentID = id;
            earned = new List<int>();
            possible = new List<int>();
        }

        public void EnterGrade(int earnedValue, int possValue)
        {
            earned.Add(earnedValue);
            possible.Add(possValue);
        }

        public float Average
        {
            get { return average; }
        }

        public string LetterGrade
        {
            get { return letterGrade; }
        }

        public string ID
        {
            get { return studentID; }
        }


        public string NameFirst
        {
            get
            {
                return nameFirst;
            }
            set
            {
                nameFirst = value;
            }
        }

        public string NameLast
        {
            get
            {
                return nameLast;
            }
            set
            {
                nameLast = value;
            }
        }


        public void CalGrade()
        {
            int totalEarned = 0;
            int totalPossible = 0;

            foreach (int item in earned)
                totalEarned += item;

            foreach (int item in possible)
                totalPossible += item;

            average = (float)totalEarned / totalPossible; 
            average = (float)Math.Round(average, 2);


            if (average >= .90)
                letterGrade = "A";

            if (average >= .80 && average < .90)
                letterGrade = "B";

            if (average >= .70 && average < .80)
                letterGrade = "C";

            if (average >= .60 && average < .70)
                letterGrade = "D";

            if (average < .60)
                letterGrade = "U";

        }
    }
}

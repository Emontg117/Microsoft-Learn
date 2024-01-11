/*

Author: Elisha Montgomery
Title: Student Grade Calculator

Overview:
This is a guided project completed using https://learn.microsoft.com/en-us/training/modules/guided-project-arrays-iteration-selection/2-prepare.

[IMPORTANT!!!]: An already written program is provided to be updated so that it follows the parameters below.
The provided program will be labeled "BaseCode.cs" and placed in the same directory as this program.
To prevent compiler errors, all of the code in BaseCode.cs will be commented out.

Parameters:
- Start with four students, with each student having five exam scores.
    - Exam score is an integer from 0-100 with 100 == 100%.
    - Overall exam score is the average of all five exam scores.

- Criteria for extra credit assignments:
    - Extra credit assignments are included in the student's scores array.
    - Extra credit assignments are worth 10% of an exam score (when calculating final numeric grade).
    - Extra credit assignment scores are added to the student's total exam score before calculating the final numeric grade.

- The application needs to automatically assign letter grades based on the calculated final score for each student.
- The application needs to output/display each student’s name and formatted grade.
- The application needs to support adding other students and scores with minimal impact to the code.

Grading Scale:
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F

*/
using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] {90, 86, 87, 98, 100, 94, 90};
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89};
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89};
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96};
// Additional Students
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

int[] studentScores = new int[10];

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"};

Console.WriteLine("Student\t\tGrade\n");

foreach (string student in studentNames)
{
    if(student == "Sophia"){studentScores = sophiaScores;}
    else if (student == "Andrew"){studentScores = andrewScores;}
    else if (student == "Emma"){studentScores = emmaScores;}
    else if (student == "Logan"){studentScores = loganScores;}
    else if (student == "Becky"){studentScores = beckyScores;}
    else if (student == "Chris"){studentScores = chrisScores;}
    else if (student == "Eric"){studentScores = ericScores;}
    else if (student == "Gregor"){studentScores = gregorScores;}

    int sumAssignmentScores = 0;
    int gradedAssignments = 0;
    decimal currentStudentGrade = 0;
    string letterGrade;

    foreach(int score in studentScores)
    {
        gradedAssignments++;

        if(gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else
        {
            sumAssignmentScores += score / 10;
        }
    }

    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

    if(currentStudentGrade >= 97) { letterGrade = "A+"; }
    else if (currentStudentGrade >= 93) { letterGrade = "A"; }
    else if (currentStudentGrade >= 90) { letterGrade = "A-"; }
    else if (currentStudentGrade >= 87) { letterGrade = "B+"; }
    else if (currentStudentGrade >= 83) { letterGrade = "B"; }
    else if (currentStudentGrade >= 80) { letterGrade = "B-"; }
    else if (currentStudentGrade >= 77) { letterGrade = "C+"; }
    else if (currentStudentGrade >= 73) { letterGrade = "C"; }
    else if (currentStudentGrade >= 70) { letterGrade = "C-"; }
    else if (currentStudentGrade >= 67) { letterGrade = "D+"; }
    else if (currentStudentGrade >= 63) { letterGrade = "D"; }
    else if (currentStudentGrade >= 60) { letterGrade = "D-"; }
    else { letterGrade = "F"; }

    Console.WriteLine($"{student}:\t\t{currentStudentGrade}\t{letterGrade}");
}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();

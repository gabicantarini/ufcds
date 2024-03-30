using System;

class finalGPA
{
    static void Main()
    {


        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Biology 101";
        string course4Name = "Computer Science I";
        string course5Name = "Psychology 101";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;
        int totalCreditHour = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

        double GradePerCredit1 = course1Credit * 4; 
        double GradePerCredit2 = course2Credit * 3;
        double GradePerCredit3 = course3Credit * 3;
        double GradePerCredit4 = course4Credit * 3;
        double GradePerCredit5 = course5Credit * 4;
        double totalGradePerCredit = GradePerCredit1 + GradePerCredit2 + GradePerCredit3 + GradePerCredit4 + GradePerCredit5;

        double totalAmount = totalGradePerCredit / totalCreditHour;

        Console.WriteLine($"Student: {studentName}\n");

        Console.WriteLine("Course            Grade  Credit Hours");
        Console.WriteLine(course1Name + "           " + 4 + "      " + course1Credit);
        Console.WriteLine(course2Name + "           " + 3 + "      " + course2Credit);
        Console.WriteLine(course3Name + "           " + 3 + "      " + course3Credit);
        Console.WriteLine(course4Name + "    " + 3 + "      " + course4Credit);
        Console.WriteLine(course5Name + "        " + 4 + "      " + course5Credit+"\n");

        Console.WriteLine($"Final GPA:            {totalAmount:F2}");
    }
}
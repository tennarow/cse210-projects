using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("John Doe");
        assignment1.SetTopic("Math");
        Console.WriteLine(assignment1.GetAssignmentDetails());

        Assignment assignment2 = new Assignment();
        assignment2.SetStudentName("Jane Smith");
        assignment2.SetTopic("Science");
        Console.WriteLine(assignment2.GetAssignmentDetails());

        MathAssignment mathAssignment = new MathAssignment();
        mathAssignment.SetStudentName("Alice Johnson");
        mathAssignment.SetTopic("Algebra");
        mathAssignment.SetTextbookSection("Section 5.2");
        mathAssignment.SetProblems("1-10");
        Console.WriteLine(mathAssignment.GetHomeworkDetails());

        WritingAssignment writingAssignment = new WritingAssignment();
        writingAssignment.SetStudentName("Bob Brown");
        writingAssignment.SetTopic("History");
        writingAssignment.SetTitle("The Civil War");
        Console.WriteLine(writingAssignment.GetWritingDetails());
    }
}
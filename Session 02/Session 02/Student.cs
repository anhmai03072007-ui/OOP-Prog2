using System;

public class Student
{
    private string name;
    private double score;
    private static int totalStudents = 0;

    public Student(string name, double score)
    {
        this.name = name;
        this.score = score;
        totalStudents++;
    }

    // TODO: write instance methods here

    public string GetName()
    {
        return this.name;
    }

    public double GetScore()
    {
        return this.score;
    }

    public bool IsPassed()
    {
        return this.score >= 5.0;
    }

    public string GetClassification()
    {
        if (this.score >= 8.0)
        {
            return "Excellent";
        }
        else if (this.score >= 6.5)
        {
            return "Good";
        }
        else if (this.score >= 5.0)
        {
            return "Average";
        }
        else
        {
            return "Weak";
        }
    }

    // TODO: write static methods here

    public static int GetTotalStudents()
    {
        return totalStudents;
    }

    public static Student FindTopStudent(Student[] students)
    {
        Student topStudent = students[0];

        foreach (Student student in students)
        {
            if (student.score > topStudent.score)
            {
                topStudent = student;
            }
        }

        return topStudent;
    }

    public static double CalculateAverageScore(Student[] students)
    {
        double total = 0;

        foreach (Student student in students)
        {
            total += student.score;
        }

        return total / students.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // TODO: create array of Student objects

        Student[] students =
        {
            new Student("Nguyen Hoai An", 8.5),
            new Student("Nguyen Binh", 7.0),
            new Student("Co Chi Dau", 5.5),
            new Student("Doan Tan Dung", 4.0),
            new Student("Tran Van Em", 9.0)
        };

        // TODO: call static and instance methods as required
        // Print total number of students
        Console.WriteLine(
            "Total students: " + Student.GetTotalStudents()
        );

        // Print list of students
        foreach (Student student in students)
        {
            Console.WriteLine(
                $"Name: {student.GetName()}, " +
                $"Score: {student.GetScore()}, " +
                $"Classification: {student.GetClassification()}, " +
                $"Status: {(student.IsPassed() ? "Passed" : "Failed")}"
            );
        }

        // Print top-scoring student
        Student topStudent = Student.FindTopStudent(students);

        Console.WriteLine(
            $"Top student: {topStudent.GetName()}, " +
            $"Score: {topStudent.GetScore()}"
        );

        // Print class average score
        double averageScore = Student.CalculateAverageScore(students);

        Console.WriteLine(
            $"Class average score: {averageScore:F2}"
        );
    }
}
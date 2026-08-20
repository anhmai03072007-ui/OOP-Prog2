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

    // TODO: write static methods here
}

class Program
{
    static void Main(string[] args)
    {
        // TODO: create array of Student objects
        // TODO: call static and instance methods as required
    }
}
using System;

public record Student(int RollNumber, string Name, string Course, int Marks);

class Program
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        Student[] students = new Student[n];

        // Input student details
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEnter details for Student {i + 1}:");

            int roll;
            while (true)
            {
                Console.Write("Enter Roll Number: ");
                if (int.TryParse(Console.ReadLine(), out roll) && roll > 0)
                    break;
                else
                    Console.WriteLine("Invalid Roll Number! Try again.");
            }

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            int marks;
            while (true)
            {
                Console.Write("Enter Marks: ");
                if (int.TryParse(Console.ReadLine(), out marks) && marks >= 0 && marks <= 100)
                    break;
                else
                    Console.WriteLine("Invalid Marks! Enter between 0 and 100.");
            }

            students[i] = new Student(roll, name, course, marks);
        }

        // Display all records
        Console.WriteLine("\nStudent Records:");
        foreach (var s in students)
        {
            Console.WriteLine($"Roll No: {s.RollNumber} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}");
        }

        // Search functionality
        Console.Write("\nEnter Roll Number to Search: ");
        int searchRoll = int.Parse(Console.ReadLine());

        Student foundStudent = null;

        foreach (var s in students)
        {
            if (s.RollNumber == searchRoll)
            {
                foundStudent = s;
                break;
            }
        }

        // Display search result
        Console.WriteLine("\nSearch Result:");
        if (foundStudent != null)
        {
            Console.WriteLine("Student Found:");
            Console.WriteLine($"Roll No: {foundStudent.RollNumber} | Name: {foundStudent.Name} | Course: {foundStudent.Course} | Marks: {foundStudent.Marks}");
        }
        else
        {
            Console.WriteLine("Student record not found!");
        }
    }
}
//using System;
//using System.Collections.Generic;

//class AssignQ06
//{
//    static void Main()
//    {
        
//        Dictionary<int, string> students = new Dictionary<int, string>();
        
//        students.Add(101, "Vikram");
//        students.Add(102, "San");
//        students.Add(103, "Vikas");
//        students.Add(104, "Sandip");
//        students.Add(105, "Dinkar");
        
//        int rollNumber = 103;

//        if (students.ContainsKey(rollNumber))
//        {
//            string studentName = students[rollNumber];
//            Console.WriteLine($"student name with roll number {rollNumber} is {studentName}.");
//        }
//        else
//        {
//            Console.WriteLine($"No student found with roll number {rollNumber}.");
//        }

        
//        Console.WriteLine("\nAll students in the dictionary:");
//        foreach (var student in students)
//        {
//            Console.WriteLine($"Roll Number: {student.Key}, Name: {student.Value}");
//        }
//        Console.ReadLine();
//    }
//}

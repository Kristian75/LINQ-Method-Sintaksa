﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Method_Sintaksa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student collection
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John" } ,
                new Student() { StudentID = 2, StudentName = "Moin" } ,
                new Student() { StudentID = 3, StudentName = "Bill" } ,
                new Student() { StudentID = 4, StudentName = "Ram" } ,
                new Student() { StudentID = 5, StudentName = "Ron"  }
            };

            var result = from student in studentList
                         where student.StudentName.Contains('o')
                         select student;

            foreach (var student in result)
                Console.WriteLine(student.ToString());

            Console.ReadKey();
        }
    }
}

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }

    public override string ToString()
    {
        string ispis = "Redi broj: " + this.StudentID + " Ime: " + this.StudentName;
        return ispis;
    }
}

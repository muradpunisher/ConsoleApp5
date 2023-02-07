using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Student
    {
        
        public string FullName;
        public int Point;
        public int GroupNo;
        public bool IsPassed;
        public Student(byte point) 
        {
            Point= point;
        }
    }
    internal class student
    {
        static void Main(string[] args)
        {
            Student student = new Student(65);

            student.FullName = "Totu Qafqazli";
            student.GroupNo = '7';
            {
                if (student.Point>65) 
                {
                    student.IsPassed= true;
                    Console.WriteLine("kifayetdir");
                    
                };
            }

        }
    }
    
}

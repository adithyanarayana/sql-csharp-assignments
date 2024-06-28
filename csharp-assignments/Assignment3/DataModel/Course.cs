using Assignment3.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.DataModel
{
    public  class Course: ICourseService
    {
        public string CourseName { get; set; }
        private Student[] students = new Student[10];
        private int studentCount = 0;

        public void AddStudent(Student student)
        {
            if (studentCount < students.Length)
            {
                students[studentCount++] = student;
            }
        }

        public double AssignGrade(Student student, char grade)
        {
            switch (grade)
            {
                case 'A': return 4.0;
                case 'B': return 3.0;
                case 'C': return 2.0;
                case 'D': return 1.0;
                case 'F': return 0.0;
                default: return 0.0;
            }
        }

        public Student[] GetStudents()
        {
            Student[] enrolledStudents = new Student[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                enrolledStudents[i] = students[i];
            }
            return enrolledStudents;
        }
    }
}

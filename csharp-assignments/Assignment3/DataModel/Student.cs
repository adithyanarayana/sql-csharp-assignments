using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.DataModel
{
    public class Student: Person
    {
        private Course[] courses = new Course[10];
        private int courseCount = 0;

       

        public double CalculateGPA()
        {
            double totalScore = 0;
            int totalCourses = courses.Count;

            foreach (var grade in courses.Values)
            {
                totalScore += AssignGrade(grade);
            }

            return totalCourses == 0 ? 0 : totalScore / totalCourses;
        }

        public void EnrollInCourse(Course course)
        {
            if (courseCount < courses.Length)
            {
                courses[courseCount++] = course;
                course.AddStudent(this);
            }
        }

        public Course[] GetCourses()
        {
            Course[] enrolledCourses = new Course[courseCount];
            for (int i = 0; i < courseCount; i++)
            {
                enrolledCourses[i] = courses[i];
            }
            return enrolledCourses;
        }

        public override decimal CalculateBonus()
        {
            return 0; 
        }
    }
}

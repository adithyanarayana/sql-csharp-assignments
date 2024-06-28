using Assignment3.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Repositories.Interface
{
    public interface ICourseService
    {
        void AddStudent(Student student);
        double AssignGrade(Student student, char grade);
    }
}

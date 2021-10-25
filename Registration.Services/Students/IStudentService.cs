using Registration.Domain.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Services.Students
{
    public interface IStudentService
    {
        IList<Student> GetStudents();
        Student GetStudentByID(int id);
        void Insert(Student lesson);
        void DeleteStudent(int id);
        void UpdateStudent(Student student);
        void Save();
    }
}

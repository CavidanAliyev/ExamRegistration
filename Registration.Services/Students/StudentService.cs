using Registration.Domain.Students;
using Registration.EntityFrameworkCore.Repository.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Services.Students
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public void DeleteStudent(int id)
        {
            this.studentRepository.DeleteItem(id);
        }

        public Student GetStudentByID(int id)
        {
            var result = this.studentRepository.GetItemByID(id);
            return result;
        }

        public IList<Student> GetStudents()
        {
            var list = this.studentRepository.GetItems().ToList();
            return list;
        }

        public void Insert(Student lesson)
        {
            this.studentRepository.InsertItem(lesson);
        }

        public void Save()
        {
            this.studentRepository.Save();
        }

        public void UpdateStudent(Student student)
        {
            this.studentRepository.UpdateItem(student);
        }

    }
}

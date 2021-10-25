using Microsoft.EntityFrameworkCore;
using Registration.Domain.Lessons;
using Registration.Domain.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.EntityFrameworkCore.Repository.Students
{
    public class StudentRepository : IStudentRepository
    {
        private RegistrationDbContext context;
        public StudentRepository(RegistrationDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Student> GetItems()
        {
            return context.Students.ToList();
        }

        public Student GetItemByID(int id)
        {
            return context.Students.Find(id);
        }

        public void InsertItem(Student entity)
        {
            context.Students.Add(entity);
        }
        public void DeleteItem(int id)
        {
            Student student = context.Students.Find(id);
            context.Students.Remove(student);
        }

        public void UpdateItem(Student entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

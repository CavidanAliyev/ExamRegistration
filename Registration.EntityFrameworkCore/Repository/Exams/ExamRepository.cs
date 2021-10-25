using Microsoft.EntityFrameworkCore;
using Registration.Domain.Exams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.EntityFrameworkCore.Repository
{
    public class ExamRepository : IExamRepository
    {
        private RegistrationDbContext context;

        public ExamRepository(RegistrationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Exam> GetItems()
        {
            return context.Exams.ToList();
        }

        public Exam GetItemByID(int id)
        {
            return context.Exams.Find(id);
        }

        public void InsertItem(Exam entity)
        {
            context.Exams.Add(entity);
        }
        public void DeleteItem(int id)
        {
            Exam exam = context.Exams.Find(id);
            context.Exams.Remove(exam);
        }

        public void UpdateItem(Exam entity)
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

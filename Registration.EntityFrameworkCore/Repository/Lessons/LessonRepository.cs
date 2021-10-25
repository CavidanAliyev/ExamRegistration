using Microsoft.EntityFrameworkCore;
using Registration.Domain.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.EntityFrameworkCore.Repository.Lessons
{
    public class LessonRepository : ILessonRepository
    {
        private RegistrationDbContext context;
        public LessonRepository(RegistrationDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Lesson> GetItems()
        {
            return context.Lessons.ToList();
        }

        public Lesson GetItemByID(int id)
        {
            return context.Lessons.Find(id);
        }

        public void InsertItem(Lesson entity)
        {
            context.Lessons.Add(entity);
        }
        public void DeleteItem(int id)
        {
            Lesson lesson = context.Lessons.Find(id);
            context.Lessons.Remove(lesson);
        }

        public void UpdateItem(Lesson entity)
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

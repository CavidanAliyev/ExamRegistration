using Registration.Domain.Lessons;
using Registration.EntityFrameworkCore.Repository.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Services.Lessons
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository lessonRepository;

        public LessonService(ILessonRepository lessonRepository)
        {
            this.lessonRepository = lessonRepository;
        }
        public IList<Lesson> GetLessons()
        {
            var list = this.lessonRepository.GetItems().ToList();
            return list;
        }

        public Lesson GetLessonByID(int id)
        {
            var result = this.lessonRepository.GetItemByID(id);
            return result;
        }

        public void Insert(Lesson lesson)
        {
            this.lessonRepository.InsertItem(lesson);
        }
        public void DeleteLesson(int id)
        {
            this.lessonRepository.DeleteItem(id);
        }

        public void UpdateLesson(Lesson lesson)
        {
            this.lessonRepository.UpdateItem(lesson);
        }
        public void Save()
        {
            this.lessonRepository.Save();
        }
    }
}

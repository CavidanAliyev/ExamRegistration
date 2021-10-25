using Registration.Domain.Lessons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Services.Lessons
{
    public interface ILessonService
    {
        IList<Lesson> GetLessons();
        Lesson GetLessonByID(int id);
        void Insert(Lesson lesson);
        void DeleteLesson(int id);
        void UpdateLesson(Lesson lesson);
        void Save();
    }
}

using Registration.Domain.Exams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Services.Exams
{
    public interface IExamService
    {
        IList<Exam> GetExams();
        Exam GetExamByID(int id);
        void Insert(Exam exam);
        void DeleteExam(int id);
        void UpdateExam(Exam exam);
        void Save();
    }
}

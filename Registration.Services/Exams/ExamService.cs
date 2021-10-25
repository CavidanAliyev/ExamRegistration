using Registration.Domain.Exams;
using Registration.EntityFrameworkCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Services.Exams
{
    public class ExamService : IExamService
    {
        private readonly IExamRepository examRepository;
        public ExamService(IExamRepository examRepository)
        {
            this.examRepository = examRepository;
        }

        public void DeleteExam(int id)
        {
            this.examRepository.DeleteItem(id);
        }

        public Exam GetExamByID(int id)
        {
            var result = this.examRepository.GetItemByID(id);
            return result;
        }

        public IList<Exam> GetExams()
        {
            var list = this.examRepository.GetItems().ToList();
            return list;
        }

        public void Insert(Exam exam)
        {
            this.examRepository.InsertItem(exam);
        }

        public void Save()
        {
            this.examRepository.Save();
        }

        public void UpdateExam(Exam exam)
        {
            this.examRepository.UpdateItem(exam);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Registration.Domain.Exams;
using Registration.Services.Exams;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Registration.Web.UI.Controllers.Exams
{
    public class ExamController : Controller
    {
        private readonly IExamService service;
        public ExamController(IExamService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            var list = service.GetExams();
            return View(list);
        }   
        
        public IActionResult Create()
        { 
            return View();
        }

        public ViewResult Edit(int id)
        {
            Exam exam= service.GetExamByID(id);
            return View(exam);
        } 
        
        public ViewResult Details(int id)
        {
            Exam exam= service.GetExamByID(id);
            return View(exam);
        }

        [HttpPost]
        public ActionResult Create(Exam exam)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.Insert(exam);
                    service.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(exam);
        }


        [HttpPost]
        public ActionResult Edit(Exam exam)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.UpdateExam(exam);
                    service.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(exam);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                Exam exam = service.GetExamByID(id);
                service.DeleteExam(id);
                service.Save();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }
    }
}

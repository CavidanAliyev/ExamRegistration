using Microsoft.AspNetCore.Mvc;
using Registration.Domain.Lessons;
using Registration.Services.Lessons;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Registration.Web.UI.Controllers.Lessons
{
    public class LessonController : Controller
    {
        private readonly ILessonService service;
        public LessonController(ILessonService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            var list = service.GetLessons();
            return View(list);
        }     

        public IActionResult Create()
        { 
            return View();
        }

        public ViewResult Details(int id)
        {
            Lesson lesson = service.GetLessonByID(id);
            return View(lesson);
        }  
        
        public ViewResult Edit(int id)
        {
            Lesson lesson = service.GetLessonByID(id);
            return View(lesson);
        }

        [HttpPost]
        public ActionResult Create(Lesson lesson)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.Insert(lesson);
                    service.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(lesson);
        }


        [HttpPost]
        public ActionResult Edit(Lesson lesson)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.UpdateLesson(lesson);
                    service.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(lesson);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                Lesson lesson = service.GetLessonByID(id);
                service.DeleteLesson(id);
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

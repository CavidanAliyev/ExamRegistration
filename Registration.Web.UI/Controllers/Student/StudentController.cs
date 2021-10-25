using Microsoft.AspNetCore.Mvc;
using Registration.Domain.Students;
using Registration.Services.Students;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Registration.Web.UI.Controllers.Students
{
    public class StudentController : Controller
    {
        private readonly IStudentService service;
        public StudentController(IStudentService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            var list = service.GetStudents();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }   

        public ViewResult Edit(int id)
        {
            Student student = service.GetStudentByID(id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.Insert(student);
                    service.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(student);
        }


        [HttpPost]
        public ActionResult Edit(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.UpdateStudent(student);
                    service.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(student);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                Student student = service.GetStudentByID(id);
                service.DeleteStudent(id);
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

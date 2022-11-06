using MVCApp.Interfaces.Manager;
using MVCApp.Manager;
using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class StudentController : Controller
    {
       IStudentManager _studentManager = new StudentManager();
        // GET: Student
        public ActionResult Index()
        {
            var students = _studentManager.GetAll();
            return View(students);
        }

        public ActionResult Create()
        {    
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if(ModelState.IsValid)
            {
                if (_studentManager.IsExistRegNo(student.RegNo))
                {
                    ViewBag.Message = "Reg No already Exists";
                    return View(student);
                }
                bool isChecked = _studentManager.Add(student);
                if (isChecked)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
           
            return View(student);
        }

        public ActionResult Details(int id)
        {
            var student = _studentManager.GetById(id);

            return View(student);
        }

        public ActionResult Edit(int id)
        {
            var student = _studentManager.GetById(id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            bool isChecked = _studentManager.Update(student);
            if(isChecked)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public ActionResult Delete(int id)
        {
            var student = _studentManager.GetById(id);
            return View(student);
        }
        [HttpPost]
        public ActionResult Delete(Student student)
        {
            bool isChecked = _studentManager.Delete(student);
            if(isChecked)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}
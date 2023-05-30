using IDGS904_BD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_BD.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            using (StudentDBContext dbStudent = new StudentDBContext())
            {
                // Select * from Students;
                return View(dbStudent.Students.ToList());
            }
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            using (StudentDBContext dbStudent = new StudentDBContext())
            {
                // insert into students;
                dbStudent.Students.Add(student);
                dbStudent.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details( int? id )
        {
            using (StudentDBContext dbStudent = new StudentDBContext())
            {
                // select * from students where id = n;
                Student student = dbStudent.Students.Find(id);
                if (student == null)
                {
                    return HttpNotFound();
                }
                return View(student);
            }
        }

        public ActionResult Edit(int? id)
        {
            using (StudentDBContext dbStudent = new StudentDBContext())
            {
                // select * from students where id = n;
                Student student = dbStudent.Students.Find(id);
                if (student == null)
                {
                    return HttpNotFound();
                }
                return View(student);
            }
        }

        [HttpPost]
        public ActionResult Edit(int? id, Student student)
        {
            using (StudentDBContext dbStudent = new StudentDBContext())
            {
                // update students;
                if (ModelState.IsValid)
                {
                    // dbStudent.Entry(student).State=System.Data.Entity.EntityState.Modified;
                    dbStudent.Entry(student).State = EntityState.Modified;
                    dbStudent.SaveChanges();
                }
            }
            return View(student);
        }

    }
}

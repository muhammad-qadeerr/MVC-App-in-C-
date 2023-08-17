using Microsoft.AspNetCore.Mvc;
using Lecture49YT_MVC_Add_Students.Models;
namespace Lecture49YT_MVC_Add_Students.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {
            return View("Index");  // view's name in parameter.
        }

        [HttpGet]
        public ViewResult StudentForm()
        {
            return View();
        }
        // Action method to get data from html form - post method
        [HttpPost]
        //public ViewResult StudentForm(string name, string age, string cgpa, string semester)   
        //{
        //    return View();
        //}


        // Using TagHelpers we can now pass and object to Post action Method.
        public ViewResult StudentForm(Student s)
        {
            StudentRepository.AddStudents(s);
            return View("Thanks", s);
        }

        // To Display the List of Student new action method should be defined

        public ViewResult ListStudents()
        {
            return View(StudentRepository.students);
        }
    }
}

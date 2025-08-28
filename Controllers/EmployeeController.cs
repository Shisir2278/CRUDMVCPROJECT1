using CRUDMVCProject.Data;
using CRUDMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace CRUDMVCProject.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext context;
        public EmployeeController(ApplicationContext context)
        {
            this.context = context;
        }

        public ApplicationContext Context { get; set; }
        public string Name { get; private set; }
        public object Salary { get; private set; }

        public IActionResult Index()
        {
            var data = context.detail.ToList();
            return View(data);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                var data = new Employee

                {
                    Name = model.Name,
                    Salary = model.Salary,
                };
                context.detail.Add(data);
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                return View(model);
            }
        }
        public IActionResult Delete(int id)
        {
            var emp = context.detail.SingleOrDefault(x => x.Id == id);
            context.detail.Remove(emp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var emp = context.detail.SingleOrDefault(x => x.Id == id);
            var result = new Employee();
            {
                Name = emp.Name;
                Salary = emp.Salary;
            }
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            if (ModelState.IsValid)
            {
                var data = new Employee

                {
                    Name = model.Name,
                    Salary = model.Salary,
                };
                context.detail.Add(data);
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                return View(model);
            }

        }

    }
}
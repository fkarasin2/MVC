using Microsoft.AspNetCore.Mvc;
using MvcLearning.Models.Classes;

namespace MvcLearning.Controllers;

public class DepartmentController : Controller
{
    private AppDbContext c = new AppDbContext();
    // GET
    public IActionResult Index()
    {
        var values = c.Departments.Where(x => x.status==true).ToList();
        return View(values);
    }
        
    [HttpGet]
    public ActionResult NewDepartment()
    {
        return View();
    }
    
    [HttpPost]
    public ActionResult NewDepartment(Department d)
    {
        c.Departments.Add(d);
        c.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult DeleteDepartment(int id)
    {
        var deleteDepartment = c.Departments.Find(id);
        c.Departments.Remove(deleteDepartment);
        c.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult GetDepartment(Department d)
    {
        var dept = c.Departments.Find(d.departmentId);
        dept.departmentName = d.departmentName;
        c.SaveChanges();
        return RedirectToAction("Index");
    }
    
    public IActionResult UpdateDepartment(int id)
    {
        var department = c.Departments.Find(id);
        return View("UpdateDepartment", department);

    }
}
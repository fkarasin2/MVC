using System.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MvcLearning.Models.Classes;
namespace MvcLearning.Controllers;

public class CategoryController : Controller
{
    // GET
    private AppDbContext c = new AppDbContext();
    public IActionResult Index()
    {
        var values = c.Categories.ToList();
        return View(values);
    }

    [HttpGet]
    public ActionResult NewCategory()
    {
        return View();
    }
    
    [HttpPost]
    public ActionResult NewCategory(Category k)
    {
        c.Categories.Add(k);
        c.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult DeleteCategory(int id)
    {
        var deleteCate = c.Categories.Find(id);
        c.Categories.Remove(deleteCate);
        c.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult UpdateCategory(Category k)
    {
        var ctgr = c.Categories.Find(k.categoryId);
        ctgr.categoryName = k.categoryName;
        c.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult GetCategory(int id)
    {
        var category = c.Categories.Find(id);
        return View("UpdateCategory", category);
    }
}
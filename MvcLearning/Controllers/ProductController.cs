using System.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcLearning.Models.Classes;

namespace MvcLearning.Controllers;

public class ProductController : Controller
{
    private AppDbContext c = new AppDbContext();
    // GET
    public IActionResult Index()
    {
        var Category = c.Categories.ToList();
        var products = c.Products.Where(x => x.state==true).ToList();
        return View(products);
    }

    public IActionResult NewProduct()
    {
        List<SelectListItem> value = (from x in c.Categories.ToList()
            select new SelectListItem(
                text: x.categoryName,
                value: x.categoryId.ToString()
            )).ToList();
        ViewBag.value1 = value;
        return View();
    }

    [HttpPost]
    public IActionResult NewProduct(Product p)
    {
        c.Products.Add(p);
        c.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult DeleteProduct(int id)
    {
        var deleteProduct = c.Products.Find(id);
        deleteProduct.state = false;
        c.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult GetProduct(Product p)
    {
        var prdct = c.Products.Find(p.productId);
        prdct.productName = p.productName;
        prdct.productBrand = p.productBrand;
        prdct.buyPrice = p.buyPrice;
        prdct.sellPrice = p.sellPrice;
        prdct.state = p.state;
        prdct.productImg = p.productImg;
        prdct.stockCounts = p.stockCounts;
        prdct.categoryID = p.categoryID;
        c.SaveChanges();
        return RedirectToAction("Index");
    }
    
    
    public IActionResult UpdateProduct(int id)
    {
        List<SelectListItem> value = (from x in c.Categories.ToList()
            select new SelectListItem(
                text: x.categoryName,
                value: x.categoryId.ToString()
            )).ToList();
        ViewBag.value1 = value;
        var product = c.Products.Find(id);
        return View("UpdateProduct", product);
    }
}
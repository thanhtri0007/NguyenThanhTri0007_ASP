using thanhtri_2121110007.Context;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using System.IO;

public class HomeController : Controller
{
    private WebTriEntities _context = new WebTriEntities();

    public ActionResult Index()
    {
        var viewModel = new CombinedViewModel
        {
            Categories = _context.Categories.ToList(),
            Products = _context.Products.ToList()
        };

        return View(viewModel); // Trả về view với mô hình hợp nhất
    }


    public ActionResult Index1()
    {
        var listProduct = _context.Products.ToList();
        return View(listProduct);
    }
    public ActionResult Register()
    {
        return View();
    }

    public ActionResult About()
    {
        ViewBag.Message = "Your application description page.";
        return View();
    }

    public ActionResult Contact()
    {
        ViewBag.Message = "Your contact page.";
        return View();
    }

}


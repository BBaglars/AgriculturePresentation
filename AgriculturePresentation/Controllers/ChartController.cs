using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers;

public class ChartController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ProductChart()
    {
        List<ProductClass> productClasses = new List<ProductClass>();

        productClasses.Add(new ProductClass
        {
            productName = "Buğday",
            productValue = 850
        });

        productClasses.Add(new ProductClass
        {
            productName = "Mercimek",
            productValue = 480
        });

        productClasses.Add(new ProductClass
        {
            productName = "Arpa",
            productValue = 250
        });

        productClasses.Add(new ProductClass
        {
            productName = "Pirinç",
            productValue = 120
        });

        productClasses.Add(new ProductClass
        {
            productName = "Domates",
            productValue = 960
        });

        return Json(new { jsonlist = productClasses });
    }
}
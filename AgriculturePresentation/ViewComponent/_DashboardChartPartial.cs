using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponent;

public class _DashboardChartPartial : Microsoft.AspNetCore.Mvc.ViewComponent
{
    public IViewComponentResult Invoke()
    {
        ViewBag.v1 = 88;
        ViewBag.v2 = 93;
        return View();
    }
}
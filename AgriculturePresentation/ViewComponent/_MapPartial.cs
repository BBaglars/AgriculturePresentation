using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponent;

public class _MapPartial : Microsoft.AspNetCore.Mvc.ViewComponent
{
    public IViewComponentResult Invoke()
    {
        AgricultureContext agricultureContext = new AgricultureContext();
        var values = agricultureContext.Addresses.Select(x => x.Mapinfo).FirstOrDefault();
        ViewBag.v = values;
        return View();
    }
}
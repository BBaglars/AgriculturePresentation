using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponent;

public class _NavbarPartial : Microsoft.AspNetCore.Mvc.ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
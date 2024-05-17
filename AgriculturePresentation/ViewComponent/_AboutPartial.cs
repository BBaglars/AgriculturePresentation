using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponent;

public class _AboutPartial : Microsoft.AspNetCore.Mvc.ViewComponent
{
    private readonly IAboutService _aboutService;

    public _AboutPartial(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    public IViewComponentResult Invoke()
    {
        var values = _aboutService.GetListAll();
        return View(values);
    }
}
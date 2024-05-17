using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponent;

public class _DashboardTablePartial : Microsoft.AspNetCore.Mvc.ViewComponent
{
    private readonly IContactService _contactService;

    public _DashboardTablePartial(IContactService contactService)
    {
        _contactService = contactService;
    }

    public IViewComponentResult Invoke()
    {
        var values = _contactService.GetListAll();
        return View(values);
    }
}
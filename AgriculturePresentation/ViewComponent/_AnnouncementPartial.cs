using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponent;

public class _AnnouncementPartial : Microsoft.AspNetCore.Mvc.ViewComponent
{
    private readonly IAnnouncementService _announcementService;

    public _AnnouncementPartial(IAnnouncementService announcementService)
    {
        _announcementService = announcementService;
    }

    public IViewComponentResult Invoke()
    {
        var values = _announcementService.GetListAll();
        return View(values);
    }
}
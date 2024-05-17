using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponent;

public class _SocialMediaPartial : Microsoft.AspNetCore.Mvc.ViewComponent
{
    private readonly ISocialMediaService _socialMediaService;

    public _SocialMediaPartial(ISocialMediaService socialMediaService)
    {
        _socialMediaService = socialMediaService;
    }

    public IViewComponentResult Invoke()
    {
        var values = _socialMediaService.GetListAll();
        return View(values);
    }
}
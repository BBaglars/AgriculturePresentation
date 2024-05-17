using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AgriculturePresentation.ViewComponent;

public class _GalleryPartial : Microsoft.AspNetCore.Mvc.ViewComponent
{
    private readonly IImageService _imageService;

    public _GalleryPartial(IImageService ımageService)
    {
        _imageService = ımageService;
    }

    public IViewComponentResult Invoke()
    {
        var values = _imageService.GetListAll();
        return View(values);
    }
}
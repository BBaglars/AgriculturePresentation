using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponent;

public class _TopAddressPartial : Microsoft.AspNetCore.Mvc.ViewComponent
{
    private readonly IAddressService _addressService;

    public _TopAddressPartial(IAddressService addressService)
    {
        _addressService = addressService;
    }

    public IViewComponentResult Invoke()
    {
        var values = _addressService.GetListAll();
        return View(values);
    }
}
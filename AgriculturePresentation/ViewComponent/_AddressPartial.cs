using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponent;

public class _AddressPartial : Microsoft.AspNetCore.Mvc.ViewComponent
{
    private readonly IAddressService _addressService;

    public _AddressPartial(IAddressService addressService)
    {
        _addressService = addressService;
    }

    public IViewComponentResult Invoke()
    {
        var values = _addressService.GetListAll();
        return View(values);
    }
}
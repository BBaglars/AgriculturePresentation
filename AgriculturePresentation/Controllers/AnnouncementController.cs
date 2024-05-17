using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers;

public class AnnouncementController : Controller
{
    private readonly IAnnouncementService _announcementService;

    // GET
    public AnnouncementController(IAnnouncementService announcementService)
    {
        _announcementService = announcementService;
    }

    public IActionResult Index()
    {
        var values = _announcementService.GetListAll();
        return View(values);
    }

    [HttpGet]
    public IActionResult AddAnnouncement()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddAnnouncement(Announcement announcement)
    {
        announcement.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
        announcement.Status = false;
        _announcementService.Insert(announcement);
        return RedirectToAction("Index");
    }

    public IActionResult DeleteAnnouncement(int id)
    {
        var value = _announcementService.GetById(id);
        _announcementService.Delete(value);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult EditAnnouncement(int id)
    {
        var value = _announcementService.GetById(id);
        return View(value);
    }

    [HttpPost]
    public IActionResult EditAnnouncement(Announcement announcement)
    {
        _announcementService.Update(announcement);
        return RedirectToAction("Index");
    }

    public IActionResult ChangeStatusToTrue(int id)
    {
        _announcementService.AnnouncementStatusToTrue(id);
        return RedirectToAction("Index");
    }
    
    public IActionResult ChangeStatusToFalse(int id)
    {
        _announcementService.AnnouncementStatusToFalse(id);
        return RedirectToAction("Index");
    }
}
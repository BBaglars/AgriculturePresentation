using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class AnnouncementManager : IAnnouncementService
{
    private IAnnouncementDal _announcementDal;

    public AnnouncementManager(IAnnouncementDal announcementDal)
    {
        _announcementDal = announcementDal;
    }

    public void Insert(Announcement t)
    {
        _announcementDal.Insert(t);
    }

    public void Delete(Announcement t)
    {
        _announcementDal.Delete(t);
    }

    public void Update(Announcement t)
    {
        _announcementDal.Update(t);
    }

    public Announcement GetById(int id)
    {
        return _announcementDal.GetById(id);
    }

    public List<Announcement> GetListAll()
    {
        return _announcementDal.GetListAll();
    }

    public void AnnouncementStatusToChange(int id)
    {
        throw new NotImplementedException();
    }

    public void AnnouncementStatusToTrue(int id)
    {
        _announcementDal.AnnouncementStatusToTrue(id);
    }

    public void AnnouncementStatusToFalse(int id)
    {
        _announcementDal.AnnouncementStatusToFalse(id);
    }
}
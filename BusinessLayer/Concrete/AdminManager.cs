using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class AdminManager : IAdminService
{
    private readonly IAdminDal _adminDal;

    public AdminManager(IAdminDal adminDal)
    {
        _adminDal = adminDal;
    }

    public void Insert(Admin t)
    {
        _adminDal.Insert(t);
    }

    public void Delete(Admin t)
    {
        _adminDal.Delete(t);
    }

    public void Update(Admin t)
    {
        _adminDal.Update(t);
    }

    public Admin GetById(int id)
    {
        return _adminDal.GetById(id);
    }

    public List<Admin> GetListAll()
    {
        return _adminDal.GetListAll();
    }
}
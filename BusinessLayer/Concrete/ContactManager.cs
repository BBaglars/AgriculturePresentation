using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class ContactManager : IContactService
{
    private readonly IContactDal _contactDal;

    public ContactManager(IContactDal contactDal)
    {
        _contactDal = contactDal;
    }

    public void Insert(Contact t)
    {
        _contactDal.Insert(t);
    }

    public void Delete(Contact t)
    {
        _contactDal.Delete(t);
    }

    public void Update(Contact t)
    {
        throw new NotImplementedException();
    }

    public Contact GetById(int id)
    {
        return _contactDal.GetById(id);
    }

    public List<Contact> GetListAll()
    {
        return _contactDal.GetListAll();
    }
}
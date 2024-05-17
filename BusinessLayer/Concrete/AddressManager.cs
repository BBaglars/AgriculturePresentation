using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class AddressManager : IAddressService
{
    private readonly IAddressDal _addressDal;

    public AddressManager(IAddressDal addressDal)
    {
        _addressDal = addressDal;
    }

    public void Insert(Address t)
    {
        throw new NotImplementedException();
    }

    public void Delete(Address t)
    {
        throw new NotImplementedException();
    }

    public void Update(Address t)
    {
       _addressDal.Update(t);
    }

    public Address GetById(int id)
    {
        return _addressDal.GetById(id);
    }

    public List<Address> GetListAll()
    {
        return _addressDal.GetListAll();    
    }
}
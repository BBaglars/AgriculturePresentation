using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ServiceManagaer : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManagaer(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Delete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> GetListAll()
        {
            return _serviceDal.GetListAll();
        }

        public void Insert(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void Update(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}


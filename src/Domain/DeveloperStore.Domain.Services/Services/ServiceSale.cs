using DeveloperStore.Domain.Core.Interfaces.Repositorys;
using DeveloperStore.Domain.Core.Interfaces.Services;
using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Domain.Services
{
    public class ServiceSale : ServiceBase<Sale>, IServiceSale
    {
        private readonly IRepositorySale _repositorySale;

        public ServiceSale(IRepositorySale repositorySale)
            : base(repositorySale)
        {
            _repositorySale = repositorySale;
        }

        public new void Add(Sale obj)
        {
            _repositorySale.Add(obj);
        }

        public new IEnumerable<Sale> GetAll()
        {
            return _repositorySale.GetAll();
        }

        public new Sale GetById(int id)
        {
            return _repositorySale.GetById(id);
        }

        public new void Remove(Sale obj)
        {
            _repositorySale.Remove(obj);
        }

        public new void Update(Sale obj)
        {
            _repositorySale.Update(obj);
        }
    }
}
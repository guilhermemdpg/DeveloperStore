using DeveloperStore.Domain.Core.Interfaces.Repositorys;
using DeveloperStore.Domain.Core.Interfaces.Services;
using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Domain.Services
{
    public class ServiceSale : ServiceBase<Sale>, IServiceSale
    {
        private readonly IRepositorySale _repositorySale;

        public ServiceSale(IRepositorySale RepositorySale)
            : base(RepositorySale)
        {
            _repositorySale = RepositorySale;
        }

        void IServiceSale.Add(IServiceSale obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IServiceSale> IServiceSale.GetAll()
        {
            throw new NotImplementedException();
        }

        IServiceSale IServiceSale.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IServiceSale.Remove(IServiceSale obj)
        {
            throw new NotImplementedException();
        }

        void IServiceSale.Update(IServiceSale obj)
        {
            throw new NotImplementedException();
        }
    }
}
using Autofac;
using DeveloperStore.API.Application.Interfaces;
using DeveloperStore.API.Application.Service;
using DeveloperStore.Domain.Core.Interfaces.Repositorys;
using DeveloperStore.Domain.Core.Interfaces.Services;
using DeveloperStore.Domain.Services;
using DeveloperStore.Infrastructure.CrossCutting.Adapter.Interfaces;
using DeveloperStore.Infrastructure.CrossCutting.Adapter.Map;
using DeveloperStore.Infrastructure.Repository.Repositorys;

namespace DeveloperStore.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceCustomer>().As<IApplicationServiceCustomer>();
            builder.RegisterType<ApplicationServiceSaleItem>().As<ApplicationServiceSaleItem>();
            builder.RegisterType<ApplicationServiceSale>().As<ApplicationServiceSale>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceCustomer>().As<IServiceCustomer>();
            builder.RegisterType<ServiceSaleItem>().As<IServiceSaleItem>();
            builder.RegisterType<ServiceSale>().As<IServiceSale>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryCustomer>().As<IRepositoryCustomer>();
            builder.RegisterType<RepositorySaleItem>().As<IRepositorySaleItem>();
            builder.RegisterType<RepositorySale>().As<IRepositorySaleItem>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperCustomer>().As<IMapperCustomer>();
            builder.RegisterType<MapperSaleItem>().As<IMapperSaleItem>();
            builder.RegisterType<MapperSale>().As<IMapperSale>();
            #endregion

            #endregion

        }
    }
}
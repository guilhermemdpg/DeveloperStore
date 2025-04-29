using Autofac;
using DeveloperStore.Infrastructure.CrossCutting.IOC;
using DeveloperStore.Infrastructure.Data;

namespace DeveloperStore.Presentation
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration["SqlConnection:SqlConnectionString"];
            services
                    .AddDbContext<SqlContext>(options => options.UseSqlServer(connection), ServiceLifetime.Scoped);
            services.AddMemoryCache();
        }

        public void ConfigureContainer(ContainerBuilder Builder)
        {
            #region Modulo IOC

            Builder.RegisterModule(new ModuleIOC());

            #endregion
        }
    }
}

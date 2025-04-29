using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DeveloperStore.Infrastructure.CrossCutting.IOC;
using DeveloperStore.Infrastructure.Data;
using System.Data.SQLite;

namespace DeveloperStore.Presentation
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = "Data Source=/Users/guilhermegarcia/Documents/DeveloperStore/App_Data/developer_store.sqlite";

            services.AddDbContext<SqlContext>(options =>
                options.UseSqlite(connectionString),
                ServiceLifetime.Scoped
            );

            services.AddMemoryCache();
        }

        public static void CreateDBSQLite()
        {
            try
            {
                SQLiteConnection.CreateFile("Data Source=/Users/guilhermegarcia/Documents/DeveloperStore/App_Data/developer_store.sqlite");
            }
            catch
            {
                throw;
            }
        }

        public void ConfigureContainer(ContainerBuilder Builder)
        {
            #region Modulo IOC
            Builder.RegisterModule(new ModuleIOC());
            #endregion
        }
    }
}

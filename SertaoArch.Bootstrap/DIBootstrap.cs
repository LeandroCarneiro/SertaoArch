using $ext_projectname$.Data.Contexts;
using $ext_projectname$.DI;
using $ext_projectname$.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace $safeprojectname$
{
    public static class DIBootstrap
    {
        public static void RegisterTypes(IServiceCollection service)
        {
            service.RegisterAppServices()
                .RegisterAppBusiness()
                .RegisterAppPersistence();

            AppContainer.SetContainer(service);
            AutoMapperConfiguration.Register();

            Migrate(service);
        }

        private static void Migrate(IServiceCollection services)
        {
            var dao = services.BuildServiceProvider().GetService<TeslaDbContext>();            
            dao.Database.EnsureCreated();
            //dao.Database.Migrate();
        }
    }
}
using $ext_projectname$.Application.AppServices;
using $ext_projectname$.Application.Interfaces;
using $ext_projectname$.Business.Domain;
using $ext_projectname$.Data.Contexts;
using $ext_projectname$.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace $safeprojectname$
{
    public static class BigContainer
    {
        public static IServiceCollection RegisterAppServices(this IServiceCollection service)
        {
            service.AddTransient<SurveyAppService>();
            service.AddTransient<UserAppService>();
            return service;
        }

        public static IServiceCollection RegisterAppBusiness(this IServiceCollection service)
        {
            service.AddTransient<ISurveyBusiness, SurveyBusiness>();
            service.AddTransient<IUserBusiness, UserBusiness>();
            return service;
        }
        
        public static IServiceCollection RegisterAppPersistence(this IServiceCollection service)
        {
            service.AddDbContext<TeslaDbContext>();
            service.AddTransient<IDbContext, TeslaDbContext>();
            return service;
        }
    }
}

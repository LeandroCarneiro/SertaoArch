using $safeprojectname$.Interfaces;
using $ext_projectname$.Domain.Entities;
using $ext_projectname$.ViewModels.AppObjects;

namespace $safeprojectname$.AppServices
{
    public class UserAppService : BaseAppService<UserApp_vw, UserApp>
    {
        public UserAppService(IUserBusiness business) : base(business) { }
    }
}

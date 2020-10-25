using AutoMapper;
using $ext_projectname$.Domain;
using $ext_projectname$.Domain.Entities;
using $ext_projectname$.ViewModels;
using $ext_projectname$.ViewModels.AppObjects;

namespace $safeprojectname$.Profiles
{
    public class TeslaDomainProfile : Profile
    {
        public TeslaDomainProfile() 
        {
            CreateMap<EntityBase<long>, EntityBase_vw<long>>().ReverseMap();
            CreateMap<UserApp, UserApp_vw>().ReverseMap();
            CreateMap<SurveyVersion, SurveyVersion_vw>().ReverseMap();
            CreateMap<Survey, Survey_vw>().ReverseMap();            
            CreateMap<Answer, Answer_vw>().ReverseMap();
            CreateMap<Question, Question_vw>().ReverseMap();
        }
    }
}

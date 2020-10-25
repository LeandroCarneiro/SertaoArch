using $ext_projectname$.Domain.Entities;

namespace $safeprojectname$.Interfaces
{
    public interface ISurveyBusiness : IBusiness<SurveyVersion>
    {
        void DisableVersion(long surveyId, int version);
    }
}

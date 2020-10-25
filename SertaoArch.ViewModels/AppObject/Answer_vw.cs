using $ext_projectname$.Common.Enums;

namespace $safeprojectname$.AppObjects
{
    public class Answer_vw : EntityBase_vw<long>
    {
        public string Text { get; set; }
        public EAnswerType Type { get; set; }
    }
}
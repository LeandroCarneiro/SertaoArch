using $ext_projectname$.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace $safeprojectname$.Entities
{
    [Table("tbl_answers")]
    public class Answer : EntityBase<long>
    {
        public string Text { get; set; }
        public EAnswerType Type { get; set; }
    }
}
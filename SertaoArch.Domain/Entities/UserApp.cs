using System.ComponentModel.DataAnnotations.Schema;

namespace $safeprojectname$.Entities
{
    [Table("tbl_users")]
    public class UserApp : EntityBase<long>
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}

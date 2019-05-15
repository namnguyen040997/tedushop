using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedushop.Model.Model
{
    [Table("IdentityUserRoles")]
    public class IdentityUserRole
    {
        [Key]
        public string UserId { get; set; }

        [Key]
        public string RoleId { get; set; }

        [ForeignKey("IdentityRoleId")]
        public string IdentityRole_Id { get; set; }

        [ForeignKey("ApplicationUserId")]
        public string ApplicationUser_Id { get; set; }
    }
}

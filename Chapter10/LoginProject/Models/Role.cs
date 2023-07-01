using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.Models
{
    [Table("Roles")]
    public class Role
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RoleID { get; set; }

        [Required]
        public RoleName RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
    public enum RoleName
    {
        Admin = 1,
        Guest = 2,
        VIP = 3,
        Regular = 4
    }
}

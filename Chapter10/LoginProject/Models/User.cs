using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [StringLength(15, ErrorMessage = "Must be between 3 and 15 characters", MinimumLength = 3)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(15, ErrorMessage = "Must be between 8 and 15 characters", MinimumLength = 8)]
        public string Password { get; set; }

        public virtual Role Role { get; set; }
        public Guid Ref_RoleID { get;  set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Data.Entities
{
    [Table("tbl_categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(100)]
        public string? CategoryName { get; set; }

        [StringLength(100)]
        public string? CategoryDescription { get; set; }


        [StringLength(50)]
        public string? ImageName { get; set; }

    }
}
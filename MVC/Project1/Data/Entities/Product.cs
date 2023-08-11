using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Project1.Enums;

namespace Project1.Data.Entities
{
    [Table("tbl_products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get;set; }

        [StringLength(50)]
        public string? ImageName { get; set; } 
    
        [StringLength(250)]
        [Required]
        public string? Summary { get; set; }

        [StringLength(100)]
        [Required]
        public string? ProductName { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }

        public Color Color { get; set; }


        [ForeignKey("FK_Category_Product")]
        public int CategoryID { get; set; }
        public virtual Category? Category { get; set; }



        [ForeignKey("FK_ProductReview_Product")]
        public int ProductReviewID { get; set; }
        public virtual ProductReview? ProductReview { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Shop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("類別名稱")]
        public string Name { get; set; }
        [DisplayName("顯示順序")]
        [Range(1, 100, ErrorMessage = "輸入範圍在1-100之間")]
        public int DisplayOrder { get; set; }
    }
}

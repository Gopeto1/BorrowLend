using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BorrowLend.Models
{
    [Table("ExpenseType")]
    public class ExpenseType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "ExpenseType name")]
        public string ExpenseTypeName { get; set; }
    }
}

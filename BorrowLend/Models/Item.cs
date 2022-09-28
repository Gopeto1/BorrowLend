using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BorrowLend.Models
{
    [Table("Speedy")]
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public string Borrower { get; set; }

        [Required]
        public string BorrLender { get; set; }
    }
}

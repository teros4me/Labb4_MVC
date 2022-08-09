using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labb4_MVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [MaxLength(50), Required]
        public string FirstName { get; set; }
        [MaxLength(50), Required]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Borrowing> Borrowings { get; set; }
    }
}
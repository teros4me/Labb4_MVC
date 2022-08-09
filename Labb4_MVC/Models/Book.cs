using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [MaxLength(50), Required]
        public string Title { get; set; }
        public string Author { get; set; }

        public ICollection<Borrowing> Borrowings { get; set; }
    }
}

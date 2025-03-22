using System.ComponentModel.DataAnnotations.Schema;
using App1.Models;

namespace App1.Models
{
    [Table("Stock")]
    public class Stock
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }

        public Book? Book { get; set; }
    }
}
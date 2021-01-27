using System.ComponentModel.DataAnnotations;

namespace ExpneseApp.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        public string ExpenseType { get; set; }
        public double Cost { get; set; }
    }
}
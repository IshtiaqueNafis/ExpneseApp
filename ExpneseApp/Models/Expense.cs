using System;
using System.ComponentModel.DataAnnotations;

namespace ExpneseApp.Models
{
    public class Expense
    {
        [Key] // primary key 
        public int Id { get; set; }
        [Required] //mandotory 
        public string ExpenseType { get; set; }
        [Required] // required 
        [Range(1, Double.MaxValue,ErrorMessage = "Amount must be greater than 0")] // set range for value 
        public double Cost { get; set; }
    }
}
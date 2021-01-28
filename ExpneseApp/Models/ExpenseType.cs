using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpneseApp.Models
{
    public class ExpenseType
    {
      [Key]  public int Id { get; set; }
      public string ExpenseCategory { get; set; }
    }
}

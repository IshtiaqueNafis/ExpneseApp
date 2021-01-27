using ExpneseApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpneseApp.Data
{
    public class ApplicationDBContext:DbContext // inertied so the database can be created
    {
        public DbSet<Expense> Expenses { get; set; } // this the expense property created 

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)
        { 
            /*
             DbContextOptions<ApplicationDBContext>options):base(options) --> this takes the constructor 
              // this for establishing connection
        
            */
            
        }
    }
}
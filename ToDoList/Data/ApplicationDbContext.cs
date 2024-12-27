using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [StringLength(250)]
        public string FirstName { get; set; }

        [PersonalData]
        [StringLength(250)]
        public string LastName { get; set; }
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<TaskItem> TaskItems { get; set; }
    }
}

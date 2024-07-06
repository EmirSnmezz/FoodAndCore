using FoodAndCore.Models.Entites.Concretes;
using Microsoft.EntityFrameworkCore;

namespace FoodAndCore.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Data Source=EMIRSNMEZ;Initial Catalog=FoodAndCoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        public DbSet<Food> Foods {get; set;}
        public DbSet<Category> Categories { get; set; }
    }
}

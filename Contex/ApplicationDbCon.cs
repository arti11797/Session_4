using Microsoft.EntityFrameworkCore;

namespace WebAppSession_4.Contex
{
    public class ApplicationDbCon:DbContext
    {
        //constructor
        public ApplicationDbCon(DbContextOptions<ApplicationDbCon> Context) :base(Context)
        { 

        }
        public DbSet<Product> Products { get; set; }
       // public DbSet<Category> categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "ABCD",
                    Description = "New product",
                    Price = 300,
                    //CatId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "PQRS",
                    Description = "Old product",
                    Price = 300,
                    //CatId = 2
                });
            //modelBuilder.Entity<Category>().HasData(
            //   new Category
            //   {
            //       Id = 1,
            //       CategoryName= "Samsung",
                 
            //   },
            //   new Category
            //   {
            //       Id = 2,
            //       CategoryName = "Nokia",
                  
            //   });
        }
    }
}

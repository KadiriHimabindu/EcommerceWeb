using EcommerceWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWeb.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id =1,Name="Essentials for Face",DisplayOrder=1},
                new Category { Id = 2, Name = "Essentials for Eyes", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Essentials for Lips", DisplayOrder = 3}
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id =1,
                    Title = "Shower Gel",
                    Description = "Keeps the body hydrated and it will nourish and make your body soft",
                    MadeIn ="India",
                    Brand="Nivea",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = ""
                   
                    


                },
                new Product
                {
                    Id = 2,
                    Title = "Nail Varnish",
                    Description = "best thing to paint your nail which will give elegant color to ur nails.which will make u more attractive",
                    MadeIn = "India",
                    Brand = "Dazler",
                    ListPrice = 100,
                    Price = 80,
                    Price50 = 75,
                    Price100 = 70,
                    CategoryId = 1,
                    ImageUrl = ""
                   
                    
                },
                new Product
                {
                    Id = 3,
                    Title = "Eye Liner",
                    Description = "Best product to make ur eyes more attractive",
                    MadeIn = "India",
                    Brand = "Lakme",
                    ListPrice = 150,
                    Price = 140,
                    Price50 = 135,
                    Price100 = 130,
                    CategoryId = 2,
                    ImageUrl = ""
                   
                    
                },
                new Product
                {
                    Id = 4,
                    Title = "Lipstick",
                    Description="Best thing which will add more colors to Lips and make u more beautiful",
                    MadeIn="India",
                    Brand = "Mac matte",
                    ListPrice=300,
                    Price = 250,
                    Price50 = 200,
                    Price100 = 180,
                    CategoryId = 2,
                    ImageUrl = ""
                    
                    

                },
                new Product
                {
                    Id = 5,
                    Title = "Moisturizer",
                    Description="Keep your skin more soft and bright",
                    MadeIn="India",
                    Brand="Dermavive",
                    ListPrice = 800,
                    Price = 780,
                    Price50= 750,
                    Price100 = 700,
                    CategoryId = 3,
                    ImageUrl = ""
                   

                },
                new Product
                {
                    Id = 6,
                    Title = "Shampoo",
                    Description = "Keep your hair dandruf free soft and silky",
                    MadeIn = "India",
                    Brand = "Head and Shoulder",
                    ListPrice = 200,
                    Price = 180,
                    Price50 = 175,
                    Price100 = 170,
                    CategoryId = 3,
                    ImageUrl = ""
                   

                }
                );
        }
    }
}

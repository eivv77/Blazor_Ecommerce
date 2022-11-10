
namespace BlazorEcommerce.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "FIRST",
                    Description = "first product",
                    ImageUrl = "",
                    Price = 10
                },
                new Product
                {
                    Id = 2,
                    Title = "SECOND",
                    Description = "second product",
                    ImageUrl = "",
                    Price = 20
                }, new Product
                {
                    Id = 3,
                    Title = "THIRD",
                    Description = "third product",
                    ImageUrl = "",
                    Price = 30
                }
                );
        }

        public DbSet<Product> Products { get; set; }

    }
}

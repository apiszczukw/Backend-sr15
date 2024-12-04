using Backend_sr15.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_sr15.DAL
{
	public class ShopContext : DbContext
	{
        public DbSet<Product> Products { get; set; }

        public ShopContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Product>().HasData(
				new Product() { Id=1, Name="pomidor", Price=8.5 },
				new Product() { Id=2, Name="ziemniaki", Price=2.3 },
				new Product() { Id=3, Name="ogórek", Price=6 },
				new Product() { Id=4, Name="kalafior", Price=8.99 },
				new Product() { Id=5, Name="cukinia", Price=7.5 }
				);
		}
	}
}

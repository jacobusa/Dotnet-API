using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;

namespace ProductsApi.Data
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext()
        {
            
        }

        public DataContext(DbContextOptions<DataContext> options): base(options){

        }
        public DbSet<Product> Products { get; init; }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            var products = new List<Product>(){
                new Product{
                    ProductId=1,
                    Name="Gold",
                    Description="Most valuable precious metal",
                    Link="https://responsive.fxempire.com/v7/_fxempire_/2020/06/Gold-11.jpg?func=cover&q70&width=615",
                    Price=12000,
                    DateCreated=System.DateTime.UtcNow
                },
                new Product{
                    ProductId=2,
                    Name="Silver",
                    Description="Second most valuable precious metal",
                    Link="https://e7j3v5v7.rocketcdn.me/wp-content/uploads/2020/05/327446-silver-1024x640.jpg",
                    Price=6000,
                    DateCreated=System.DateTime.UtcNow
                },
                new Product{
                    ProductId=3,
                    Name="Bitcoin",
                    Description="Digital Gold",
                    Link="https://i.guim.co.uk/img/media/09de088fe70256cfae7c4bc42b6cded754545133/0_66_3500_2100/master/3500.jpg?width=620&quality=85&auto=format&fit=max&s=5d8ef8483e18802012c16ef18a7f9568",
                    Price=40000,
                    DateCreated=System.DateTime.UtcNow
                },
                new Product{
                    ProductId=4,
                    Name="Xerris",
                    Description="Software Consulting",
                    Link="https://www.xerris.com/images/xerris-logo.svg",
                    Price=100000,
                    DateCreated=System.DateTime.UtcNow
                },
            };

            modelBuilder.Entity<Product>().HasData(products);
        }
        public DbSet<User> Users { get ; init; }
    }
}
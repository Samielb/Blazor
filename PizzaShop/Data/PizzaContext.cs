using Microsoft.EntityFrameworkCore;
using PizzaShop.Models;

namespace PizzaShop.Data;

public class PizzaContext : DbContext
{
    public PizzaContext(DbContextOptions<PizzaContext> options)
        : base(options)
    {
    }

    public DbSet<Pizza> Pizzas => Set<Pizza>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pizza>().HasData(
            new Pizza { Id = 1, Name = "Margherita", Description = "Classic tomato and mozzarella", Price = 8.99m, IsVegetarian = true, IsVegan = false },
            new Pizza { Id = 2, Name = "Pepperoni", Description = "Classic pepperoni with mozzarella", Price = 10.99m, IsVegetarian = false, IsVegan = false },
            new Pizza { Id = 3, Name = "Veggie", Description = "Mixed vegetables with mozzarella", Price = 9.99m, IsVegetarian = true, IsVegan = false },
            new Pizza { Id = 4, Name = "Vegan Supreme", Description = "Plant-based cheese with vegetables", Price = 11.99m, IsVegetarian = true, IsVegan = true }
        );
    }
}

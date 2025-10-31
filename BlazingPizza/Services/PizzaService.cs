using BlazingPizza.Models;

namespace BlazingPizza.Services;

public class PizzaService
{
    public Task<List<PizzaSpecial>> GetPizzaSpecialsAsync()
    {
        var specials = new List<PizzaSpecial>
        {
            new() { 
                Id = 1, 
                Name = "Margherita", 
                Price = 8.99m, 
                Description = "Classic tomato and mozzarella",
                ImageUrl = "https://images.unsplash.com/photo-1604382355076-af4b0eb60143?w=300&auto=format&fit=crop"
            },
            new() { 
                Id = 2, 
                Name = "Pepperoni", 
                Price = 9.99m, 
                Description = "Classic pepperoni with mozzarella",
                ImageUrl = "https://images.unsplash.com/photo-1628840042765-356cda07504e?w=300&auto=format&fit=crop"
            },
            new() { 
                Id = 3, 
                Name = "Hawaiian", 
                Price = 10.99m, 
                Description = "Ham and pineapple on a classic base",
                ImageUrl = "https://images.unsplash.com/photo-1601312344201-d5a5c9354fd2?w=300&auto=format&fit=crop"
            }
        };

        return Task.FromResult(specials);
    }
}

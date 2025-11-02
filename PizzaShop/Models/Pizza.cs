namespace PizzaShop.Models;

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal BasePrice { get; set; }
    public bool IsVegetarian { get; set; }
    public bool IsVegan { get; set; }
    
    // Order-specific properties
    public string? Size { get; set; } = "Medium";
    public int Quantity { get; set; } = 1;
    public string? SpecialInstructions { get; set; }
    
    public decimal Price 
    { 
        get 
        {
            decimal multiplier = Size switch
            {
                "Small" => 0.8m,
                "Large" => 1.2m,
                _ => 1.0m // Medium or default
            };
            return BasePrice * multiplier * Quantity;
        }
    }
    
    public Pizza Clone()
    {
        return (Pizza)this.MemberwiseClone();
    }
}

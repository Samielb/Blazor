namespace PizzaShop.Models;

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public bool IsVegetarian { get; set; }
    public bool IsVegan { get; set; }
}

using PizzaShop.Data;
using PizzaShop.Models;
using Microsoft.EntityFrameworkCore;

namespace PizzaShop.Services;

public class PizzaService
{
    private readonly PizzaContext _context;

    public PizzaService(PizzaContext context)
    {
        _context = context;
    }

    public async Task<List<Pizza>> GetPizzasAsync()
    {
        return await _context.Pizzas.ToListAsync();
    }
}

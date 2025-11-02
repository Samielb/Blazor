using PizzaShop.Models;

namespace PizzaShop.Services;

public class OrderState
{
    private readonly List<Pizza> _orderItems = new();
    
    public IReadOnlyList<Pizza> OrderItems => _orderItems.AsReadOnly();
    public Pizza? ConfiguringPizza { get; private set; }
    public bool ShowingConfigureDialog { get; private set; }
    public bool ShowingOrderSidebar { get; private set; }

    public event Action? OnChange;
    
    public decimal TotalPrice => _orderItems.Sum(p => p.Price);
    public int TotalItems => _orderItems.Sum(p => p.Quantity);

    public void ShowConfigurePizzaDialog(Pizza pizza)
    {
        // Create a deep copy of the pizza to avoid modifying the original
        ConfiguringPizza = pizza.Clone();
        ShowingConfigureDialog = true;
        ShowingOrderSidebar = true;
        NotifyStateChanged();
    }

    public void CancelConfigurePizzaDialog()
    {
        ConfiguringPizza = null;
        ShowingConfigureDialog = false;
        NotifyStateChanged();
    }

    public void ConfirmPizzaConfiguration()
    {
        if (ConfiguringPizza != null)
        {
            _orderItems.Add(ConfiguringPizza);
            ConfiguringPizza = null;
            ShowingConfigureDialog = false;
            NotifyStateChanged();
        }
    }
    
    public void RemovePizzaFromOrder(Pizza pizza)
    {
        _orderItems.Remove(pizza);
        NotifyStateChanged();
    }
    
    public void ToggleOrderSidebar()
    {
        ShowingOrderSidebar = !ShowingOrderSidebar;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}

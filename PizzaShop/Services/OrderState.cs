using PizzaShop.Models;

namespace PizzaShop.Services;

public class OrderState
{
    public Pizza? ConfiguringPizza { get; private set; }
    public bool ShowingConfigureDialog { get; private set; }

    public event Action? OnChange;

    public void ShowConfigurePizzaDialog(Pizza pizza)
    {
        ConfiguringPizza = pizza;
        ShowingConfigureDialog = true;
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
        // In a real app, you would save the configured pizza to an order here
        ConfiguringPizza = null;
        ShowingConfigureDialog = false;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}

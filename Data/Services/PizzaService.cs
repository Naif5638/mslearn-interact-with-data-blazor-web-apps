namespace BlazingPizza.Data.Services;

public sealed class PizzaService
{
    public async Task<Pizza[]> GetPizzasAsync()
    {
        await Task.CompletedTask;
        return new List<Pizza>().ToArray();
    }
}
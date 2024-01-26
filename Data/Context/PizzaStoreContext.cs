namespace BlazingPizza.Data.Context;

using Microsoft.EntityFrameworkCore;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options) : base(options)
    { }

    public DbSet<PizzaSpecial> Specials { get; set; }
}
namespace BlazingPizza.Controllers;

using BlazingPizza.Data.Context;
using BlazingPizza.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("specials")]
public class SpecialsController : Controller
{
    private readonly PizzaStoreContext _context;

    public SpecialsController(PizzaStoreContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecialsAsync()
    {
        return (await _context.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}
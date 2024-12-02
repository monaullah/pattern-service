using Microsoft.AspNetCore.Mvc;

namespace PatternService.Controllers;

[ApiController]
[Route("[controller]")]
public class FirstController : ControllerBase
{
    static readonly List<(int, string)> Customers =
    [
        (0, "Customer 1"),
        (1, "Customer 2"),
        (2, "Customer 3"),
        (3, "Customer 4")
    ];
    
    [HttpGet]
    public IEnumerable<(int, string)> Get()
    {
        var customer = Customers;
        return customer;
    }

    [HttpGet("{id:int}")]
    public (int, string) Get(int id)
    {
        var customer = Customers.FirstOrDefault(customer => customer.Item1 == id);

        return customer;
    }
}
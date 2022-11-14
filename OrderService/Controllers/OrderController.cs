using System.Diagnostics;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 
using OrderService.Data;

namespace OrderService.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly AppDbContext _dbContext;
    private readonly ILogger<OrderController> _logger;

    public OrderController(ILogger<OrderController> logger, AppDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext; 
    }

    [HttpGet(Name = "GetOrders")]
    public async Task<IActionResult> Get()
    {
        return Ok(await _dbContext.Orders.ToListAsync()); 
    }
}

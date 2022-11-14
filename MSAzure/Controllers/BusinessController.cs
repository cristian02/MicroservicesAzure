using Microsoft.AspNetCore.Mvc;
using MSAzure.Models;

namespace MSAzure.Controllers;

[ApiController]
[Route("[controller]")]
public class BusinessController : ControllerBase
{
    private readonly ILogger<BusinessController> _logger;
    private readonly sampleDBContext _context; 

    public BusinessController(ILogger<BusinessController> logger, sampleDBContext context)
    {
        _logger = logger;
        _context = context; 
    }

    [HttpPost(Name = "CreateUser")]
    public IActionResult CreateUser(User user)
    {
        _context.Users.AddAsync(user); 
        _context.SaveChangesAsync(); 
        return Ok(); 
    }
}

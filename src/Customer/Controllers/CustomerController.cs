using Customer.Application;
using Customer.Models;
using Microsoft.AspNetCore.Mvc;
using DomainCustomer = Customer.Domain;

namespace Customer.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateNewCustomerRequest request)
    {
        var customer = new DomainCustomer.Customer(
            request.Document,
            request.FirstName,
            request.LastName,
            request.BirthDate,
            request.Income);

        await _customerService.CreateCustomer(customer);

        return NoContent();
    }
}
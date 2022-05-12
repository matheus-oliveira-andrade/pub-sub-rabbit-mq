using Core.Events;
using MassTransit;

namespace Customer.Application;

public class CustomerService : ICustomerService
{
    private readonly ILogger<CustomerService> _logger;
    private readonly IPublishEndpoint _publishEndpoint;

    public CustomerService(ILogger<CustomerService> logger, IPublishEndpoint publishEndpoint)
    {
        _logger = logger;
        _publishEndpoint = publishEndpoint;
    }

    public async Task CreateCustomer(Domain.Customer customer)
    {
        _logger.LogInformation("Creating new customer");

        // TODO: Implement data access

        _logger.LogInformation("New customer created");
        
        await _publishEndpoint.Publish<NewCustomerCreated>(new
        {
            Document = customer.Document,
            FirstName = customer.FirstName,
            Income = customer.Income,
        });
    }
}
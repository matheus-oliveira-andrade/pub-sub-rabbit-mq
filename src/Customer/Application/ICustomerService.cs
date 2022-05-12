namespace Customer.Application;

public interface ICustomerService
{
    Task CreateCustomer(Domain.Customer customer);
}
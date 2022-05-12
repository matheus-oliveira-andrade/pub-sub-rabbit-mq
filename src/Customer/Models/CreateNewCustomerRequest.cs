namespace Customer.Models;

public class CreateNewCustomerRequest
{
    public string Document { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public float Income { get; set; }
}
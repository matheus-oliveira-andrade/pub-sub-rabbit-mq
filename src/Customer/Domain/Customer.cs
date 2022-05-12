namespace Customer.Domain;

public class Customer
{
    public string Document { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public DateTime BirthDate { get; }
    public float Income { get; }

    public Customer(string document, string firstName, string lastName, DateTime birthDate, float income)
    {
        Document = document;
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        Income = income;
    }
}
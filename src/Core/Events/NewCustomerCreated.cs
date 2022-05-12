namespace Core.Events;

public interface NewCustomerCreated
{
    public string Document { get; }
    public string FirstName { get; }
    public float Income { get; }
}
using Core.Events;
using MassTransit;

namespace CreditAnalysis;

public class NewCustomerCreatedConsumer : IConsumer<NewCustomerCreated>
{
    public Task Consume(ConsumeContext<NewCustomerCreated> context)
    {
        Console.WriteLine($"[CreditAnalysis] Consumed message customer [{context.Message.Document}] - {context.Message.FirstName}");
        
        return Task.CompletedTask;
    }
}
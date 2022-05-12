using Core.Events;
using MassTransit;

namespace AntiFraud;

public class NewCustomerCreatedConsumer : IConsumer<NewCustomerCreated>
{
    public Task Consume(ConsumeContext<NewCustomerCreated> context)
    {
        Console.WriteLine($"[Antifraud] Consumed message customer [{context.Message.Document}] - {context.Message.FirstName}");

        return Task.CompletedTask;
    }
}
using CreditAnalysis;
using MassTransit;

Console.WriteLine("Starting credit analysis");

var busControl = Bus.Factory.CreateUsingRabbitMq(config =>
{
    config.ReceiveEndpoint("credit-analysis", 
        e => e.Consumer<NewCustomerCreatedConsumer>());
});

var source = new CancellationTokenSource(TimeSpan.FromSeconds(10));

await busControl.StartAsync(source.Token);

Console.WriteLine("Waiting for messages");

while (true) ;
using AntiFraud;
using MassTransit;

Console.WriteLine("Starting anti-fraud");

var busControl = Bus.Factory.CreateUsingRabbitMq(config =>
{
    config.ReceiveEndpoint("anti-fraud", 
        e => e.Consumer<NewCustomerCreatedConsumer>());
});

var source = new CancellationTokenSource(TimeSpan.FromSeconds(10));

await busControl.StartAsync(source.Token);

Console.WriteLine("Waiting for messages");

while (true) ;
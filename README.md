## Publisher-Subscriber pattern 

using rabbitMQ, MassTransit and .net 6.0

## Setup

    docker-compose up -d

Consumers

    dotnet run --project src/CreditAnalysis

    dotnet run --project src/AntiFraud
    
Producer    

    dotnet run --project src/Customer

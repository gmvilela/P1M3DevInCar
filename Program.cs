using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using P1M3DevInCar.Context;
using P1M3DevInCar.GraphQL.Models;
using P1M3DevInCar.GraphQL.Mutations;
using P1M3DevInCar.GraphQL.Queries;
using P1M3DevInCar.GraphQL.Subscriptions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DevInCarContext>(options =>
                        options.UseSqlServer(builder.Configuration
                        .GetConnectionString("ServerConnection")));

builder.Services
        .AddGraphQLServer()
        .AddAuthorization()

        //queries
        .AddQueryType()
        .AddTypeExtension<VeiculoQueries>()
        
        //mutations
        .AddMutationType()
        .AddTypeExtension<VeiculoMutation>()
        
        //subscriptions
        .AddSubscriptionType()
        .AddTypeExtension<VeiculoSubscription>()

        .AddInMemorySubscriptions()
        .AddApolloTracing();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.UseWebSockets()
    .UseRouting()
    .UseEndpoints(endpoint => endpoint.MapGraphQL()); 

app.Run();

using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CareersService;
using careerService.Repositories;
using careerService.Data;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<CareerServiceDbSettings>(
    builder.Configuration.GetSection("MongoDB"));

builder.Services.AddSingleton<IMongoClient>(sp =>
{
    var settings = sp.GetRequiredService<IOptions<CareerServiceDbSettings>>().Value;
    return new MongoClient(settings.ConnectionString);
});

builder.Services.AddScoped(sp =>
{
    var settings = sp.GetRequiredService<IOptions<CareerServiceDbSettings>>().Value;
    var mongoClient = sp.GetRequiredService<IMongoClient>();
    return mongoClient.GetDatabase(settings.DatabaseName);
});

builder.Services.AddScoped(sp =>
{
    var mongoClient = sp.GetRequiredService<IMongoClient>();
    var databaseName = builder.Configuration.GetValue<string>("MongoDB:DatabaseName");
    return mongoClient.GetDatabase(databaseName);
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGrpc();
builder.Services.AddScoped<ICareerRepository, CareerRepository>();

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5093, listenOptions =>
    {
        listenOptions.Protocols = Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http2;
    });
});
builder.Logging.AddConsole();


var app = builder.Build();

app.MapGrpcService<CareerService>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();


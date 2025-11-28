using Services.Toolkit.API.ServiceExtensions;
using Services.Toolkit.API.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.HealthCheckApi();

await app.RunAsync();

using Infrastructure.Data;
using Infrastructure.Interfaces;
using Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddConnections();
builder.Services.AddScoped<DataContext>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "WebApi"));
}

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();
app.Run();
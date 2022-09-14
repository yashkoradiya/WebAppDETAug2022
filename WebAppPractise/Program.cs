using Microsoft.EntityFrameworkCore;
using WebAppPractise.Models;
using static WebAppPractise.Models.ToDoContext;
using Microsoft.Extensions.DependencyInjection;
using WebAppPractise.Data;
using Microsoft.AspNetCore.OData;
using Microsoft.CodeAnalysis.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebAppPractiseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebAppPractiseContext") ?? throw new InvalidOperationException("Connection string 'WebAppPractiseContext' not found.")));

// Add services to the container.

builder.Services.AddControllers().AddOData(Option => Option.Select());
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "TodoApi", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApi v1"));
}
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
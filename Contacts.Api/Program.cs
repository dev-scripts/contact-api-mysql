using Contacts.Api.Data;
using Contacts.Api.Repositories;
using Contacts.Api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#pragma warning disable CS8604 // Possible null reference argument.
builder.Services.AddDbContext<ContactDbContext>(option => option.UseMySQL(builder.Configuration.GetConnectionString("ContactApiConnectionString")));
builder.Services.AddTransient<IContactRepository, ContactRepository>();
builder.Services.AddTransient<IContactService, ContactService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
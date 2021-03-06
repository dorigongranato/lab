using Lab.Repository.Implementation;
using Lab.Repository.Infra;
using Lab.Repository.Interface;
using Lab.Service.Implementation;
using Lab.Entity.Interface;
using Lab.Entity.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IDbFactory, DbFactory>();

builder.Services.AddTransient<IClienteService, ClienteService>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();

builder.Services.AddTransient<ITransportePessoalService, TransportePessoalService>();
builder.Services.AddTransient<ITransportePessoalRepository, TransportePessoalRepository>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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


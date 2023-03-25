using FSBankAPI.Interfaces;
using FSBankAPI.Services;

var builder = WebApplication.CreateBuilder();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IClientesServices, ClienteServices>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();

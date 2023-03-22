var builder = WebApplication.CreateBuilder();
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();

app.Run();

//var soma = (int num1, int num2) => num1 + num2;
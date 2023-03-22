using BasicAPI.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder();

var app = builder.Build();

app.MapGet("/Clientes/id/{id}", ([FromQuery] string nome, [FromRoute] int id) => Results.Ok(new Cliente(id, nome)));
// http://localhost:5000/Clientes/id/5?nome=Lucas


var carros = new List<string>();

carros.Add("Gol");
carros.Add("Argo");
carros.Add("Nivus");

//app.MapGet("/veiculos/", () => Results.Ok(carros));
app.MapGet("/veiculos/", ([FromQuery] string carro) =>
{
    if (string.IsNullOrEmpty(carro))
    {
        return Results.Ok(carros);
    }

    if (carros.Exists(x => x == carro))
    {
        return Results.Ok("Carro cadastrado!");
    }
    else
    {
        return Results.NoContent();
    }
});
// http://localhost:5000/veiculos


app.MapPost("/veiculos/", ([FromQuery] string carro) =>
{
    carros.Add(carro);
    return Results.Ok(carros);
});
// http://localhost:5000/veiculos?carro=Ferrari (método POST)


app.MapDelete("/veiculos/", ([FromQuery] string carro) =>
{
    carros.Remove(carro);
    return Results.Ok();
});
// http://localhost:5000/veiculos?carro=Ferrari (método DELETE)


app.Run();

//var soma = (int num1, int num2) => num1 + num2;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "API Calculadora: use /calc/...");

app.MapGet("/calc/somar", (double x, double y) =>
{
    return Results.Ok(new { Operacao = "Soma", Resultado = x + y });
});

app.MapGet("/calc/subtrair", (double x, double y) =>
{
    return Results.Ok(new { Operacao = "Subtração", Resultado = x - y });
});

app.MapGet("/calc/multiplicar", (double x, double y) =>
{
    return Results.Ok(new { Operacao = "Multiplicação", Resultado = x * y });
});

app.MapGet("/calc/dividir", (double x, double y) =>
{
    if (y == 0)
        return Results.BadRequest(new { Erro = "Divisão por zero não permitida" });

    return Results.Ok(new { Operacao = "Divisão", Resultado = x / y });
});

app.MapGet("/calc/potencia", (double @base, double exp) =>
{
    return Results.Ok(new { Operacao = "Potência", Resultado = Math.Pow(@base, exp) });
});

app.MapGet("/calc/raiz", (double x) =>
{
    if (x < 0)
        return Results.BadRequest(new { Erro = "Não existe raiz real de número negativo" });

    return Results.Ok(new { Operacao = "Raiz Quadrada", Resultado = Math.Sqrt(x) });
});

app.MapGet("/calc/porcentagem", (double valor, double pct) =>
{
    return Results.Ok(new
    {
        Operacao = "Porcentagem",
        Resultado = valor * (pct / 100.0)
    });
});

app.Run();

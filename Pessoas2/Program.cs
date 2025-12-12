using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// "Banco" em memória (vai sumir ao reiniciar o servidor)
List<Pessoa> pessoas = new List<Pessoa>()
{
    new Pessoa { Id = 1, Nome = "Ana", Idade = 25 },
    new Pessoa { Id = 2, Nome = "Bruno", Idade = 32 },
    new Pessoa { Id = 3, Nome = "Carla",  Idade = 28 }
};

// ======== READ (Lista todas) ========
app.MapGet("/pessoas", () => pessoas);

// ======== READ (Por ID) ========
app.MapGet("/pessoas/{id}", (int id) =>
{
    var p = pessoas.FirstOrDefault(x => x.Id == id);
    return p is null ? Results.NotFound() : Results.Ok(p);
});

// ======== CREATE ========
app.MapPost("/pessoas", (Pessoa nova) =>
{
    nova.Id = pessoas.Any() ? pessoas.Max(x => x.Id) + 1 : 1;
    pessoas.Add(nova);
    return Results.Created($"/pessoas/{nova.Id}", nova);
});

// ======== UPDATE ========
app.MapPut("/pessoas/{id}", (int id, Pessoa editada) =>
{
    var p = pessoas.FirstOrDefault(x => x.Id == id);
    if (p is null) return Results.NotFound();

    p.Nome = editada.Nome;
    p.Idade = editada.Idade;

    return Results.Ok(p);
});

// ======== DELETE ========
app.MapDelete("/pessoas/{id}", (int id) =>
{
    var p = pessoas.FirstOrDefault(x => x.Id == id);
    if (p is null) return Results.NotFound();

    pessoas.Remove(p);
    return Results.Ok(p);
});

app.Run();

record Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
}

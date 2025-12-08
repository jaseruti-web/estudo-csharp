var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Pessoa> pessoas = new()
{
    new Pessoa(1, "Ana"),
    new Pessoa(2, "Bruno"),
    new Pessoa(3, "Carla")
};

// ROTA 1 – lista todas
app.MapGet("/pessoas", () => pessoas);

// ROTA 2 – busca por id
app.MapGet("/pessoas/{id}", (int id) =>
{
    var pessoa = pessoas.FirstOrDefault(p => p.Id == id);
    return pessoa is null ? Results.NotFound() : Results.Ok(pessoa);
});

app.Run();

record Pessoa(int Id, string Nome);


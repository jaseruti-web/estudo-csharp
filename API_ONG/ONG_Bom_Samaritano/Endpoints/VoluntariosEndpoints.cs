using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ONG_Bom_Samaritano.Models.Voluntarios;

namespace ONG_Bom_Samaritano.Endpoints;

public static class VoluntariosEndpoints
{
    public static void MapVoluntariosEndpoints(this WebApplication app)
    {
        // Teste com ESTAGIÁRIO (classe concreta)
        app.MapGet("/voluntarios/teste", () =>
        {
            var estagiario = new Estagiario
            {
                Nome = "João",
                Email = "joao@email.com",
                Curso = "Engenharia",
                AreaAtuacao = "Classificador de Riscos ",

            };

            return Results.Ok(estagiario);
        });
    }
}

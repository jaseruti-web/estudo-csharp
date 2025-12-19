using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ONG_Bom_Samaritano.Endpoints
{
    public static class OcorrenciasEndpoints
    {
        public static void MapOcorrenciasEndpoints(this WebApplication app)
        {
            app.MapGet("/ocorrencias", () =>
            {
                return Results.Ok("Endpoint de ocorrências funcionando");
            });
        }
    }
}

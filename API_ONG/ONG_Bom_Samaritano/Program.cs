using ONG_Bom_Samaritano.Endpoints;
using ONG_Bom_Samaritano.Models.Voluntarios;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "API ONG Bom Samaritano - Online");


app.MapVoluntariosEndpoints();
app.MapOcorrenciasEndpoints();




app.Run();

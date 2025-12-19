namespace ApiOng.DesviosUrbanos.Models;

public class Ocorrencia
{
    public Guid Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public DateTime DataRegistro { get; set; }
}

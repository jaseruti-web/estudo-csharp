namespace ONG_Bom_Samaritano.Models.Voluntarios;

public abstract class POP
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Curso { get; set; } = string.Empty;

    public int IndiceResponsividade { get; set; }
    public DateTime DataCadastro { get; set; } = DateTime.UtcNow;

    public virtual string Tipo => "POP";
}

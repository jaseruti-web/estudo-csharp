namespace ONG_Bom_Samaritano.Models.Voluntarios;

public class Top
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;

    public string Login { get; set; } = string.Empty;
    public string SenhaHash { get; set; } = string.Empty;

    public bool PodeEditarProcedimentos { get; set; }
}

public class Voluntario
{
    public Guid Id { get; set; }

    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    // Perfil geral
    public bool Ativo { get; set; } = true;
    public DateTime DataCadastro { get; set; } = DateTime.UtcNow;

    // Reputação (derivada, não manual)
    public int NivelConfiabilidade { get; set; } // ex: 1 a 5
    public int PontuacaoGeral { get; set; }      // calculada, não editável
}

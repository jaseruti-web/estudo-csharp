namespace ONG_Bom_Samaritano.Models.Voluntarios;

public class Eco : POP
{
    public string CodigoIndicacao { get; set; } = string.Empty;
    public int TotalIndicacoes { get; set; }

    public override string Tipo => "ECO";
}


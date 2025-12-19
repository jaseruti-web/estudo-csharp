namespace ONG_Bom_Samaritano.Models.Voluntarios;

public class Estagiario : POP
{
    public DateTime InicioEstagio { get; set; }
    public string AreaAtuacao { get; set; } = string.Empty;

    public override string Tipo => "ESTAGIARIO";


}



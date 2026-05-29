namespace MeuApp.Web.Features.Checkins.Models;

public class CheckinPreview
{
    public int Id { get; set; }
    public int AtletaId { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Peso { get; set; } = string.Empty;
    public string Gordura { get; set; } = string.Empty;
    public string Aderencia { get; set; } = string.Empty;
    public string Semana { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;

    public string SonoMedio { get; set; } = string.Empty;
    public string DataEnvio { get; set; } = string.Empty;
    public string Resumo { get; set; } = string.Empty;
    public string RespostaTreino { get; set; } = string.Empty;
    public string RespostaDieta { get; set; } = string.Empty;
    public string RespostaDores { get; set; } = string.Empty;
    public string Observacoes { get; set; } = string.Empty;
}

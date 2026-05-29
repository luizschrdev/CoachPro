namespace MeuApp.Web.Features.Chat.Models;

public class ChatMessage
{
    public string Texto { get; set; } = string.Empty;
    public string Horario { get; set; } = string.Empty;
    public bool EnviadaPeloCoach { get; set; }
}
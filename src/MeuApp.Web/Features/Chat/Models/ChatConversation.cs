namespace MeuApp.Web.Features.Chat.Models;

public class ChatConversation
{
    public int AtletaId { get; set; }
    public string NomeAtleta { get; set; } = string.Empty;
    public string Iniciais { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string UltimaMensagem { get; set; } = string.Empty;
    public string UltimoHorario { get; set; } = string.Empty;
    public List<ChatMessage> Mensagens { get; set; } = [];
}
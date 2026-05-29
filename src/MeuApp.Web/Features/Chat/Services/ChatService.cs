using MeuApp.Web.Features.Chat.Models;

namespace MeuApp.Web.Features.Chat.Services;

public class ChatService
{
    private readonly List<ChatConversation> _conversas =
    [
        new ChatConversation
        {
            AtletaId = 1,
            NomeAtleta = "Lucas Mendes",
            Iniciais = "LM",
            Status = "Ativo agora",
            UltimaMensagem = "Coach, consegui aumentar 5kg no supino hoje.",
            UltimoHorario = "09:14",
            Mensagens =
            [
                new ChatMessage
                {
                    Texto = "Coach, fiz o treino de peito hoje. Consegui aumentar 5kg no supino.",
                    Horario = "09:14",
                    EnviadaPeloCoach = false
                },
                new ChatMessage
                {
                    Texto = "Ótimo, Lucas! Isso é excelente progressão. Continue assim e na próxima semana ajustamos o volume.",
                    Horario = "09:22",
                    EnviadaPeloCoach = true
                },
                new ChatMessage
                {
                    Texto = "Vou manter o foco. Posso substituir a banana pré-treino por maçã?",
                    Horario = "09:35",
                    EnviadaPeloCoach = false
                }
            ]
        },
        new ChatConversation
        {
            AtletaId = 2,
            NomeAtleta = "Mariana Alves",
            Iniciais = "MA",
            Status = "2h atrás",
            UltimaMensagem = "Posso trocar a refeição livre para sábado?",
            UltimoHorario = "08:40",
            Mensagens =
            [
                new ChatMessage
                {
                    Texto = "Posso trocar a refeição livre para sábado?",
                    Horario = "08:40",
                    EnviadaPeloCoach = false
                }
            ]
        },
        new ChatConversation
        {
            AtletaId = 3,
            NomeAtleta = "João Pereira",
            Iniciais = "JP",
            Status = "Ontem",
            UltimaMensagem = "Enviei o check-in da semana para revisão.",
            UltimoHorario = "Ontem",
            Mensagens =
            [
                new ChatMessage
                {
                    Texto = "Enviei o check-in da semana para revisão.",
                    Horario = "Ontem",
                    EnviadaPeloCoach = false
                }
            ]
        }
    ];

    public List<ChatConversation> ListarConversas()
    {
        return _conversas;
    }

    public ChatConversation? ObterConversaPorAtletaId(int atletaId)
    {
        return _conversas.FirstOrDefault(c => c.AtletaId == atletaId);
    }

    public void EnviarMensagem(int atletaId, string texto)
    {
        var conversa = ObterConversaPorAtletaId(atletaId);

        if (conversa is null || string.IsNullOrWhiteSpace(texto))
            return;

        conversa.Mensagens.Add(new ChatMessage
        {
            Texto = texto,
            Horario = DateTime.Now.ToString("HH:mm"),
            EnviadaPeloCoach = true
        });

        conversa.UltimaMensagem = texto;
        conversa.UltimoHorario = DateTime.Now.ToString("HH:mm");
    }
}
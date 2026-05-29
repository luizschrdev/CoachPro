using MeuApp.Web.Features.Checkins.Models;

namespace MeuApp.Web.Features.Checkins.Services;

public class CheckinService
{
    private readonly List<CheckinPreview> _checkins =
    [
        new()
        {
            Id = 1,
            AtletaId = 1,
            Nome = "Lucas Mendes",
            Peso = "82 kg",
            Gordura = "16%",
            Aderencia = "92%",
            Semana = "6",
            Status = "Revisar",
            SonoMedio = "7h20",
            DataEnvio = "26/05/2026",
            Resumo = "Relatou boa progressão no supino e energia estável durante a semana.",
            RespostaTreino = "Completei todos os treinos e aumentei 5kg no supino.",
            RespostaDieta = "Mantive bem durante a semana, mas tive dificuldade no pré-treino.",
            RespostaDores = "Sem dores. Apenas fadiga normal no treino de pernas.",
            Observacoes = "Atleta motivado e com boa aderência geral."
        },
        new()
        {
            Id = 2,
            AtletaId = 2,
            Nome = "Mariana Alves",
            Peso = "64 kg",
            Gordura = "22%",
            Aderencia = "78%",
            Semana = "6",
            Status = "Revisar",
            SonoMedio = "6h40",
            DataEnvio = "26/05/2026",
            Resumo = "Teve boa execução nos treinos, mas relatou dificuldade na dieta no final de semana.",
            RespostaTreino = "Fiz 4 treinos na semana, mas perdi um cardio.",
            RespostaDieta = "Consegui seguir bem durante a semana, mas saí um pouco no sábado.",
            RespostaDores = "Sem dores relevantes.",
            Observacoes = "Pode precisar de mais flexibilidade na refeição livre."
        },
        new()
        {
            Id = 3,
            AtletaId = 1,
            Nome = "João Pereira",
            Peso = "91 kg",
            Gordura = "18%",
            Aderencia = "88%",
            Semana = "6",
            Status = "Aprovado",
            SonoMedio = "7h00",
            DataEnvio = "26/05/2026",
            Resumo = "Semana consistente, boa aderência ao treino e evolução controlada.",
            RespostaTreino = "Completei todos os treinos da semana.",
            RespostaDieta = "Segui bem a dieta.",
            RespostaDores = "Sem desconfortos.",
            Observacoes = "Manter protocolo atual."
        },
        new()
        {
            Id = 4,
            AtletaId = 2,
            Nome = "Ana Costa",
            Peso = "58 kg",
            Gordura = "21%",
            Aderencia = "84%",
            Semana = "6",
            Status = "Revisar",
            SonoMedio = "6h50",
            DataEnvio = "26/05/2026",
            Resumo = "Boa rotina geral, mas ainda oscila na ingestão de água.",
            RespostaTreino = "Treinos realizados conforme planejado.",
            RespostaDieta = "Segui bem, mas tive dificuldade com horários.",
            RespostaDores = "Leve desconforto lombar.",
            Observacoes = "Avaliar ajuste em exercícios de perna."
        }
    ];

    public List<CheckinPreview> Listar()
    {
        return _checkins;
    }

    public CheckinPreview? ObterPorId(int id)
    {
        return _checkins.FirstOrDefault(c => c.Id == id);
    }

    public void Aprovar(int id)
    {
        var checkin = ObterPorId(id);

        if (checkin is not null)
        {
            checkin.Status = "Aprovado";
        }
    }
}

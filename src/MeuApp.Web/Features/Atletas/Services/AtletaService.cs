using MeuApp.Web.Features.Atletas.Models;

namespace MeuApp.Web.Features.Atletas.Services;

public class AtletaService
{
    private readonly List<Atleta> _Atleta =
    [
        new Atleta
        {
            Id = 1,
            Name = "Lucas Mendes",
            Email = "atleta@meuplano.com",
            Telefone = "(48) 99999-9999",
            Status = "Ativo"
        },
        new Atleta
        {
            Id = 2,
            Name = "Atleta Exemplo 2",
            Email = "atletaexemplo2@email.com",
            Telefone = "(48) 99999-9998",
            Status = "Ativo"
        }
    ];

    public Task<List<Atleta>> ListarAsync()
    {
        return Task.FromResult(_Atleta);
    }

    public Task AdicionarAsync(Atleta atleta)
    {
        atleta.Id = _Atleta.Count + 1;
        _Atleta.Add(atleta);

        return Task.CompletedTask;
    }
}

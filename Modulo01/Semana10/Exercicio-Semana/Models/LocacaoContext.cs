using Microsoft.EntityFrameworkCore;

namespace Exercicio_Semana.Models;

public class LocacaoContext : DbContext
{
    public LocacaoContext(DbContextOptions<LocacaoContext> options) : base(options)
    {
    }

    public DbSet<CarroModel> Carro { get; set; }
    public DbSet<MarcaModel> Marca { get; set; }
}
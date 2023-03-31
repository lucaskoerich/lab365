using Microsoft.EntityFrameworkCore;

namespace Exercicio_Api.Models;

public class SemanaContext : DbContext
{
    public SemanaContext(DbContextOptions<SemanaContext> options) : base(options)
    {
        
    }
    public DbSet<SemanaModel> Semana { get; set; }
}
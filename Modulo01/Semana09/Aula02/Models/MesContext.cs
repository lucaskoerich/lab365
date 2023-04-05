using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Aula02.DTO;

namespace Aula02.Models;

public class MesContext : DbContext

{
    public MesContext(DbContextOptions<MesContext> options) : base(options)
    {
        //todo: configurar migration
        //todo: executar comandos do migration
        //todo: cruid
    }
    
    public DbSet<MesModel> Mes { get; set; }
    public DbSet<SemanaModel> Semana { get; set; }
    public DbSet<Aula02.DTO.MesGetAllDTO> MesGetAllDTO { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     string connectionString = "Server=(localdb)\\.;database=TesteConString;";
    //     optionsBuilder.UseSqlServer(connectionString);
    //     base.OnConfiguring(optionsBuilder);
    // }
}
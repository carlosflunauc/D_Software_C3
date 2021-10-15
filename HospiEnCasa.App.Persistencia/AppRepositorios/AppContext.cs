using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;
namespace HospiEnCasa.App.Persistencia
{
  public class AppContext : DbContext
  {
    public DbSet<Persona> Personas{get; set;} 
    public DbSet<Paciente> Pacientes{get; set;}
    public DbSet<Medico> Medicos{get; set;} 
    public DbSet<Enfermera> Enfermeras{get; set;} 
    public DbSet<FamiliarDesignado> FamiliaresDesignados{get; set;} 
    public DbSet<SignoVital> SignosVitales{get; set;}
    public DbSet<Historia> Historias{get; set;} 
    public DbSet<SugerenciaCuidado> SugerenciasCuidado{get; set;}          
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("Server=tcp:hospiencasaapp.database.windows.net,1433;Initial Catalog=Hospicarlosluna2;Persist Security Info=False;User ID=Hospiencasa;Password=MisionTic2022;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
          //optionsBuilder.UseSqlServer("Initial Catalog=Hospicarlosluna; Data Source=HOMELUNA; Integrated Security=true");
            }
        }
    }
}
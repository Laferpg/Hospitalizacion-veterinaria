using Microsoft.EntityFrameworkCore;
using VetEnCasa.App.Dominio;

namespace VetEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Dueno> Duenos {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}
        public DbSet<VisitaDomi> VisitasDomi {get;set;}
        public DbSet<SugerenciaCuidado> SugerenciaCuidados {get;set;}
        public DbSet<MedicoVet> MedicosVet {get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {       
        if(!optionsBuilder.IsConfigured) 
            {
          optionsBuilder
          .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =VetEncasatData");
            }
        } 

    } 
}
using Microsoft.EntityFrameworkCore;
using education.Shared.Entities;
    
namespace education.API.Data

{

    public class DataContext : DbContext

    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)

        {

        }

        public DbSet<ProyectoEducativo> ProyectoEducativos { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<GrupoEstudiantes> GrupoEstudiantess { get; set; }
        public DbSet<ActividadEducativa> ActividadEducativas { get; set; }
        public DbSet<RecursoEducativo> RecursoEducativos { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<Evaluacion> Evaluacions { get; set; }
        public DbSet<AsignaciónDocentesAProyectosEducativos> AsignaciónDocentesAProyectosEducativoss { get; set; }  
        public DbSet<AsignaciónRecursosEducativosaActividadesEducativas> AsignaciónRecursosEducativosaActividadesEducativass { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProyectoEducativo>().HasIndex(c => c.Name).IsUnique();

        }

    }

}
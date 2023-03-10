using Microsoft.EntityFrameworkCore;
using.System.Linq;

namespace aspnetCoreCourse.Models
{
    public class EscuelaContext: DbContext
    {      

        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }        
        public DbSet<Alumno> Alumnos { get; set; }  
        public DbSet<Curso> Cursos { get; set; }        
        public DbSet<Evaluación> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela("Escuela Salgar",1980);      
            escuela.Ciudad = "Medellin";
            escuela.Pais = "Colombia";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            escuela.Direccion = "Av EverGreen";

            modelBuilder.Entity<Escuela>().HasData(escuela);

            modelBuilder.Entity<Asignatura>().HasData(
                new Asignatura {
                Nombre = "Matemáticas"
                },
                new Asignatura {
                Nombre = "Educación Física"
                },
                new Asignatura {
                Nombre = "Castellano"
                },
                new Asignatura {
                Nombre = "Ciencias Naturales"
                },
                new Asignatura {
                Nombre = "Programacion"
                }
            );

            modelBuilder.Entity<Alumno>()
                .HasData(GenerarAlumnosAlAzar().ToArray());

        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno { 
                                    Nombre = $"{n1} {n2} {a1}" ,
                                    };

            return listaAlumnos.OrderBy((al) => al.Nombre).ToList();
        }
    }
}

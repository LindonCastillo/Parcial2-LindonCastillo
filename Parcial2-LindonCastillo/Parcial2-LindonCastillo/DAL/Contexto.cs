using Parcial2_LindonCastillo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_LindonCastillo.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Asignaturas> Asignatura { get; set; }
        public DbSet<Estudiantes> Estudiante { get; set; }
        //public DbSet<Inscripcion> Inscripcion { get; set; }

        public Contexto() : base("Constr")
        { }
    }
}

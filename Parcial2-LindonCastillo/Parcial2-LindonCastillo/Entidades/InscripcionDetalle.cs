using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_LindonCastillo.Entidades
{
    public class InscripcionDetalle
    {
        [Key]
        public int Id { get; set; }
        public int InscripcionId { get; set; }
        public int EstudianteId { get; set; }
        public int AsignaturaId { get; set; }

        public InscripcionDetalle()
        {
            Id = 0;
            InscripcionId = 0;
            EstudianteId = 0;
            AsignaturaId = 0;
        }

        public InscripcionDetalle(int Id, int InscripcionId, int EstudianteId, int AsignaturaId)
        {
            this.Id = Id;
            this.InscripcionId = InscripcionId;
            this.EstudianteId = EstudianteId;
            this.AsignaturaId = AsignaturaId;
        }
    }
}

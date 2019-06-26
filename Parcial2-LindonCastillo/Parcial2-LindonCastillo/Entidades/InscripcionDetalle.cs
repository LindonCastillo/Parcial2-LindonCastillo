using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public InscripcionDetalle()
        {
            Id = 0;
            InscripcionId = 0;
            EstudianteId = 0;

        }
    }
}

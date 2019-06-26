using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_LindonCastillo.Entidades
{
    public class Inscripcion
    {
        [Key]
        public int InscripcionId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public virtual List<InscripcionDetalle> Detalle { get; set; }

        public Inscripcion()
        {
            InscripcionId = 0;
            Fecha = DateTime.Now;
            Monto = 0;

            Detalle = new List<InscripcionDetalle>();
        }
    }
}

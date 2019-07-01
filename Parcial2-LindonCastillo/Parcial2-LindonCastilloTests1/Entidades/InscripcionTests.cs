using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial2_LindonCastillo.BLL;
using Parcial2_LindonCastillo.DAL;
using Parcial2_LindonCastillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_LindonCastillo.Entidades.Tests
{
    [TestClass()]
    public class InscripcionTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Contexto db = new Contexto();
            Inscripcion inscripcion = new Inscripcion(); 
            inscripcion.InscripcionId = 0;
            inscripcion.Fecha = DateTime.Now;
            inscripcion.Monto = 0;

            inscripcion.Detalle.Add(new InscripcionDetalle()
            {
                Id = 0,
                InscripcionId = 1,
                EstudianteId = 1,
                AsignaturaId = 1,
                Subtotal = 1000
            }
            );

            Assert.IsTrue(InscripcionBLL.Guardar(inscripcion));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.InscripcionId = 2;
            inscripcion.Fecha = DateTime.Now;
            inscripcion.Monto = 0;

            inscripcion.Detalle.Add(new InscripcionDetalle()
            {
                Id = 0,
                InscripcionId = 1,
                EstudianteId = 1,
                AsignaturaId = 1,
                Subtotal = 1000
            }
            );

            Assert.IsTrue(InscripcionBLL.Modificar(inscripcion));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(InscripcionBLL.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(InscripcionBLL.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(InscripcionBLL.Eliminar(1));
        }
    }
}
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
    public class AsignaturasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Asignaturas> test = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas = new Asignaturas();
            asignaturas.AsignaturaId = 0;
            asignaturas.Descripcion = "Calculo";
            asignaturas.Creditos = 3;
            Assert.IsTrue(test.Guardar(asignaturas));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas = new Asignaturas();
            asignaturas.AsignaturaId = 1;
            asignaturas.Descripcion = "Calculo II";
            asignaturas.Creditos = 5;

            Assert.IsTrue(db.Modificar(asignaturas));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
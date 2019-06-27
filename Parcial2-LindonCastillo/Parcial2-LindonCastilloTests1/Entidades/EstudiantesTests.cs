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
    public class EstudiantesTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Estudiantes> test = new RepositorioBase<Estudiantes>();
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.EstudianteId = 0;
            estudiantes.FechaIngreso = DateTime.Now;
            estudiantes.Nombre = "Paco";
            estudiantes.Balance = 2000;
            Assert.IsTrue(test.Guardar(estudiantes));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            Estudiantes estudiantes = new Estudiantes();
            estudiantes.EstudianteId = 1;
            estudiantes.FechaIngreso = DateTime.Now;
            estudiantes.Nombre = "Paco";
            estudiantes.Balance = 3500;
            Assert.IsTrue(db.Modificar(estudiantes));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
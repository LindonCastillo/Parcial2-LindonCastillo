using Parcial2_LindonCastillo.DAL;
using Parcial2_LindonCastillo.Entidades;
using Parcial2_LindonCastillo.UI.Registros;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_LindonCastillo.BLL
{
    public class InscripcionBLL
    {
        public static bool Guardar(Inscripcion inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Inscripcion i = new Inscripcion();
            rInscripcion ri = new rInscripcion();
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            //decimal calculo = 0;
            try
            {
                if (db.Inscripcion.Add(inscripcion) != null)
                {
                    foreach (var item in i.Detalle)
                    {
                        var estudiante = db.Estudiante.Find(item.EstudianteId);
                        estudiante.Balance = ri.CalculoMonto();
                        repositorio.Modificar(estudiante);
                    }
                    paso = db.SaveChanges() > 0;
                }
                    
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        } 

        public static bool Modificar(Inscripcion inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var anterior = Buscar(inscripcion.InscripcionId);
                foreach (var item in anterior.Detalle)
                {
                    if (!inscripcion.Detalle.Exists(d => d.Id == item.Id))
                        db.Entry(item).State = EntityState.Deleted;
                }

                db.Entry(inscripcion).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Inscripcion.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }


        public static Inscripcion Buscar(int id)
        {
            Contexto db = new Contexto();
            Inscripcion inscripcion = new Inscripcion();

            try
            {
                inscripcion = db.Inscripcion.Find(id);
                inscripcion.Detalle.Count();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return inscripcion;
        }

        public static List<Inscripcion> GetList(Expression<Func<Inscripcion, bool>> inscripcion) 
        {
            List<Inscripcion> lista = new List<Inscripcion>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Inscripcion.Where(inscripcion).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return lista;
        }

    }
}

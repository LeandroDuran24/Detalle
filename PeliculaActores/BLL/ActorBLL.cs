using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PeliculaActores.DAL;
using PeliculaActores.Entidades;

namespace PeliculaActores.BLL
{
    public  class ActorBLL
    {
        public static bool Guardar(Actores nuevo)
        {
            bool retorno = false;
            using (var conn = new DetalleDb())
            {
                try
                {
                    conn.a.Add(nuevo);
                    /*foreach (var rep in nuevo.pelicula)
                    {
                        conn.Entry(rep).State = System.Data.Entity.EntityState.Unchanged;
                    }*/
             

                    conn.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }
        }

        public static Actores Buscar(int Id)
        {
            var guarda = new Actores();
            using (var conn = new DetalleDb())
            {
                try
                {
                    guarda = conn.a.Find(Id);

                }
                catch (Exception)
                {

                    throw;
                }
                return guarda;
            }
        }

        public static bool Eliminar(Actores usuario)
        {
            bool retorno = false;
            using (var conn = new DetalleDb())
            {
                try
                {
                    conn.Entry(usuario).State = System.Data.Entity.EntityState.Deleted;
                    conn.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }
        }

        public static List<Actores> GetList()
        {
            List<Actores> lista = new List<Actores>();
            using (var conn = new DetalleDb())
            {
                try
                {
                    lista = conn.a.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }
    }
}

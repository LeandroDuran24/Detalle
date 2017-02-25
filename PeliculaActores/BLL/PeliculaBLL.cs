using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PeliculaActores.DAL;
using PeliculaActores.Entidades;

namespace PeliculaActores.BLL
{
   public  class PeliculaBLL
    {
        public static bool Guardar(Peliculas nuevo)
        {
            
            using (var guar = new DetalleDb())
            {
                try
                {
                   
                    foreach (var rep in nuevo.actor)
                    {
                        guar.Entry(rep).State = System.Data.Entity.EntityState.Unchanged;
                    }
                    guar.p.Add(nuevo);
                    guar.SaveChanges();
                    return true;
                 
                }
                catch (Exception)
                {

                    throw;
                }
                return false;
              
            }
        }

        public static Peliculas Buscar(int Id)
        {
            var guarda = new Peliculas();
            using (var conn = new DetalleDb())
            {
                try
                {
                    guarda = conn.p.Find(Id);
                    guarda.actor.Count();
                }
                catch (Exception)
                {

                    throw;
                }
                return guarda;
            }
        }

        public static bool Eliminar(Peliculas usuario)
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

        public static List<Peliculas> GetList()
        {
            List<Peliculas> lista = new List<Peliculas>();
            using (var conn = new DetalleDb())
            {
                try
                {
                    lista = conn.p.ToList();
                }
                catch (Exception)
                {

                  
                }
                return lista;
            }
        }

        public static List<Peliculas> GetListFecha(DateTime desde, DateTime hasta)
        {
            List<Peliculas> lista = new List<Peliculas>();
            using (var conn = new DetalleDb())
            {
                try
                {
                    lista = conn.p.Where(p => p.Fecha >= desde.Date && p.Fecha <= hasta.Date).ToList();
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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PeliculaActores.Entidades
{
    public  class Actores
    {
        [Key]
        public int ActorId { get; set; }
        public string Nombre { get; set; }

        public virtual List<Peliculas>pelicula { get; set; }

        public Actores()
        {
            pelicula = new List<Peliculas>();
        }
    }
}

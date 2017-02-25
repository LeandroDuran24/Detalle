using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PeliculaActores.Entidades
{
    public class Peliculas
    {
        [Key]
        public int PeliculaId { get; set; }
        public string Nombre { get; set; }
        public string Actores { get; set; }
        public DateTime Fecha { get; set; }
        public int ActorId { get; set; }

        public virtual List<Actores> actor { get; set; }
        public Peliculas()
        {
            this.actor = new List<Entidades.Actores>();
        }


    }
}

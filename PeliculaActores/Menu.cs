using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PeliculaActores.UI.Consultas;
using PeliculaActores.UI.Registro;

namespace PeliculaActores
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }



        private void actorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActorFomr a = new ActorFomr();
            a.Show();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeliculaForm P = new PeliculaForm();
            P.Show();
        }

        private void actorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CActor ca = new CActor();
            ca.Show();
        }

        private void peliculaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CPelicula cp = new CPelicula();
            cp.Show();
        }
    }
}

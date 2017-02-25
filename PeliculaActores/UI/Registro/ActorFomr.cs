using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PeliculaActores.Entidades;

namespace PeliculaActores.UI.Registro
{
    public partial class ActorFomr : Form
    {
        public ActorFomr()
        {
            InitializeComponent();
        }

        private void ActorFomr_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            nombreTextBox.Clear();
            actorIdTextBox.Clear();
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "Favor llenar");
                return false;
            }
            return true;
        }


        private void Guardarbutton3_Click_1(object sender, EventArgs e)
        {
            var conn = new Actores();
            if (!Validar())
            {
                MessageBox.Show("No se ha podido guardar");

            }
            else
            {
                conn.Nombre = nombreTextBox.Text;
                conn.ActorId = Utilitarios.TOINT(actorIdTextBox.Text);
                if (BLL.ActorBLL.Guardar(conn))
                {


                    MessageBox.Show("Se ha guardado");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar");
                }
            }
            Limpiar();
        }

        private void Buscarbutton1_Click_1(object sender, EventArgs e)
        {

            var conn = BLL.ActorBLL.Buscar(Convert.ToInt32(actorIdTextBox.Text));

            if (conn != null)
            {
                nombreTextBox.Text = conn.Nombre;
                MessageBox.Show("Correcto");

            }
            else
            {
                MessageBox.Show("No existe ese Usuario");
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton4_Click(object sender, EventArgs e)
        {
            var conn = BLL.ActorBLL.Buscar(Convert.ToInt32(actorIdTextBox.Text));

            if (conn != null)
            {
                BLL.ActorBLL.Eliminar(conn);
                MessageBox.Show("Correcto");

            }
            else
            {
                MessageBox.Show("No existe ese Usuario");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PeliculaActores.DAL;
using PeliculaActores.Entidades;

namespace PeliculaActores.UI.Registro
{
    public partial class PeliculaForm : Form
    {
        Peliculas pelicula;
        public PeliculaForm()
        {
            InitializeComponent();
            Limpiar();
        }

        private void PeliculaForm_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        public void Limpiar()
        {
            nombreTextBox.Clear();
            peliculaIdTextBox.Clear();
            fechaDateTimePicker.Value = DateTime.Today;
            dataGridView1.DataSource = null;
            errorProvider1.Clear();

            pelicula = new Peliculas();
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

        public Peliculas LLenarCampos()
        {


            pelicula.Nombre = nombreTextBox.Text;
            pelicula.PeliculaId = Utilitarios.TOINT(peliculaIdTextBox.Text);
            pelicula.Fecha = fechaDateTimePicker.Value;
            pelicula.Actores = actoresComboBox.Text;
            pelicula.ActorId = Utilitarios.TOINT(actoresComboBox.SelectedValue.ToString());

            return pelicula;
        }

        public void LlenarCombo()
        {
            var llenar = new DetalleDb();
            List<Actores> lista = BLL.ActorBLL.GetList();
            actoresComboBox.DataSource = lista;
            actoresComboBox.DisplayMember = "Nombre";
            actoresComboBox.ValueMember = "ActorId";

        }

        public void LLenarData(Peliculas pelicula)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pelicula.actor;

        }

        private void Nuevobutton2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {

            Actores actor = new Actores();
            actor = (Actores)actoresComboBox.SelectedItem;
            pelicula.actor.Add(actor);

            LLenarData(pelicula);
        }

        private void Buscarbutton1_Click(object sender, EventArgs e)
        {
            pelicula = BLL.PeliculaBLL.Buscar(Convert.ToInt32(peliculaIdTextBox.Text));

            if (pelicula != null)
            {
                nombreTextBox.Text = pelicula.Nombre;
                fechaDateTimePicker.Value = pelicula.Fecha;
                actoresComboBox.SelectedValue = pelicula.actor;
                LLenarData(pelicula);
                MessageBox.Show("Correcto");
            }
            else
            {
                MessageBox.Show("No existe ese Usuario");
            }

        }

        private void Guadarbutton3_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("No se ha Podido guardar");
            }
            else
            {
                pelicula = LLenarCampos();

                if (BLL.PeliculaBLL.Guardar(pelicula))
                {

                    MessageBox.Show("Se ha guardado");
                }
                else
                {
                    MessageBox.Show("No se ha guardado");
                }
            }
            Limpiar();
        }

        private void Eliminarbutton4_Click(object sender, EventArgs e)
        {

            pelicula = BLL.PeliculaBLL.Buscar(Convert.ToInt32(peliculaIdTextBox.Text));

            if (pelicula != null)
            {
                BLL.PeliculaBLL.Eliminar(pelicula);
                MessageBox.Show("Se ha eliminado");
            }
            else
            {
                MessageBox.Show("No se ha Podido eliminar");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PeliculaActores.UI.Consultas
{
    public partial class CPelicula : Form
    {
        public CPelicula()
        {
            InitializeComponent();
            LlenarCombo();
        }

        private void CPelicula_Load(object sender, EventArgs e)
        {

        }

        public void LlenarCombo()
        {
            comboBox1.Items.Insert(0, "Todos");
            comboBox1.Items.Insert(1, "Fecha");
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Todos";
        }

        public void seleccionar()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = BLL.PeliculaBLL.GetList();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (desdedateTimePicker1.Value.Date < hastadateTimePicker2.Value.Date)
                {
                    dataGridView1.DataSource = BLL.PeliculaBLL.GetListFecha(desdedateTimePicker1.Value.Date, hastadateTimePicker2.Value.Date);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seleccionar();
        }
    }
}

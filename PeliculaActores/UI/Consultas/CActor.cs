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
    public partial class CActor : Form
    {
        public CActor()
        {
            InitializeComponent();
           
        }

        private void CActor_Load(object sender, EventArgs e)
        {

        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.ActorBLL.GetList();
        }
    }
}

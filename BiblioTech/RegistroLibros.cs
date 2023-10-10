using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech
{
    public partial class RegistroLibros : Form
       
    {
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();

        public RegistroLibros()
        {
            InitializeComponent();
        }

        private void txtCodigoRL_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodigoRL_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreRL_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombreRL_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAutorRL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoriaRL_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidadesRL_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroLibros_Load(object sender, EventArgs e)
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            grdBiblioDatos.DataSource = miDs.Tables["DataLibros"].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}

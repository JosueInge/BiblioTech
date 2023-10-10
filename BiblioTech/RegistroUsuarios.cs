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
    public partial class RegistroUsuarios : Form
    {
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        public int posicion = 0;
        String accion = "nuevo";
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            mostrarDatos();
            
        }
        private void mostrarDatos()
        {
            grdUserData.DataSource = miDs.Tables["UserData"].DefaultView;
        }
    }
}

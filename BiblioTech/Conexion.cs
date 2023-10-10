using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BiblioTech
{
    class Conexion
    {

        SqlConnection miConexion = new SqlConnection();
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet miDs = new DataSet();

        public Conexion()
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BiblioData.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
        }

        public DataSet obtenerDatos()
        {
            miDs.Clear();
            miComando.Connection = miConexion;

            miComando.CommandText = "select * from DataLibros";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "DataLibros");

            miComando.CommandText = "select * from UserData";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "UserData");

            return miDs;
        }

        
        public String mantenimientoLibros(String[] DataLibros) //Interfaz de registro de Libros
        {
            String sql = "";
            if (DataLibros[0] == "nuevo")
            {
                sql = "INSERT INTO DataLibros (Codigo, Nombre, Autor, Categoria) VALUES('" + DataLibros[1] + "'+'" + DataLibros[2] + "','" + DataLibros[3] + "','" + DataLibros[4] + "')";
            }
            else if (DataLibros[0] == "modificar")
            {
                sql = "UPDATE DataLibros SET Codigo= '" + DataLibros[1] + "', DataLibros'" + DataLibros[2] + "', Codigo'" + DataLibros[3] + "'WHERE idLibros'" + DataLibros[4] + "'";
            }
            else if (DataLibros[0] == "eliminar")
            {
                sql = "DELETE FROM materias WHERE idLibros='" + DataLibros[4] + "'";
            }
            return ejecutarSql(sql);
        }

        private string ejecutarSql(String sql)
        {
            try
            {
                miComando.CommandText = sql;
                miComando.Connection = miConexion;
                return miComando.ExecuteNonQuery().ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }

}
        

    


using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abarrotesCRUD.Clases
{
    internal class CConexion
    {
        MySqlCommand comando;
        MySqlDataReader dr;
        MySqlConnection conex = new MySqlConnection("Server=127.0.0.1;Database=abarrotes_ruben;Uid=root;Pwd=;");

        string cadenaConexionreub = "Server=localhost;Database=abarrotes_ruben;Uid=root;Pwd=;";

        public MySqlConnection establecerConexion() 
        {
            try
            {
                conex.Open();
                MessageBox.Show("Se conectó a la base de datos correctamente.");
            }
            catch 
            {
                MessageBox.Show("No se conectó a la base de datos. ERROR");
            }
            return conex;
        }
        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}

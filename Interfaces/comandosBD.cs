using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;

using System.Windows.Forms;

namespace Interfaces
{
    class comandosBD
    {
        static string strConexion = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = DBCEAT.mdb";

        static private OleDbConnection conexion;
        static private OleDbCommand comando;

        //Metodo para crear la cadena de conexion
        private void conectar(string consulta)
        {
            //Instancio una nueva conexion
            conexion = new OleDbConnection(strConexion);


            //Instancio un nuevo comando usando la conexion y la consulta ingresada al metodo
            comando = new OleDbCommand(consulta, conexion);
        }


        //Este es el metodo para recuperar datos mediante una consulta
        public OleDbDataReader consulta(string codigoConsulta)
        {
            conectar(codigoConsulta);

            try
            {
                conexion.Open();

                return comando.ExecuteReader();
            }
            catch
            {

                OleDbDataReader error = null;
                return error;
                //En caso de tener algun problema en la conexion, se devuelve un valor nulo
            }
        }

        //Este es el metodo para cerrar la conexion
        public void desconectar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        //Metodo para ejecutar comandos en la base de datos
        public bool ABM(string consulta)
        {
            bool Resultado = false;

            conectar(consulta);

            try
            {
               conexion.Open();

                comando.ExecuteNonQuery();

                Resultado = true;
            }
            catch(Exception a)
            {
                MessageBox.Show(a.ToString());
                MessageBox.Show("La consulta " + consulta + " no funcionó");
                Resultado = false;
            }

            desconectar();

            return Resultado;
        }


        public bool IniciarSesion(string nombreUsuario, string password)
        {
            //Instancio una nueva conexion
            conexion = new OleDbConnection(strConexion);
            conexion.Open();
            using (var comando = new OleDbCommand())
            {
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@contrasena", password);

                comando.Connection = conexion;

                comando.CommandText = "SELECT * FROM Usuario WHERE nombreUsuario=@nombreUsuario AND password=@contrasena";
                comando.CommandType = CommandType.Text;
                OleDbDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    lector.Close();
                    conexion.Close();
                    comando.Parameters.Clear();
                    comando.Connection.Close();

                    return true;
                }
                else
                {
                    lector.Close();
                    conexion.Close();
                    comando.Connection.Close();

                    return false;
                }


            }

        }







    }
}

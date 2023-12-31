﻿using System;
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
            bool resultado = true;

            //Instancio una nueva conexion
            conexion = new OleDbConnection(strConexion);
            conexion.Open();
            using (var comando = new OleDbCommand())
            {
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@contrasena", password);

                comando.Connection = conexion;

                comando.CommandText = "SELECT * FROM Usuario inner join Docente on Usuario.idDocente = Docente.idDocente " +
                "WHERE Usuario.nombreUsuario=@nombreUsuario AND Usuario.cont=@contrasena AND Docente.activo = -1";
                comando.CommandType = CommandType.Text;
                OleDbDataReader lector = comando.ExecuteReader();

                resultado = lector.HasRows;

                if (resultado)
                {
                    DataTable usuarioIniciado = new DataTable();

                    usuarioIniciado.Load(lector);

                    variables.perfil = (bool)usuarioIniciado.Rows[0][4];
                }

                lector.Close();
                conexion.Close();
                comando.Parameters.Clear();
                comando.Connection.Close();

                return resultado;
            }
        }

           /*comprobar campo igual,
         nuevo.*/
        public bool comprobarpkigual(string pk, string tabla, string campo)
        {
            string comandos = "select * from " + tabla;
            //conectarce = new OleDbConnection(coneccion);
            //orden = new OleDbCommand(comando, conectarce);
            //conectarce.Open();
            conectar(comandos);
            conexion.Open();
            OleDbDataReader lector;
            lector = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(lector);
            bool seguir = true;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][campo].ToString() == pk)
                {
                    seguir = false;
                    break;
                }
                seguir = true;
            }
            /*true = no hay registro igual.*/
            desconectar();
            return seguir;
        }

        public bool comprobarcampoigualmodificacion(string pkingresado, string tabla, string campo, string pkactual)
        {
            string comandos = "select * from " + tabla;
            //conectarce = new OleDbConnection(coneccion);
            //orden = new OleDbCommand(comando, conectarce);
            //conectarce.Open();
            conectar(comandos);
            conexion.Open();
            OleDbDataReader lector;
            lector = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(lector);
            bool seguir = true;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][campo].ToString() == pkingresado && pkactual != dt.Rows[i][campo].ToString())
                {
                    seguir = false;
                    break;
                }
                seguir = true;
            }
            /*true = no hay registro igual.*/
            desconectar();
            return seguir;
        }

        /*obtener id de una tabla usando una condicion, esto es mas que nada
         para responsable.*/
        public string obtener_id_tabla(string consultas,string columna)
        {
            conectar(consultas);
            conexion.Open();
            OleDbDataReader leer;
            leer = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(leer);
            string id = dt.Rows[0][columna].ToString();
            desconectar();
            return id;
        }

        
   }
}

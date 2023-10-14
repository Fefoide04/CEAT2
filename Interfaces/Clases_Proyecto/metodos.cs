using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Windows.Forms;

namespace Interfaces
{
    class metodos
    {
        public static void cambiarFormulario(Form formulario, Panel pan)
        {
            pan.Controls.Clear();

            formulario.TopLevel = false;

            pan.Controls.Add(formulario);

            formulario.Show();
        }

        public static Form devolverFormularioPorCadena(string cadena)
        {
            Form form = new Form();

            switch (cadena)
            {
                case "reportes":
                    form = new frm_seleccionarTipoReporte();
                    break;
                case "estudiantes":
                    form = new frm_visualizacionEstudiantes();
                    break;
                case "altaEstudiantes":
                    form = new frm_altaEstudiantes();
                    break;
                case "perfilEstudiante":
                    form = new frm_perfilEstudiante();
                    break;
                case "relevamientoAnual":
                    form = new frm_relevamientoRA();
                    break;
                case "reporteEspecifico":
                    form = new frm_relevamientoEspecifico();
                    break;
                case "administracionUsuarios":
                    form = new frm_administracionUsuarios();
                    break;
                case "altaUsuarios":
                    form = new frm_agregarUsuarios();
                    break;
                case "modificarUsuarios":
                    form = new frm_modificarUsuario();
                    break;
                case "listaUsuarios":
                    form = new frm_listaUsuarios();
                    break;
            }

            return form;
        }

        public static string CrearContraseña()
        {
            Random rdn = new Random();
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int longitud = caracteres.Length;
            char letra;
            int longitudContraseña = 6;
            variables.ContraseñaUsuario = string.Empty;
            for (int i = 0; i < longitudContraseña; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                variables.ContraseñaUsuario += letra.ToString();
            }
            return variables.ContraseñaUsuario;
        }

        /*validacion caracteres.*/
        public static void validar_textos(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
            }
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        /*validar numeros.*/
        public static void validar_numeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        /*prueba, sin uso.*/
        public static void validar_textos2(KeyPressEventArgs e, TextBox textb, int maximo)
        {
            textb.MaxLength = maximo;

            if (char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
            }
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        public static void cargarTabla(DataTable tabla, string consulta)
        {
            tabla.Clear();

            tabla.Load(variables.BD.consulta(consulta));

            variables.BD.desconectar();
        }
    }
}

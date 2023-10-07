using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int longitud = caracteres.Length;
            char letra;
            int longitudContraseña = 8;
            variables.ContraseñaUsuario = string.Empty;
            for (int i = 0; i < longitudContraseña; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                variables.ContraseñaUsuario += letra.ToString();
            }
            return variables.ContraseñaUsuario;
        }
    }
}

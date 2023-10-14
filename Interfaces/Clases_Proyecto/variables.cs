using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

using System.Data;

namespace Interfaces
{
    class variables
    {
        /*Generales*/

        public static comandosBD BD = new comandosBD();
        public static string ContraseñaUsuario;
        public static int control = 0;
        //public static string id;
        public static bool perfil = false;

        /*Formulario Principal*/
        public static Panel panelPrincipal;
        public static Button botonSeleccionado;

        public struct colores
        {
            public static Color primarySelectedColor = Color.FromArgb(255, 192, 128);
            public static Color primaryHighlightColor = Color.FromArgb(255, 238, 221);
            public static Color primaryBaseColor = Color.FromArgb(255, 224, 192);

            public static Color backgroundColor = Color.White;
        }

        /*Estudiantes*/

        public static DataTable estudiantes = new DataTable();
        public static string filtro = null;

        /*Usuarios*/

        public static DataTable tablaUsuarios = new DataTable();
        public static DataTable tablaDocentes = new DataTable();

        public static DataTable docenteSeleccionado = new DataTable();
        public static DataTable usuarioSeleccionado = new DataTable();

        public static int idUsuarioSeleccionado;

        public static DataTable docentesInactivos = new DataTable();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        /*verificar longitud cuil.,
         esto se usara para los docentes, alumnos y padres.*/
        public static bool cuils(string cuil1, string cuil2, string cuil3)
        {
            /*verdadero significa que el cuil esta completo.*/
            bool confirmar = true;
            /*si alguna de las variable no cumple con la longitud devuelvo false.*/
            if (cuil1.Length != 2 || cuil2.Length != 8 || cuil3.Length != 1)
            {
                confirmar = false;
            }

            return confirmar;
        }

        /*verificar longitud telefono,
         se utilizara para docente y alumnos.*/
        public static bool telefonos(string tel)
        {
            /*true significa que cumple con la cantidad de numeros.*/
            bool confirmar = true;

            if (tel.Length < 6)
            {
                confirmar = false;
            }

            return confirmar;
        }

        // verificar email.
        public static bool ComprobarFormatoEmail(string MailAComprobar)
        {
            String Formato;
            Formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(MailAComprobar, Formato))
            {
                if (Regex.Replace(MailAComprobar, Formato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /*verificar textos vacios y indices de combobox en groupbox.*/
        public static bool verificar_datos(GroupBox grp)
        {
            bool confirmar = true;
            /*se revisa cada control en este caso del groupbox.*/
            foreach (var c in grp.Controls)
            {
                /*solo compruebo los controles que sean textbox.*/
                if (c is TextBox)
                {
                    /*si en algun momento algun textbox esta vacion
                     retorno false y salgo del bucle.*/
                    if (((TextBox)c).Text == "")
                    {
                        confirmar = false;
                        break;
                    }
                }
                /*reviso tambien los combobox que tengan algun valor seleccionado.*/
                if (c is ComboBox)
                {
                    /*si no lo tienen devuelvo false.*/
                    if (((ComboBox)c).SelectedIndex == 0)
                    {
                        confirmar = false;
                        break;
                    }
                }
            }

            return confirmar;
        }

        /*cargar combobox con datos de bd.*/
        public static void dt_cmb(string comando,string displaynombre, string valueid,ComboBox cmbprincipal)
        {
            DataTable combobxdt = new DataTable();
            combobxdt.Load(variables.BD.consulta(comando));
            DataRow fila = combobxdt.NewRow();
            fila[1] = "Seleccine item";
            combobxdt.Rows.InsertAt(fila, 0);
            cmbprincipal.DataSource = combobxdt;
            cmbprincipal.DisplayMember = displaynombre;
            cmbprincipal.ValueMember = valueid;
        }

        /*para los combobox que no cargan desde base de datos.*/
        public static void seleccionar_indice0_cmb(GroupBox grp)
        {
            foreach (var c in grp.Controls)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                }
            }
        }



        // metodos para Alta Usuario Docente-----------------------------
        public static bool PerfilRol(string s)
        {
            if (s == "Director/a")
            {
                return true;
            }
            if (s == "Docente")
            {
                return false;
            }
            else
            {
                return false;
            }
        
        }

        public static bool AltaDocente(string nombre, string apellido, string cuil, string telefono)
        {
            comandosBD alta = new comandosBD();
            bool AltaD = false;
            AltaD = alta.ABM("INSERT INTO Docente (nombre, apellido, CUIL, telefono) VALUES ('" + nombre + "','" + apellido + "','" + cuil + "','" + telefono + "')");
            alta.desconectar();
            return AltaD;
        }

        public static bool AltaUsuario(string nombreUsuario, string cont, string id, bool perfil)
        {
            comandosBD alta = new comandosBD();
            bool AltaU = false;
            AltaU = alta.ABM("insert into Usuario (nombreUsuario, cont, idDocente, perfil) VALUES ('" + nombreUsuario + "', '" + cont + "', " + id + ", " + perfil + " )");
            alta.desconectar();
            return AltaU;
        }

        public static string TraeId(string cuil)
        {
            comandosBD alta = new comandosBD();
            variables.Tabla = new DataTable(); // instanciar para que siempre este limpia.
            variables.Tabla.Load(alta.consulta("Select idDocente from Docente where CUIL='" + cuil + "'"));
            variables.id = variables.Tabla.Rows[0]["idDocente"].ToString();
            alta.desconectar();
            return variables.id;
        }

        public static Object CargaTablaU()
        {
            comandosBD alta = new comandosBD();
            variables.Tabla = new DataTable();
            variables.Tabla.Load(alta.consulta("SELECT * FROM Usuario ORDER BY nombreUsuario"));
            alta.desconectar();
            return variables.Tabla;
        }
        //----------------------------------------------------------------
    }
}

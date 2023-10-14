using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class frm_modificarUsuario : Form
    {
        public frm_modificarUsuario()
        {
            InitializeComponent();
            // docente.
            txt_nombreDocente.MaxLength = 20;
            txt_apellidoDocente.MaxLength = 20;
            txt_cuilDocente1.MaxLength = 2;
            txt_cuilDocente2.MaxLength = 8;
            txt_cuilDocente3.MaxLength = 1;
            txt_telefonoDocente.MaxLength = 12;
            cmbEstado.SelectedIndex = 0;
        }

        private void frm_modificarUsuario_Load(object sender, EventArgs e)
        {
            refrescarFormulario();
        }

        private void dtg_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                btn_modificarUsuario.Enabled = true;

                /*Meti usuario y docente en data tables en vez de interactuar directamente con el dtg
                 * Es más ordenado, y nos deja mas libertad sobre que datos queremos mostrar en el dtg al no depender del formato del dtg para la lógica*/

                metodos.cargarTabla(variables.usuarioSeleccionado, "SELECT * from Usuario where idUsuario = " + dtg_usuarios[0, e.RowIndex].Value.ToString());

                metodos.cargarTabla(variables.docenteSeleccionado, "SELECT * from Docente inner join Usuario on Usuario.idDocente = Docente.idDocente WHERE Usuario.idUsuario = " + dtg_usuarios[0, e.RowIndex].Value.ToString());

                //Acá tambien se podria meter usuario y docente en una sola data table, usando fila 0 y 1 respectivamente, pero de momento lo hice así

                txt_nombreUsuario.Text = variables.usuarioSeleccionado.Rows[0][1].ToString();
                txt_contraseniaUsuario.Text = variables.usuarioSeleccionado.Rows[0][2].ToString();

                if (variables.usuarioSeleccionado.Rows[0][4].ToString() == "True")
                    cmb_permisoRol.SelectedIndex = 1;
                else
                    cmb_permisoRol.SelectedIndex = 0;

                if (variables.docenteSeleccionado.Rows[0][5].ToString() == "True")
                    cmbEstado.SelectedIndex = 1;
                else
                    cmbEstado.SelectedIndex = 0;


                txt_nombreDocente.Text = variables.docenteSeleccionado.Rows[0][1].ToString();
                txt_apellidoDocente.Text = variables.docenteSeleccionado.Rows[0][2].ToString();

                string[] cuilDividido = variables.docenteSeleccionado.Rows[0][3].ToString().Split('-');

                txt_cuilDocente1.Text = cuilDividido[0];
                txt_cuilDocente2.Text = cuilDividido[1];
                txt_cuilDocente3.Text = cuilDividido[2];

                txt_telefonoDocente.Text = variables.docenteSeleccionado.Rows[0][4].ToString();

                variables.idUsuarioSeleccionado = Convert.ToInt32(variables.usuarioSeleccionado.Rows[0][0]);
            }
        }

        private void refrescarFormulario()
        {
            txt_nombreDocente.Text = "";
            txt_apellidoDocente.Text = "";
            txt_cuilDocente1.Text = "" ;
            txt_cuilDocente2.Text = "";
            txt_cuilDocente3.Text = "";
            txt_telefonoDocente.Text = "";
            txt_nombreUsuario.Text = "";

            cmb_permisoRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

            btn_modificarUsuario.Enabled = false;

            //Acá cambie todo por data tables, para no tener controles que el usuario no va a ver y para ser ordenado
            metodos.cargarTabla(variables.tablaUsuarios, "SELECT * from Usuario");

            metodos.cargarTabla(variables.tablaDocentes, "SELECT * from Docente");

            metodos.cargarTabla(variables.docentesInactivos, "SELECT * from docente where activo = 0");

            /*Quitar esto*/

            dtg_usuarios.DataSource = variables.tablaUsuarios;

            dtgvDocentesInactivos.DataSource = variables.docentesInactivos;
        }

        private void btn_modificarUsuario_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string contra = "";

                if (txt_contraseniaUsuario.Text.Trim() == "")
                {
                    contra = metodos.CrearContraseña();
                }
                else
                {
                    contra = txt_contraseniaUsuario.Text;
                }

                if (variables.BD.ABM("UPDATE Docente SET nombre = '" + txt_nombreDocente.Text + "', apellido = '" + txt_apellidoDocente.Text
                + "', CUIL = '" + txt_cuilDocente1.Text + "-" + txt_cuilDocente2.Text + "-" + txt_cuilDocente3.Text + "', telefono = '" + txt_telefonoDocente.Text + "', activo = " + cmbEstado.SelectedIndex + " where idDocente = " + variables.docenteSeleccionado.Rows[0][0])
                && variables.BD.ABM("UPDATE Usuario SET nombreUsuario = '" + txt_nombreUsuario.Text + "', cont = '" + contra + "', perfil = " + cmb_permisoRol.SelectedIndex + " where idUsuario = " + variables.usuarioSeleccionado.Rows[0][0]))
                {
                    MessageBox.Show("Modificación realizada con éxito!");
                    refrescarFormulario();
                }
                else
                {
                    MessageBox.Show("ERROR: Ocurrió un error al actualizar la base de datos. Contacte a los desarrolladores para solicitar mantenimiento.");
                }
            }
        }

        private bool validar()
        {
            //Aca se podría validar, por ejemplo, que todos los campos se puedan convertir a su tipo correspondiente y etc

            bool validado = true;

            if (txt_nombreDocente.Text.Trim() == "" || txt_apellidoDocente.Text.Trim() == "" || txt_cuilDocente1.Text.Trim() == "" || txt_cuilDocente2.Text.Trim() == ""
                || txt_cuilDocente3.Text.Trim() == "" || txt_telefonoDocente.Text.Trim() == "" || txt_nombreUsuario.Text.Trim() == "")
            {
                validado = false;
            }

            return validado;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_regresar.Tag.ToString()), variables.panelPrincipal);
        }

        /*validar docente.*/
        private void txt_nombreDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_textos(e);
        }

        private void txt_apellidoDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_textos(e);
        }

        private void txt_cuilDocente1_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_numeros(e);
        }

        private void txt_cuilDocente2_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_numeros(e);
        }

        private void txt_cuilDocente3_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_numeros(e);
        }

        private void txt_telefonoDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_numeros(e);
        }

        /*validar usuario.*/
        private void txt_nombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsWhiteSpace(e.KeyChar)==true)
            {
                e.Handled = true;
            }
        }

        private void txt_contraseniaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

       



   


        

    }
}

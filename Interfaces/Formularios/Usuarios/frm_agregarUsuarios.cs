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
    public partial class frm_agregarUsuarios : Form
    {
        public frm_agregarUsuarios()
        {
            InitializeComponent();
            // docente.
            txt_nombreDocente.MaxLength = 12;
            txt_apellidoDocente.MaxLength = 12;
            txt_cuilDocente1.MaxLength = 2;
            txt_cuilDocente2.MaxLength = 8;
            txt_cuilDocente3.MaxLength = 1;
            txt_telefonoDocente.MaxLength = 12;
            // usuario.
            txt_nombreUsuario.MaxLength = 20;
            txt_contraseniaUsuario.MaxLength = 20;
            cmb_permisoRol.SelectedIndex = 0;
            
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_regresar.Tag.ToString()), variables.panelPrincipal);
        }

        private void btn_agregarUsuario_Click(object sender, EventArgs e)
        {
            if (txt_nombreDocente.Text == "" || txt_apellidoDocente.Text == "" || txt_cuilDocente1.Text == "" || txt_cuilDocente2.Text == "" || txt_cuilDocente3.Text == "" || txt_telefonoDocente.Text == "" || txt_nombreUsuario.Text == "")
            {
                MessageBox.Show("Faltan datos en los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                /*revisar cantidad de numeros en el telefono?.*/

                //Contolo que no exista un nombreUsuario repetido
                variables.control = 0;
                
                dtgvUsuarios.DataSource = metodos.CargaTablaU();
                

                for (int i = 0; i < dtgvUsuarios.Rows.Count; i++)
                {
                    if (txt_nombreUsuario.Text == dtgvUsuarios[1, i].Value.ToString())
                    {
                        variables.control = 1;
                        break;
                    }
                }

                if (variables.control == 1)
                {
                    MessageBox.Show("Ya existe el Usuario ingresado", "Usuario existente");
                    variables.control = 0;
                    txt_nombreUsuario.Select();
                }
                else
                {
                    // si está vacío el txt de la contraseña, la genera automáticamente
                    // mostrar y avisar sobre contraseña generada automaticamente (en progreso)
                    if (txt_contraseniaUsuario.Text == "")
                    {
                        txt_contraseniaUsuario.Text = metodos.CrearContraseña();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro que desea dar alta al usuario " + txt_nombreUsuario.Text + " perteneciente al docente " + txt_nombreDocente.Text + "?", "", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            string cuil = txt_cuilDocente1.Text + txt_cuilDocente2.Text + txt_cuilDocente3.Text;
                            bool AltaU = false;
                            bool AltaD = false;

                            AltaD = metodos.AltaDocente(txt_nombreDocente.Text, txt_apellidoDocente.Text, cuil, txt_telefonoDocente.Text);

                            variables.id = metodos.TraeId(cuil);
                            /*tabla limpia.*/
                                                       
                             variables.perfil = metodos.PerfilRol(cmb_permisoRol.Text);

                             AltaU = metodos.AltaUsuario(txt_nombreUsuario.Text, txt_contraseniaUsuario.Text, variables.id, variables.perfil);

                            if (AltaU == true && AltaD == true)
                            {
                                MessageBox.Show("Se creó correctamente el registro", "Proceso finalizado:");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo completar la operación", "Error en el procedimiento:");
                            }
                            // metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_agregarUsuario.Tag.ToString()), variables.panelPrincipal);
                        }
                    }
                }
            }
        }

        // validar docente.
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

        // validar usuario.
        private void txt_nombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
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

        private void frm_agregarUsuarios_Load(object sender, EventArgs e)
        {
            metodos.cargarTabla(variables.tablaUsuarios, "SELECT * from Usuario");
            dtgvUsuarios.DataSource = variables.tablaUsuarios;
        }

        private void gbox_docente_Enter(object sender, EventArgs e)
        {

        }
    }
}

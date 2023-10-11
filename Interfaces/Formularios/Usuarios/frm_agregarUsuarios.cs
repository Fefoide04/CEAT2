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
        }
        comandosBD alta = new comandosBD();

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_regresar.Tag.ToString()), variables.panelPrincipal);
        }

        private void btn_agregarUsuario_Click(object sender, EventArgs e)
        {
            //Contolo que no exista un nombreUsuario repetido
            variables.control = 0;             
            variables.Tabla.Load(alta.consulta("SELECT * FROM Usuarios ORDER BY nombreUsuario"));
            dtgvUsuarios.DataSource = variables.Tabla;
            alta.desconectar();

            for (int i = 0; i < dtgvUsuarios.RowCount; i++)
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
                if (txt_contraseniaUsuario.Text == "")
                {
                    txt_contraseniaUsuario.Text = metodos.CrearContraseña();
                }
                else
                {    
                    DialogResult result = MessageBox.Show("¿Está seguro que desea dar alta al usuario " + txt_nombreUsuario.Text + " perteneciente al docente " + txt_nombreDocente.Text + "?", "", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        string cuil = txt_cuilDocente1.Text + txt_cuilDocente2.Text + txt_cuilDocente3;
                        bool AltaU = false;
                        bool AltaD = false;
                        AltaD = alta.ABM("INSERT INTO Docente (nombre, apellido, CUIL, telefono) VALUES ('" + txt_nombreDocente + "','" + txt_apellidoDocente + "','" + cuil + "','" + txt_telefonoDocente + "')");
                        variables.id = alta.consulta("Select idDocente from Docente where CUIL='" + cuil + "'").ToString();
                        variables.idDocente = Convert.ToInt32(variables.id);
                        AltaU = alta.ABM("INSERT INTO Usuario (nombreUsuario, password, idDocente) VALUES ('" + txt_nombreUsuario.Text + "','" + txt_contraseniaUsuario.Text + "','" + variables.idDocente + ")");
                        
                        if (AltaU == true && AltaD == true)
                        {
                            MessageBox.Show("Se creó correctamente el registro", "Proceso finalizado:");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo completar la operación", "Error en el procedimiento:");
                        }
                        metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_agregarUsuario.Tag.ToString()), variables.panelPrincipal);
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
    }
}

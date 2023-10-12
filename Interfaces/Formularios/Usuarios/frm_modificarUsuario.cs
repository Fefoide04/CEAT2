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
        }
        comandosBD alta = new comandosBD();

        private void frm_modificarUsuario_Load(object sender, EventArgs e)
        {
            variables.Tabla = new DataTable();
            variables.Tabla.Load(alta.consulta("SELECT * FROM Usuario ORDER BY nombreUsuario"));
            dtg_usuarios.DataSource = variables.Tabla;
            variables.Tabla2 = new DataTable();
            variables.Tabla2.Load(alta.consulta("SELECT D.idDocente, D.nombre, D.apellido, D.CUIL, D.telefono, U.nombreUsuario FROM Docente D inner join Usuario U on D.idDocente=U.idDocente ORDER BY U.nombreUsuario"));
            dtgvDocente.DataSource = variables.Tabla2;
            alta.desconectar();
        }

        private void dtg_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombreUsuario.Text = dtg_usuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_contraseniaUsuario.Text = dtg_usuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            if ((dtg_usuarios.Rows[e.RowIndex].Cells[4].Value.ToString()) == "True") cmb_permisoRol.Text = "Director/a";
            if ((dtg_usuarios.Rows[e.RowIndex].Cells[4].Value.ToString()) == "False") cmb_permisoRol.Text = "Docente";
            txt_nombreDocente.Text = dtgvDocente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_apellidoDocente.Text = dtgvDocente.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_telefonoDocente.Text = dtgvDocente.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_cuilDocente3.Text = dtgvDocente.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(10, 1);
            txt_cuilDocente2.Text = dtgvDocente.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(2, 8);
            txt_cuilDocente1.Text = dtgvDocente.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(0, 2);
        }

        private void dtg_usuarios_DoubleClick(object sender, EventArgs e)
        {
            btn_cancelar.Visible = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_cancelar.Visible = false;
        }

        private void btn_modificarUsuario_Click(object sender, EventArgs e)
        {
            btn_cancelar.Visible = false;
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

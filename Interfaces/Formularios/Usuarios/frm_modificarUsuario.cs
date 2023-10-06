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
    }
}

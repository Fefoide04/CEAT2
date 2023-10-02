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
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_regresar.Tag.ToString()), variables.panelPrincipal);
        }

        private void btn_agregarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea dar alta al usuario " + txt_nombreUsuario.Text + " perteneciente al docente " + txt_nombreDocente.Text + "?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_agregarUsuario.Tag.ToString()), variables.panelPrincipal);
            }
        }
    }
}

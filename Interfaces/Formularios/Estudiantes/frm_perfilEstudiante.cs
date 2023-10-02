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
    public partial class frm_perfilEstudiante : Form
    {
        public frm_perfilEstudiante()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_regresar.Tag.ToString()), variables.panelPrincipal);
        }

        private void btn_modificarDatos_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_modificarDatos.Tag.ToString()), variables.panelPrincipal);
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea dar de baja al estudiante (Nombre de Estudiante). Esta acción no es permanente, se podra volver a dar de alta en cualquier momento.", "" , MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_baja.Tag.ToString()), variables.panelPrincipal);
            }
        }
    }
}

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
    public partial class frm_relevamientoRA : Form
    {
        public frm_relevamientoRA()
        {
            InitializeComponent();

            pnl_encabezadoRelevamientoRA.BackColor = variables.colores.primaryHighlightColor;

            btn_regresar.BackColor = variables.colores.primarySelectedColor;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_regresar.Tag.ToString()), variables.panelPrincipal);
        }
    }
}

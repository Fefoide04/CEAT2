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
    public partial class frm_seleccionarTipoReporte : Form
    {
        public frm_seleccionarTipoReporte()
        {
            InitializeComponent();

            btn_reporteGeneral.BackColor = variables.colores.primaryHighlightColor;
            btn_relevamientoEspecifico.BackColor = variables.colores.primaryBaseColor;
            btn_regresar.BackColor = variables.colores.primarySelectedColor;
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            string tag = boton.Tag.ToString();

            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(tag), variables.panelPrincipal);
        }
    }
}

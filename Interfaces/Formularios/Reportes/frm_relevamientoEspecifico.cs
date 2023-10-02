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
    public partial class frm_relevamientoEspecifico : Form
    {
        public frm_relevamientoEspecifico()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_regresar.Tag.ToString()),variables.panelPrincipal);
        }

        private void frm_relevamientoEspecifico_Load(object sender, EventArgs e)
        {

        }
    }
}

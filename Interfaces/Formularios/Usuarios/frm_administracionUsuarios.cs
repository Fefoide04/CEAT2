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
    public partial class frm_administracionUsuarios : Form
    {
        public frm_administracionUsuarios()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(boton.Tag.ToString()), variables.panelPrincipal);
        }
    }
}

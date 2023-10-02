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
    public partial class frm_visualizacionEstudiantes : Form
    {
        public frm_visualizacionEstudiantes()
        {
            InitializeComponent();

            //Aca deberíamos cargar en una data table la tabla estudiantes y usar un doble for para recorrerlo y cargar la grilla
        }

        private void btn_irConsultas_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_irConsultas.Tag.ToString()), variables.panelPrincipal);
        }

        private void btn_agregarEstudiantes_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_agregarEstudiantes.Tag.ToString()), variables.panelPrincipal);
        }

        private void dtg_vistaEstudiantes_DoubleClick(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(dtg_vistaEstudiantes.Tag.ToString()), variables.panelPrincipal);
        }
    }
}

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

            cargar_grilla();

            cmb_filtros.SelectedIndex = 0;
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

        private void frm_visualizacionEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void cmb_filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_filtros.SelectedIndex != -1)
            {
                switch (cmb_filtros.SelectedIndex)
                {
                    case 1:
                        variables.filtro = " Estudiante.nombre ";
                        break;
                    case 2:
                        variables.filtro = " Estudiante.apellido ";
                        break;
                    default:
                        variables.filtro = null;
                        buscar();
                        break;
                }
            }
        }

        //==================
        // metodo.

        public void buscar()
        {
            if (variables.filtro != null)
            {
                string comando = "select * from estudiante where" + variables.filtro + "like '" + txt_busqueda.Text + "%'";
                cargar_grilla(comando);
            }
            else
            {
                cargar_grilla();
            }
       }

        /*metodo para cargar grilla al realizar consultas.*/
        public void cargar_grilla(string comando = "select * from estudiante")
        {
            variables.estudiantes.Clear();
            variables.estudiantes.Load(variables.BD.consulta(comando));
            variables.BD.desconectar();

            dtg_vistaEstudiantes.DataSource = variables.estudiantes;
        }
        //============================

        private void txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buscar();
            }
        }
    }
}

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
            cmb_filtros.SelectedIndex = 0;
            //Aca deberíamos cargar en una data table la tabla estudiantes y usar un doble for para recorrerlo y cargar la grilla
            DataTable dt = new DataTable();
            dt.Load(conexionbd.consulta("select * from Estudiante"));
            dtg_vistaEstudiantes.DataSource = dt;
        }
        comandosBD conexionbd = new comandosBD();
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

        string tab_campo = "";
        private void cmb_filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*menor o igual a 2 es temporal.*/
            if (cmb_filtros.SelectedIndex >= 0 && cmb_filtros.SelectedIndex <= 2)
            {
                switch (cmb_filtros.SelectedIndex)
                {
                    case 0:
                        string comando = "select * from Estudiante";
                        cargar_grilla(comando);
                        break;
                    case 1:
                        tab_campo = " Estudiante.nombre ";
                        break;
                    case 2:
                        tab_campo = " Estudiante.apellido ";
                        break;
                }
            }
        }

        //==================
        // metodo.

        public void buscar()
        {
            if (cmb_filtros.SelectedIndex == 0)
            {
                txt_busqueda.Text = "";
                MessageBox.Show("Elija un filtro", "Filtros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string comando = "select * from estudiante where" + tab_campo + "like '" + txt_busqueda.Text + "%'";
                cargar_grilla(comando);
            }
        }

        /*metodo paracargar grilla al realizar consultas.*/
        public void cargar_grilla( string comando)
        {
            DataTable dt = new DataTable();
            dt.Load(conexionbd.consulta(comando));
            dtg_vistaEstudiantes.DataSource = dt;
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

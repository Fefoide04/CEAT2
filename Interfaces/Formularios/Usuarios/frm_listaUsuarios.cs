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
    public partial class frm_listaUsuarios : Form
    {
        public frm_listaUsuarios()
        {
            InitializeComponent();
            cmb_filtros.SelectedIndex = 0;
        }
        comandosBD conexionbd = new comandosBD();

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_regresar.Tag.ToString()), variables.panelPrincipal);
        }

        //==================
        // metodo.
        string tab_campo = "", tabla = "";
        public void buscar()
        {
            if (cmb_filtros.SelectedIndex == 0)
            {
                txt_busqueda.Text = "";
                MessageBox.Show("Elija un filtro", "Filtros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string comando = "select * from "+tabla+" where" + tab_campo + "like '" + txt_busqueda.Text + "%'";
                cargar_grilla(comando);
            }
        }

        /*metodo paracargar grilla al realizar consultas.*/
        public void cargar_grilla(string comando)
        {
            DataTable dt = new DataTable();
            dt.Load(conexionbd.consulta(comando));
            dtg_vistaDocentes.DataSource = dt;
        }
        private void frm_listaUsuarios_Load(object sender, EventArgs e)
        {
            cargar_grilla("select * from Usuario");
        }

        private void cmb_filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*menor o igual a 2.*/
            if (cmb_filtros.SelectedIndex >= 0 && cmb_filtros.SelectedIndex <= 2)
            {
                switch (cmb_filtros.SelectedIndex)
                {
                    case 0:
                        string comando = "select * from Estudiante";
                        cargar_grilla(comando);
                        break;
                    case 1:
                        tab_campo = " nombreUsuario ";
                        tabla = "Usuario";
                        break;
                    case 2:
                        tab_campo = " nombre ";
                        tabla = "Docente";
                        break;
                }
            }
        }

        private void txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buscar();
            }
        }
    }
}

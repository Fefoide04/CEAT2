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
            //string comando2 = "SELECT Estudiante.CUIL, Estudiante.nombre, Estudiante.apellido, Estudiante.genero, Estudiante.fechaNacimiento, Estudiante.direccion, Estudiante.altura, Estudiante.entreCalle1, Estudiante.entreCalle2, Caracterizacion.nombreCaracterizacion, Categoria.nombreCategoria, Turno.turno, Localidad.nombreLocalidad, Nacionalidad.nombrePaís "
            //                        + "FROM Turno INNER JOIN (Nacionalidad INNER JOIN (Localidad INNER JOIN (Categoria INNER JOIN (Caracterizacion INNER JOIN Estudiante ON Caracterizacion.idCaracterizacion = Estudiante.idCaracterizacion) ON Categoria.idCategoria = Estudiante.idCategoria) ON Localidad.idLocalidad = Estudiante.idLocalidad) ON Nacionalidad.idNacionalidad = Estudiante.idnacionalidad) ON Turno.idTurno = Estudiante.idturno;";
            //cargar_grilla(comando2);

            cmb_filtros.SelectedIndex = 0;
            btn_agregarEstudiantes.Visible = variables.perfil;
        }
        private void btn_irConsultas_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_irConsultas.Tag.ToString()), variables.panelPrincipal);
        }

        private void btn_agregarEstudiantes_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_agregarEstudiantes.Tag.ToString()), variables.panelPrincipal);
        }

        // metodo cambiado en celldoubleclick.
        private void dtg_vistaEstudiantes_DoubleClick(object sender, EventArgs e)
        {           
            //metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(dtg_vistaEstudiantes.Tag.ToString()), variables.panelPrincipal);
        }

        private void frm_visualizacionEstudiantes_Load(object sender, EventArgs e)
        {
            string comando2 = "SELECT Estudiante.CUIL, Estudiante.nombre, Estudiante.apellido, Estudiante.genero, Estudiante.fechaNacimiento, Estudiante.direccion, Estudiante.altura, Estudiante.entreCalle1, Estudiante.entreCalle2, Caracterizacion.nombreCaracterizacion, Categoria.nombreCategoria, Turno.turno, Localidad.nombreLocalidad, Nacionalidad.nombrePaís "
                                   + "FROM Turno INNER JOIN (Nacionalidad INNER JOIN (Localidad INNER JOIN (Categoria INNER JOIN (Caracterizacion INNER JOIN Estudiante ON Caracterizacion.idCaracterizacion = Estudiante.idCaracterizacion) ON Categoria.idCategoria = Estudiante.idCategoria) ON Localidad.idLocalidad = Estudiante.idLocalidad) ON Nacionalidad.idNacionalidad = Estudiante.idnacionalidad) ON Turno.idTurno = Estudiante.idturno;";
            cargar_grilla(comando2);
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
                    case 3:
                        variables.filtro = " Caracterizacion.nombreCaracterizacion ";
                        break;
                    case 4:
                        variables.filtro = " Categoria.nombreCategoria ";
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
                //string comando = "select * from estudiante where" + variables.filtro + "like '" + txt_busqueda.Text + "%'";
                string comando2 = "SELECT Estudiante.CUIL, Estudiante.nombre, Estudiante.apellido, Estudiante.genero, Estudiante.fechaNacimiento, Estudiante.direccion, Estudiante.altura, Estudiante.entreCalle1, Estudiante.entreCalle2, Caracterizacion.nombreCaracterizacion, Categoria.nombreCategoria, Turno.turno, Localidad.nombreLocalidad, Nacionalidad.nombrePaís "
                                    + "FROM Turno INNER JOIN (Nacionalidad INNER JOIN (Localidad INNER JOIN (Categoria INNER JOIN (Caracterizacion INNER JOIN Estudiante ON Caracterizacion.idCaracterizacion = Estudiante.idCaracterizacion) ON Categoria.idCategoria = Estudiante.idCategoria) ON Localidad.idLocalidad = Estudiante.idLocalidad) ON Nacionalidad.idNacionalidad = Estudiante.idnacionalidad) ON Turno.idTurno = Estudiante.idturno WHERE ((("+variables.filtro+") Like '"+txt_busqueda.Text+"%'));";
                cargar_grilla(comando2);
            }
            else
            {
                //cargar_grilla("select * from estudiante");
                cargar_grilla();
            }
       }

        /*metodo para cargar grilla al realizar consultas.*/
        public void cargar_grilla(string comando)
        {
            variables.estudiantes = new DataTable();
            variables.estudiantes.Clear();
            variables.estudiantes.Load(variables.BD.consulta(comando));
            variables.BD.desconectar();

            dtg_vistaEstudiantes.DataSource = variables.estudiantes;
        }

        public void cargar_grilla()
        {
            frm_visualizacionEstudiantes_Load(null, null);
        }
        //============================

        private void txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buscar();
            }
        }

        // celldobleclick me da el indice dl la fila.
        private void dtg_vistaEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("Elija un estudiante", "Estudiante");
            }
            else
            {
                metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(dtg_vistaEstudiantes.Tag.ToString()), variables.panelPrincipal);
                /*tomo los cuils del estudiante y del responsable.*/
                variables.id_estudiante = dtg_vistaEstudiantes.Rows[e.RowIndex].Cells["CUIL"].Value.ToString();
                string comandos = "select CUIL from Responsable where idResponsable = (select idResponsable from Estudiante where CUIL = '" + variables.id_estudiante + "')";
                DataTable dt = new DataTable();
                dt.Load(variables.BD.consulta(comandos));
                variables.id_responsable = dt.Rows[0]["CUIL"].ToString();
            }
        }
    }
}

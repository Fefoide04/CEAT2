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
            //cbox_categoriaFiltro.SelectedIndex = 0;
            cbox_caracterizacionFiltro.SelectedIndex = 0;
            cbox_sexoFiltro.SelectedIndex = 0;
            cbox_turnoFiltro.SelectedIndex = 0;
        }

        comandosBD claseConexion = new comandosBD();

        //========================
        // metodos.
        // cargar datos en combobox.

        //===========================
        // metodos.
        // todo esto de aqui abajo son los metodos para buscar las relaciones de dos tablas.
        /*cargo todos los comboboxs*/
        public void cargarencombobox()
        {
            for (int i = 0; i < 2; i++)
            {
                switch (i)
                {
                    case 0:
                        cargarcomboboxindividual("nombreCaracterizacion", cbox_caracterizacionFiltro, "elija caracterizacion", "", "Caracterizacion");
                        break;

                    case 1:
                        cargarcomboboxindividual("nombreCategoria", cbox_categoriaFiltro, "elija categoria", "", "Categoria");
                        break;
                }
            }
        }

        /*cargo los combobox de manera individual.*/
        public void cargarcomboboxindividual(string campo, ComboBox cmb, string mensaje, string distinto, string tabla)
        {
            DataTable dt = new DataTable();
            dt.Load(claseConexion.consulta("select " + distinto + campo + " from " + tabla));
            DataRow fila = dt.NewRow();
            fila[0] = mensaje;
            dt.Rows.InsertAt(fila, 0);
            cmb.DataSource = dt;
            cmb.DisplayMember = campo;
            cmb.SelectedIndex = 0;
            claseConexion.desconectar();
        }

        // filtro.

        /*guardo las condiciones en una lista, las de DNI, Nombre, Apellido, Edad, DNI_padre.*/
        public List<string> condicionselecy = new List<string>();

        /*guardo cada valor de los combobox en un array, los indices
          representa a cada uno de los campos 0 = categoria , 1 = sexo, 2 = caracterizacion, 3 = turno.*/
        public string[] guardarregistros = new string[4];

        /*cuento cuantos combobox usa el usuario para filtrar la informacion,
         esta variable sera usada luego para generar la condicion de la consulta.*/
        public int contadorcmb = 0;

        /*verifico,
         cada false le pertenece a un combobox en orden categoria, sexo, caracterizacion, turno.*/
        public bool[] seguircontador = { false, false, false, false };
        /*metodo para seleccionar las condiciones de los combobox.*/
        public void cmbseleccionarcondicion(int indices, ComboBox cmb, int indicer, string campo, string tabla)
        {
            int indice = cmb.SelectedIndex;
            /*compruebo si ya habia elegiodo un indice para no agregar o 
             descontar al contadorcmb.*/
            //bool contardescontar = false;

            if (indice != 0)
            {
                /*si el combobox estaba en su pocicion 0 sumo uno mas al contadorcmb*/
                if (seguircontador[indices] == false)
                {
                    contadorcmb++;
                    seguircontador[indices] = true;
                    /*le doy el comando de la condicion para la consulta.*/
                    condicionselecy.Add(" " + tabla + "." + campo + " = '" + cmb.Text + "'");

                    /*guardo el contenido del combobox actual para luego usarlo
                     en la lista para borrar el dato o cambiarlo.*/
                    guardarregistros[indicer] = "'" + cmb.Text + "'";
                }
                else
                {
                    /*si seguircontador ya no es true entonces reemplazo el valor que ya tenia
                     la lista que contenia el valor del DNI con uno nuevo,
                     y de esta manera el contador no incrementa.*/
                    condicionselecy[condicionselecy.IndexOf(" " + tabla + "." + campo + " = " + guardarregistros[indicer])] = " " + tabla + "." + campo + " = '" + cmb.Text + "'";
                    guardarregistros[indicer] = "'" + cmb.Text + "'";
                }

            }
            else
            {
                /*si elije el indice 0 entonces deshago la condicion para la consulta.*/
                //condicionselecy[0] = "";
                if (seguircontador[indices] == true)
                {
                    /*borro el contenido de la lista que contiene este comando en especifico.*/
                    condicionselecy.RemoveAt(condicionselecy.IndexOf(" " + tabla + "." + campo + " = " + guardarregistros[indicer]));
                    contadorcmb--;
                    seguircontador[indices] = false;
                }
            }
        }

        // realizar consulta.

        public void consulta_general()
        {
            //string prueba = cbox_categoriaFiltro.Items[cbox_categoriaFiltro.SelectedIndex].ToString();
            if (cbox_categoriaFiltro.SelectedIndex < 1 && cbox_sexoFiltro.SelectedIndex <1 && cbox_caracterizacionFiltro.SelectedIndex <1 && cbox_turnoFiltro.SelectedIndex <1)
            {
                //DataTable dt = new DataTable();
                //// hacer una consulta sin filtros.
                //MessageBox.Show("elija al menos un campo para hacer la consulta", "elejir campo", MessageBoxButtons.OK);
                //string comando = "select * from Estudiante inner join Categoria on Estudiante.idCategoria = Categoria.idCategoria inner join Caracterizacion on Caracterizacion.idCaracterizacion = Estudiante.idCaracterizacion inner join Turno on Turno.idTurno = Estudiante.idturno";
                //dt.Load(claseConexion.consulta(comando));
                //dtg_estudiantesFiltro.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                string comandoconsulta = "";

                /*si el contador es uno significa que solo eligio un dato de un combobox.*/
                if (contadorcmb == 1)
                {
                    comandoconsulta = condicionselecy[0];
                }
                else
                {
                    /*si hay mas de un combo box seleccionado entonces recorro la lista
                     con las condiciones guardadas.*/
                    for (int i = 0; i < contadorcmb; i++)
                    {
                        /*mientras sea diferente al ultimo numero del indice
                         de la lista imprimire and al final.*/
                        if (i != (contadorcmb - 1))
                        {
                            comandoconsulta += condicionselecy[i] + "and";
                        }
                        else
                        {
                            /*una vez llego al final de la lista ya no imprimo and.*/
                            comandoconsulta += condicionselecy[i];
                        }
                    }
                }

                /*modificar, en prueba aun.*/
                string comandorelacion = "select * from Estudiante inner join Categoria on Estudiante.idCategoria = Categoria.idCategoria inner join Caracterizacion on Caracterizacion.idCaracterizacion = Estudiante.idCaracterizacion inner join Turno on Turno.idTurno = Estudiante.idturno where " + comandoconsulta;
                string prueba = "select * from Estudiante, Turno, Categoria where Estudiante.idturno = Turno.idTurno and Estudiante.idCatgoria = Categoria.idCategoria";
                dt.Load(claseConexion.consulta("SELECT * " +
                                            "FROM (Turno INNER JOIN (TipoDeIngreso INNER JOIN (Parentezco INNER JOIN (((Nacionalidad INNER JOIN (Localidad INNER JOIN ((Docente INNER JOIN Ingreso ON Docente.idDocente = Ingreso.idDocente) INNER JOIN (Categoria INNER JOIN (Caracterizacion INNER JOIN Estudiante ON Caracterizacion.idCaracterizacion = Estudiante.idCaracterizacion) ON Categoria.idCategoria = Estudiante.idCategoria) ON Ingreso.idIngreso = Estudiante.idIngreso) ON Localidad.idLocalidad = Estudiante.idLocalidad) ON Nacionalidad.idNacionalidad = Estudiante.idnacionalidad) INNER JOIN Observacion ON (Estudiante.IdRegistro = Observacion.idEstudiante) AND (Docente.idDocente = Observacion.idDocente)) INNER JOIN Responsable ON (Responsable.idResponsable = Estudiante.idResponsable) AND (Nacionalidad.idNacionalidad = Responsable.idNacionalidad) AND (Localidad.idLocalidad = Responsable.idLocalidad)) ON Parentezco.idParentezco = Responsable.idParentezco) ON TipoDeIngreso.idTipo = Ingreso.idTipo) ON Turno.idTurno = Estudiante.idturno) INNER JOIN Usuario ON Docente.idDocente = Usuario.idDocente WHERE (((Caracterizacion.nombreCaracterizacion)='Discapacidad Auditiva') AND ((Estudiante.nombre)='masculino') AND ((Categoria.nombreCategoria)='lactante') AND ((Turno.turno)='mañana'));"));
                dtg_estudiantesFiltro.DataSource = dt;
            }
        }
        
        //=====================================

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_regresar.Tag.ToString()),variables.panelPrincipal);
        }

        private void frm_relevamientoEspecifico_Load(object sender, EventArgs e)
        {
            cargarencombobox();
            /*cargar la grilla, en proceso.*/
            DataTable dt = new DataTable();
            dt.Load(claseConexion.consulta("SELECT * "+
                                            "FROM (Turno INNER JOIN (TipoDeIngreso INNER JOIN (Parentezco INNER JOIN (((Nacionalidad INNER JOIN (Localidad INNER JOIN ((Docente INNER JOIN Ingreso ON Docente.idDocente = Ingreso.idDocente) INNER JOIN (Categoria INNER JOIN (Caracterizacion INNER JOIN Estudiante ON Caracterizacion.idCaracterizacion = Estudiante.idCaracterizacion) ON Categoria.idCategoria = Estudiante.idCategoria) ON Ingreso.idIngreso = Estudiante.idIngreso) ON Localidad.idLocalidad = Estudiante.idLocalidad) ON Nacionalidad.idNacionalidad = Estudiante.idnacionalidad) INNER JOIN Observacion ON (Estudiante.IdRegistro = Observacion.idEstudiante) AND (Docente.idDocente = Observacion.idDocente)) INNER JOIN Responsable ON (Responsable.idResponsable = Estudiante.idResponsable) AND (Nacionalidad.idNacionalidad = Responsable.idNacionalidad) AND (Localidad.idLocalidad = Responsable.idLocalidad)) ON Parentezco.idParentezco = Responsable.idParentezco) ON TipoDeIngreso.idTipo = Ingreso.idTipo) ON Turno.idTurno = Estudiante.idturno) INNER JOIN Usuario ON Docente.idDocente = Usuario.idDocente WHERE (((Caracterizacion.nombreCaracterizacion)= 'Discapacidad Auditiva') AND ((Estudiante.nombre)='masculino'));"));
        }

        private void cbox_categoriaFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbseleccionarcondicion(0, cbox_categoriaFiltro, 0, "nombreCategoria", "Categoria");
            consulta_general();
        }

        private void cbox_sexoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbseleccionarcondicion(1, cbox_sexoFiltro, 1, "genero", "Estudiante");
            consulta_general();
        }

        private void cbox_caracterizacionFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbseleccionarcondicion(2, cbox_caracterizacionFiltro, 2, "nombreCaracterizacion", "Caracterizacion");
            consulta_general();
        }

        private void cbox_turnoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbseleccionarcondicion(3, cbox_turnoFiltro, 3, "turno", "Turno");
            consulta_general();
        }
    }
}

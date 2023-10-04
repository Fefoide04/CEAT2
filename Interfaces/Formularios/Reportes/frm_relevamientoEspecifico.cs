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
            //cbox_caracterizacionFiltro.SelectedIndex = 0;
            cbox_sexoFiltro.SelectedIndex = 0;
            //cbox_turnoFiltro.SelectedIndex = 0;
        }

        comandosBD claseConexion = new comandosBD();

        //========================
        // metodos.
        // cargar datos en combobox.
        // todo esto de aqui abajo son los metodos para buscar las relaciones de dos tablas.
        /*cargo todos los comboboxs*/
        public void cargarencombobox()
        {
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        cargarcomboboxindividual("nombreCaracterizacion", cbox_caracterizacionFiltro, "elija caracterizacion", "", "Caracterizacion", "idCaracterizacion");
                        break;

                    case 1:
                        cargarcomboboxindividual("nombreCategoria", cbox_categoriaFiltro, "elija categoria", "", "Categoria", "idCategoria");
                        break;
                    case 2:
                        cargarcomboboxindividual("turno", cbox_turnoFiltro, "elija turno", "", "Turno", "idTurno");
                        break;
                }
            }
        }

        /*cargo los combobox de manera individual.*/
        public void cargarcomboboxindividual(string campo, ComboBox cmb, string mensaje, string distinto, string tabla, string campoid)
        {
            DataTable dt = new DataTable();
            dt.Load(claseConexion.consulta("select " + distinto + "*" + " from " + tabla));
            DataRow fila = dt.NewRow();
            fila[0] = 0;
            fila[1] = mensaje;
            dt.Rows.InsertAt(fila, 0);
            cmb.DataSource = dt;
            cmb.DisplayMember = campo;
            cmb.ValueMember = campoid;
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
        public void cmbseleccionarcondicion(int indices, ComboBox cmb, int indicer, string campo, string tabla, int sexo)
        {
            int indice = cmb.SelectedIndex;
            /*compruebo si ya habia elegiodo un indice para no agregar o 
             descontar al contadorcmb.*/
            //bool contardescontar = false;


            if (indice != 0)
            {
                string registro = "";
                /*si se escoge algun sexo tomo el valor texto del cobobox.*/
                if (sexo == 1)
                {
                    registro = "'" + cmb.Text + "'";
                }
                else
                {
                    /*de lo contrario tomo su valor numerico, que seria el id.*/
                    registro = cmb.SelectedValue.ToString();
                }


                /*si el combobox estaba en su pocicion 0 sumo uno mas al contadorcmb*/
                if (seguircontador[indices] == false)
                {
                    contadorcmb++;
                    seguircontador[indices] = true;

                    /*le doy el comando de la condicion para la consulta.*/
                    condicionselecy.Add("((" + tabla + "." + campo + ") = " + registro+")");

                    /*guardo el contenido del combobox actual para luego usarlo
                     en la lista para borrar el dato o cambiarlo.*/
                    guardarregistros[indicer] = registro;
                }
                else
                {
                    /*si seguircontador ya no es true entonces reemplazo el valor que ya tenia
                     la lista que contenia el valor del DNI con uno nuevo,
                     y de esta manera el contador no incrementa.*/
                    condicionselecy[condicionselecy.IndexOf("((" + tabla + "." + campo + ") = " + guardarregistros[indicer]+")")] = "((" + tabla + "." + campo + ") = " + registro+")";
                    guardarregistros[indicer] = registro;
                }

            }
            else
            {
                /*si elije el indice 0 entonces deshago la condicion para la consulta.*/
                //condicionselecy[0] = "";
                if (seguircontador[indices] == true)
                {
                    /*borro el contenido de la lista que contiene este comando en especifico.*/
                    condicionselecy.RemoveAt(condicionselecy.IndexOf("((" + tabla + "." + campo + ") = " + guardarregistros[indicer]+")"));
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
                DataTable dt = new DataTable();
                //// hacer una consulta sin filtros.
                /*si todos los combobox estan en el indice 0 entonces solo se hara una consulta general sin conteo,
                 establecer que campos se mostraran en las grillas.*/
                string comando = "SELECT Estudiante.idCaracterizacion" +
                                                " FROM Turno INNER JOIN (Categoria INNER JOIN (Caracterizacion INNER JOIN Estudiante ON Caracterizacion.idCaracterizacion = Estudiante.idCaracterizacion) ON Categoria.idCategoria = Estudiante.idCategoria) ON Turno.idTurno = Estudiante.idturno";
                                                
                dt.Load(claseConexion.consulta(comando));
                dtg_estudiantesFiltro.DataSource = dt;

                txt_conteoFiltro.Text = "";
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
                            comandoconsulta += condicionselecy[i] + " and ";
                        }
                        else
                        {
                            /*una vez llego al final de la lista ya no imprimo and.*/
                            comandoconsulta += condicionselecy[i];
                        }
                    }
                }

                /*modificar, en prueba aun.*/
                string comandorelacion = "SELECT Estudiante.idCaracterizacion, Estudiante.idCategoria, Estudiante.idturno, Estudiante.genero" +
                                                " FROM Turno INNER JOIN (Categoria INNER JOIN (Caracterizacion INNER JOIN Estudiante ON Caracterizacion.idCaracterizacion = Estudiante.idCaracterizacion) ON Categoria.idCategoria = Estudiante.idCategoria) ON Turno.idTurno = Estudiante.idturno" +
                                                " where (" + comandoconsulta+");";

               
                /*se mjuestra el resultado en la grilla.*/
                dt.Load(claseConexion.consulta(comandorelacion));
                dtg_estudiantesFiltro.DataSource = dt;

                /*se hace el conteo aqui, fue necesacio otra consulta,
                 determinar luego cual sera la tabla que se tomara como not null.*/
                string conteo = "SELECT count(*) as conteo" +
                                                " FROM Turno INNER JOIN (Categoria INNER JOIN (Caracterizacion INNER JOIN Estudiante ON Caracterizacion.idCaracterizacion = Estudiante.idCaracterizacion) ON Categoria.idCategoria = Estudiante.idCategoria) ON Turno.idTurno = Estudiante.idturno" +
                                                " where (" + comandoconsulta + ");";
                DataTable dt2 = new DataTable();
                dt2.Load(claseConexion.consulta(conteo));
                /*le doy e lvalor de la tabla conteo al textbox.*/
                txt_conteoFiltro.Text = dt2.Rows[0]["conteo"].ToString();
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
            dt.Load(claseConexion.consulta("SELECT Estudiante.idCaracterizacion, Estudiante.idCategoria, Estudiante.idturno, Estudiante.genero" +
                                                " FROM Turno INNER JOIN (Categoria INNER JOIN (Caracterizacion INNER JOIN Estudiante ON Caracterizacion.idCaracterizacion = Estudiante.idCaracterizacion) ON Categoria.idCategoria = Estudiante.idCategoria) ON Turno.idTurno = Estudiante.idturno;"));
            dtg_estudiantesFiltro.DataSource = dt;
        }

        private void cbox_categoriaFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbseleccionarcondicion(0, cbox_categoriaFiltro, 0, "idCategoria", "Estudiante", 0);
            consulta_general();
        }

        private void cbox_sexoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbseleccionarcondicion(1, cbox_sexoFiltro, 1, "genero", "Estudiante",1);
            consulta_general();
        }

        private void cbox_caracterizacionFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbseleccionarcondicion(2, cbox_caracterizacionFiltro, 2, "idCaracterizacion", "Estudiante", 0);
            consulta_general();
        }

        private void cbox_turnoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbseleccionarcondicion(3, cbox_turnoFiltro, 3, "idturno", "Estudiante", 0);
            consulta_general();
        }
    }
}

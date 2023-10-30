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
    public partial class frm_altaEstudiantes : Form
    {
        public frm_altaEstudiantes(int altmod)
        {
            InitializeComponent();
            alta_mod = altmod; // variable para alta o modificacion de estudiante.
            // responsables.
            txt_nombreResponsable.MaxLength = 12;
            txt_apellidoResponsable.MaxLength = 12;
            txt_cuilResponsable1.MaxLength = 2;
            txt_cuilResponsable2.MaxLength = 8;
            txt_cuilResponsable3.MaxLength = 1;
            txt_emailResponsable.MaxLength = 40;
            txt_direccionResponsable.MaxLength = 30;
            txt_telefonoResponsable.MaxLength = 14;
            // estudiantes.
            txt_cuilEstudiante1.MaxLength = 2;
            txt_cuilEstudiante2.MaxLength = 8;
            txt_cuilEstudiante3.MaxLength = 1;
            txt_direccionEstudiante.MaxLength = 30;
            txt_nombreEstudiante.MaxLength = 12;
            txt_apellidoEstudiante.MaxLength = 12;
            txt_entreCalle1Estudiante.MaxLength = 30;
            txt_entreCalle2Estudiante.MaxLength = 30;
            txt_altura.MaxLength = 8;

            /*nuevo*/
            /*combobox responsable.*/
            metodos.dt_cmb("select * from Categoria", "nombreCategoria", "idCategoria", cbox_categoriaEstudiante);
            metodos.dt_cmb("select * from Caracterizacion", "nombreCaracterizacion", "idCaracterizacion", cmb_caracterizacionEstudiante);
            metodos.dt_cmb("select * from Parentezco", "parentezco", "idParentezco", cbox_parentezcoResponsable);
            metodos.dt_cmb("select * from Localidad", "nombreLocalidad", "idLocalidad", cbox_localidadResponsable);
            metodos.dt_cmb("select * from Nacionalidad", "nombrePaís", "idNacionalidad", cbox_nacionalidadResponsable);

            /*combobox estudiantes.*/
            metodos.dt_cmb("select * from Localidad", "nombreLocalidad", "idLocalidad", cbox_localidadEstudiante);
            metodos.dt_cmb("select * from Nacionalidad", "nombrePaís", "idNacionalidad", cbox_nacionalidadEstudiante);
            metodos.dt_cmb("select * from Localidad", "nombreLocalidad", "idLocalidad", cbox_localidadResponsable);
            metodos.dt_cmb("select * from Categoria", "nombreCategoria", "idCategoria", cbox_categoriaEstudiante);
            metodos.dt_cmb("select * from Caracterizacion", "nombreCaracterizacion", "idCaracterizacion", cmb_caracterizacionEstudiante);
            metodos.dt_cmb("select * from Turno", "turno", "idTurno", cbox_turno);
            //===========================
            /*selecciono items de combobox que no cargan desde la base de datos.*/
            metodos.seleccionar_indice0_cmb(gbox_estudiante);
            metodos.seleccionar_indice0_cmb(gbox_responsable);
            agregar_anio();
            // se activara solo cuando sea para modificar.
            alt_mod();
        }

        //====================
        // metodo.
        private void alt_mod()
        {
            switch (alta_mod)
            {
                case 1:
                    // cargar objetos para responsable, terminado.
                    btn_agregar.Text = "Modificar";
                    DataTable dtres = new DataTable();
                    dtres.Load(variables.BD.consulta("select * from Responsable where CUIL = '"+variables.id_responsable+"'"));
                    txt_cuilResponsable1.Text = dtres.Rows[0]["CUIL"].ToString().Substring(0, 2);
                    txt_cuilResponsable2.Text = dtres.Rows[0]["CUIL"].ToString().Substring(2, 8);
                    txt_cuilResponsable3.Text = dtres.Rows[0]["CUIL"].ToString().Substring(9, 1);
                    txt_nombreResponsable.Text = dtres.Rows[0]["nombre"].ToString();
                    txt_apellidoResponsable.Text = dtres.Rows[0]["apellido"].ToString();
                    txt_emailResponsable.Text = dtres.Rows[0]["e_mail"].ToString();
                    txt_direccionResponsable.Text = dtres.Rows[0]["direccion"].ToString();
                    txt_telefonoResponsable.Text = dtres.Rows[0]["telefono"].ToString();

                    
                    cbox_localidadResponsable.SelectedIndex = seleccionar_cmb_mod(dtres.Rows[0]["idLocalidad"].ToString(), "Localidad", "idLocalidad");
                    cbox_nacionalidadResponsable.SelectedIndex = seleccionar_cmb_mod(dtres.Rows[0]["idNacionalidad"].ToString(), "Nacionalidad", "idNacionalidad");
                    cbox_parentezcoResponsable.SelectedIndex = seleccionar_cmb_mod(dtres.Rows[0]["idParentezco"].ToString(), "Parentezco", "idParentezco");

                    // alumnos.
                    dtres = new DataTable();
                    dtres.Load(variables.BD.consulta("select * from Estudiante where CUIL = '" + variables.id_estudiante + "'"));
                    txt_cuilEstudiante1.Text = dtres.Rows[0]["CUIL"].ToString().Substring(0, 2);
                    txt_cuilEstudiante2.Text = dtres.Rows[0]["CUIL"].ToString().Substring(2, 8);
                    txt_cuilEstudiante3.Text = dtres.Rows[0]["CUIL"].ToString().Substring(9, 1);
                    txt_nombreEstudiante.Text = dtres.Rows[0]["nombre"].ToString();
                    txt_apellidoEstudiante.Text = dtres.Rows[0]["apellido"].ToString();
                    txt_direccionEstudiante.Text = dtres.Rows[0]["direccion"].ToString();
                    txt_altura.Text = dtres.Rows[0]["altura"].ToString();
                    txt_entreCalle1Estudiante.Text = dtres.Rows[0]["entreCalle1"].ToString();
                    txt_entreCalle2Estudiante.Text = dtres.Rows[0]["entreCalle2"].ToString();

                    string[] fecha_num = dtres.Rows[0]["fechaNacimiento"].ToString().Split('/');
                    cbox_diaNacimientoEstudiante.SelectedIndex = seleccionar_indice_combobox(cbox_diaNacimientoEstudiante, fecha_num[0]);
                    cbox_mesNacimientoEstudiante.SelectedIndex = seleccionar_indice_combobox(cbox_mesNacimientoEstudiante, fecha_num[1]);
                    cbox_anioNacimientoEstudiante.SelectedIndex = seleccionar_indice_combobox(cbox_anioNacimientoEstudiante, fecha_num[2].Substring(0,4));
                    cbox_generoEstudiante.SelectedIndex = seleccionar_indice_combobox(cbox_generoEstudiante, dtres.Rows[0]["genero"].ToString());


                    cbox_localidadEstudiante.SelectedIndex = seleccionar_cmb_mod(dtres.Rows[0]["idLocalidad"].ToString(), "Localidad", "idLocalidad");
                    cbox_nacionalidadEstudiante.SelectedIndex = seleccionar_cmb_mod(dtres.Rows[0]["idNacionalidad"].ToString(), "Nacionalidad", "idNacionalidad");
                    cbox_turno.SelectedIndex = seleccionar_cmb_mod(dtres.Rows[0]["idTurno"].ToString(), "Turno", "idTurno");
                    cbox_categoriaEstudiante.SelectedIndex = seleccionar_cmb_mod(dtres.Rows[0]["idCategoria"].ToString(), "Categoria", "idCategoria");
                    cmb_caracterizacionEstudiante.SelectedIndex = seleccionar_cmb_mod(dtres.Rows[0]["idCaracterizacion"].ToString(), "Caracterizacion", "idCaracterizacion");
                    break;
            }
        }
        //==================
        // metodos.
        /*utilizo las id que hedero la tabla estudiante para buscar los
         indices a los que pertenecen en el combobox para poder visualizarlos en pnatalla.*/
        private int seleccionar_cmb_mod(string id, string tabla, string condicion)
        {
            //string resultado;
            DataTable dt = new DataTable();
            dt.Load(variables.BD.consulta("select * from "+tabla ));

            int contador = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (id == dt.Rows[i][condicion].ToString())
                {
                    contador = i + 1;
                    break;
                }
            }
            return contador;
        }

        /*utilizo los nombres de los campos de la tabla estudiante para buscar
         entre los items de los combobox y obtener el indice al que pertenece.*/
        private int seleccionar_indice_combobox(ComboBox cmb,string registro)
        {
            int indice = 0;
            for (int i = 1; i < cmb.Items.Count; i++)
            {
                if (registro == cmb.Items[i].ToString())
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        private void agregar_anio()
        {
            int anio = Convert.ToInt32(DateTime.Now.ToString("yyyy"));

            for (int i = anio - 3; i <= anio; i++)
            {
                cbox_anioNacimientoEstudiante.Items.Add(i.ToString());
            }
        }
        //================

        int alta_mod;

        private void frm_altaEstudiantes_Load(object sender, EventArgs e)
        {
            //int anio = Convert.ToInt32(DateTime.Now.ToString("yyyy"));

            //for (int i = anio - 3; i <= anio; i++)
            //{
            //    cbox_anioNacimientoEstudiante.Items.Add(i.ToString());
            //}
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_regresar.Tag.ToString()), variables.panelPrincipal);
        }
        

        /*agregar estyudiante y responsabel en desarrollo.*/
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            bool textboxs = metodos.verificar_datos(gbox_responsable);
            bool comboboxs = metodos.verificar_datos(gbox_estudiante);

            if (textboxs == false ||comboboxs == false)
            {
                MessageBox.Show("Faltan datos por completar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                /*compruebo formato de email.*/
                if (metodos.ComprobarFormatoEmail(txt_emailResponsable.Text) == false)
                {
                    MessageBox.Show("Formato erroneo de E.mail", "Error E-mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // compruebo longitud de los cuils.
                    bool cuilres_ver = metodos.verificar_cuils(gbox_responsable,txt_cuilResponsable1.Tag.ToString(),txt_cuilResponsable2.Tag.ToString(),txt_cuilResponsable3.Tag.ToString());
                    bool cuiles_ver = metodos.verificar_cuils(gbox_estudiante,txt_cuilEstudiante1.Tag.ToString(),txt_cuilEstudiante2.Tag.ToString(),txt_cuilEstudiante3.Tag.ToString());

                    if (cuilres_ver == false || cuiles_ver == false)
                    {
                        if (cuilres_ver == false)
                        {
                            MessageBox.Show("Faltan datos en el CUIL del responsable", "CUIL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        if (cuiles_ver == false)
                        {
                            MessageBox.Show("Faltan datos en el CUIL del estudiante", "CUIL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        switch (alta_mod)
                        {
                            case 0:
                                // alta.
                                // en desarrollo.
                                //DialogResult result = MessageBox.Show("¿Desea realizar alguna observación sobre el estudiante?", "", MessageBoxButtons.YesNo);

                                //if (result == DialogResult.Yes)
                                //{
                                //    Form form = new frm_observacionEstudiante();
                                //    form.ShowDialog();
                                //}
                                //========================

                                /*antes de cualquier insercion reviso no tener cuils iguales
                                 para responsables y estudiantes nuevos.*/
                                string cuil = txt_cuilResponsable1.Text + txt_cuilResponsable2.Text + txt_cuilResponsable3.Text;
                                string cuiles = txt_cuilEstudiante1.Text + txt_cuilEstudiante2.Text + txt_cuilEstudiante3.Text;
                                bool iddistintar = variables.BD.comprobarpkigual(cuil, "Responsable", "CUIL");
                                bool iddistintaes = variables.BD.comprobarpkigual(cuiles, "Estudiante", "CUIL");

                                /*compruebo si ya existen los cuils.*/
                                if (iddistintar == false || iddistintaes == false)
                                {
                                    if (iddistintar == false)
                                    {
                                        MessageBox.Show("ya existe un responsable con este cuil: " + cuil, "Cuil igual", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    if (iddistintaes == false)
                                    {
                                        MessageBox.Show("ya existe un estudiante con este cuil: " + cuiles, "Cuil igual", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    /*agrego responsable completado.*/
                                    string comandor = "INSERT INTO Responsable (CUIL, nombre, apellido, idNacionalidad, e_mail, direccion, idLocalidad, telefono, idParentezco) VALUES ('" + cuil + "', '" + txt_nombreResponsable.Text + "', '"
                                        + txt_apellidoResponsable.Text + "', " + cbox_nacionalidadResponsable.SelectedValue.ToString() + ", '"
                                        + txt_emailResponsable.Text + "', '" + txt_direccionResponsable.Text + "', "
                                        + cbox_localidadResponsable.SelectedValue.ToString() + ", '" + txt_telefonoResponsable.Text + "', "
                                        + cbox_parentezcoResponsable.SelectedValue.ToString() + ")";

                                    variables.BD.ABM(comandor);
                                    /*saco id del padre para relacionar con estudiante.*/
                                    string idresponsable = variables.BD.obtener_id_tabla("select idResponsable from Responsable where CUIL = '" + cuil + "'", "idResponsable");
                                    //==============================

                                    /*agrego estudiante en proceso.*/
                                    string fecha = cbox_diaNacimientoEstudiante.Text + "/" + cbox_mesNacimientoEstudiante.Text + "/" + cbox_anioNacimientoEstudiante.Text;
                                    string comandoes = "insert into Estudiante (CUIL, nombre, apellido, genero, fechaNacimiento, idCategoria, idturno, idCaracterizacion, idLocalidad, direccion, altura, entreCalle1, entreCalle2, idnacionalidad, idResponsable) values('"
                                        + cuiles + "', '" + txt_nombreEstudiante.Text + "', '" + txt_apellidoEstudiante.Text
                                        + "', '" + cbox_generoEstudiante.Text + "', '" + fecha + "'," + cbox_categoriaEstudiante.SelectedValue.ToString()
                                        + ", " + cbox_turno.SelectedValue.ToString() + ", " + cmb_caracterizacionEstudiante.SelectedValue.ToString()
                                        + ", " + cbox_localidadEstudiante.SelectedValue.ToString() + ", '" + txt_direccionEstudiante.Text
                                        + "', " + txt_altura.Text + ", '" + txt_entreCalle1Estudiante.Text + "', '" + txt_entreCalle2Estudiante.Text
                                        + "', " + cbox_nacionalidadEstudiante.SelectedValue.ToString() + ", " + idresponsable + " )";

                                    variables.BD.ABM(comandoes);
                                    MessageBox.Show("Se ha agregado el estudiante con éxito.", "", MessageBoxButtons.OK);
                                }
                                break;

                            case 1:
                                // modificacion.
                                string cuilmod = txt_cuilResponsable1.Text + txt_cuilResponsable2.Text + txt_cuilResponsable3.Text;
                                string cuilesmod = txt_cuilEstudiante1.Text + txt_cuilEstudiante2.Text + txt_cuilEstudiante3.Text;
                                bool iddistintarmod = variables.BD.comprobarcampoigualmodificacion(cuilmod, "Responsable", "CUIL", variables.id_responsable);
                                bool iddistintaesmod = variables.BD.comprobarcampoigualmodificacion(cuilesmod, "Estudiante", "CUIL", variables.id_estudiante);

                                /*compruebo si ya existen los cuils.*/
                                if (iddistintarmod == false || iddistintaesmod == false)
                                {
                                    if (iddistintarmod == false)
                                    {
                                        MessageBox.Show("ya existe un responsable con este cuil: " + cuilmod, "Cuil igual", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    if (iddistintaesmod == false)
                                    {
                                        MessageBox.Show("ya existe un estudiante con este cuil: " + cuilesmod, "Cuil igual", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    //==================
                                    // modifico responsable.
                                    string comandores = "update Responsable set CUIL = '" + cuilmod + "', nombre = '" + txt_nombreResponsable.Text
                                        + "' , apellido = '" + txt_apellidoResponsable.Text + "', idNacionalidad = "
                                        + cbox_nacionalidadResponsable.SelectedValue.ToString() + ", e_mail = '" + txt_emailResponsable.Text + "', "
                                        + "direccion = '" + txt_direccionResponsable.Text + "', idLocalidad = " + cbox_localidadEstudiante.SelectedValue.ToString()
                                        + " , telefono = '" + txt_telefonoResponsable.Text + "', idParentezco = " + cbox_parentezcoResponsable.SelectedValue.ToString()
                                        + " where CUIL = '" + variables.id_responsable + "'";
                                    bool responsable_finalizado = variables.BD.ABM(comandores);
                                    if (responsable_finalizado == true)
                                    {
                                        MessageBox.Show("Se finalizo con exito la modificacion responsable.");
                                        variables.id_responsable = cuilmod;
                                    }
                                    else
                                    {
                                        MessageBox.Show("error con responsable.");
                                    }
                                    //====================
                                    // modificar estudiante.
                                    string idresponsablemod = variables.BD.obtener_id_tabla("select idResponsable from Responsable where CUIL = '" + variables.id_responsable + "'", "idResponsable");
                                    string fechamod = cbox_diaNacimientoEstudiante.Text + "/" + cbox_mesNacimientoEstudiante.Text + "/" + cbox_anioNacimientoEstudiante.Text;
                                    string comandoest = "update Estudiante set nombre = '" + txt_nombreEstudiante.Text
                                        + "', apellido = '" + txt_apellidoEstudiante.Text + "', CUIL = '" + cuilesmod
                                        + "', genero = '" + cbox_generoEstudiante.Text + "', fechaNacimiento = '" + fechamod
                                        + "', idCategoria = " + cbox_categoriaEstudiante.SelectedValue.ToString() + ", idturno = "
                                        + cbox_turno.SelectedValue.ToString() + ", idCaracterizacion = " + cmb_caracterizacionEstudiante.SelectedValue.ToString()
                                        + ", idLocalidad = " + cbox_localidadEstudiante.SelectedValue.ToString() + ", direccion = '" + txt_direccionEstudiante.Text
                                        + "', altura = " + txt_altura.Text + ", entreCalle1 = '" + txt_entreCalle1Estudiante.Text
                                        + "', entreCalle2 = '" + txt_entreCalle2Estudiante.Text + "', idnacionalidad = " + cbox_localidadEstudiante.SelectedValue.ToString()
                                        + ", idResponsable = " + idresponsablemod + " where CUIL = '" + variables.id_estudiante + "'";

                                    if (variables.BD.ABM(comandoest))
                                    {
                                        MessageBox.Show("Se agrego estudinate con exito");
                                        variables.id_estudiante = cuilesmod;
                                    }
                                    else
                                    {
                                        MessageBox.Show("error");
                                    }
                                }
                                break;
                        } // switch
                    }

                    //metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_agregar.Tag.ToString()), variables.panelPrincipal);
                } // else
            }
        }//

        // validacion responsable.
        private void txt_nombreResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_textos(e);
        }

        private void txt_cuilResponsable1_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_numeros(e);
        }

        private void txt_cuilResponsable2_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_numeros(e);
        }

        private void txt_cuilResponsable3_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_numeros(e);
        }

        private void txt_emailResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void txt_direccionResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true && txt_direccionResponsable.Text.Length == 0 || char.IsWhiteSpace(e.KeyChar) == true && e.KeyChar == txt_direccionResponsable.Text[txt_direccionResponsable.Text.Length - 1])
            {
                e.Handled = true;
            }
        }

        private void txt_telefonoResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_numeros(e);
        }

        /*validacion estudiante.*/
        private void txt_cuilEstudiante1_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_numeros(e);
        }

        private void txt_cuilEstudiante2_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_numeros(e);
        }

        private void txt_cuilEstudiante3_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_numeros(e);
        }

        private void txt_direccionEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true && txt_direccionEstudiante.Text.Length == 0 || char.IsWhiteSpace(e.KeyChar) == true && e.KeyChar == txt_direccionEstudiante.Text[txt_direccionEstudiante.Text.Length - 1])
            {
                e.Handled = true;
            }
        }

        private void txt_nombreEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_textos(e);
        }

        private void txt_apellidoEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_textos(e);
        }

        private void txt_entreCalle1Estudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true && txt_direccionEstudiante.Text.Length == 0 || char.IsWhiteSpace(e.KeyChar) == true && e.KeyChar == txt_direccionEstudiante.Text[txt_direccionEstudiante.Text.Length - 1])
            {
                e.Handled = true;
            }
        }

        private void txt_entreCalle2Estudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true && txt_direccionEstudiante.Text.Length == 0 || char.IsWhiteSpace(e.KeyChar) == true && e.KeyChar == txt_direccionEstudiante.Text[txt_direccionEstudiante.Text.Length - 1])
            {
                e.Handled = true;
            }
        }

        private void txt_altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.validar_numeros(e);
        }

       

        

        
    }
}

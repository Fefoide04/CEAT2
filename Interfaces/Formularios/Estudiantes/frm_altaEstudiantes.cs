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
        public frm_altaEstudiantes()
        {
            InitializeComponent();
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
        }

        private void frm_altaEstudiantes_Load(object sender, EventArgs e)
        {
            int anio = Convert.ToInt32(DateTime.Now.ToString("yyyy"));

            for (int i = anio - 3; i <= anio; i++)
            {
                cbox_anioNacimientoEstudiante.Items.Add(i.ToString());
            }
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
                            + ", "+cbox_turno.SelectedValue.ToString()+", "+cmb_caracterizacionEstudiante.SelectedValue.ToString()
                            +", "+cbox_localidadEstudiante.SelectedValue.ToString()+", '"+txt_direccionEstudiante.Text
                            +"', "+txt_altura.Text+", '"+txt_entreCalle1Estudiante.Text+"', '"+txt_entreCalle2Estudiante.Text
                            +"', "+cbox_nacionalidadEstudiante.SelectedValue.ToString()+", "+idresponsable+" )";

                        variables.BD.ABM(comandoes);
                        MessageBox.Show("Se ha agregado el estudiante con éxito.", "", MessageBoxButtons.OK);
                    }

                    

                    //metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_agregar.Tag.ToString()), variables.panelPrincipal);
                }
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

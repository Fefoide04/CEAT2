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
            txt_telefonoResponsable.MaxLength = 12;
            // estudiantes.
            txt_cuilEstudiante1.MaxLength = 2;
            txt_cuilEstudiante2.MaxLength = 8;
            txt_cuilEstudiante3.MaxLength = 1;
            txt_direccionEstudiante.MaxLength = 30;
            txt_nombreEstudiante.MaxLength = 12;
            txt_apellidoEstudiante.MaxLength = 12;
            txt_entreCalle1Estudiante.MaxLength = 30;
            txt_entreCalle2Estudiante.MaxLength = 30;
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea realizar alguna observación sobre el estudiante?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Form form = new frm_observacionEstudiante();
                form.ShowDialog();
            }

            MessageBox.Show("Se ha agregado el estudiante con éxito.", "", MessageBoxButtons.OK);

            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_agregar.Tag.ToString()), variables.panelPrincipal);
        }

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

        

        
    }
}

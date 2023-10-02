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
    }
}

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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
            variables.panelPrincipal = pnl_displayPrincipal;
    
            btn_estudiantes.BackColor = variables.colores.primaryBaseColor;
            btn_reportes.BackColor = variables.colores.primaryBaseColor;
            btn_usuarios.BackColor = variables.colores.primaryBaseColor;
            btn_cerrarSesion.BackColor = variables.colores.primaryBaseColor;

            variables.BD.consulta("SELECT * from Estudiante");

            btn_usuarios.Visible = variables.perfil;
        }

        private void botonesClick(object sender, EventArgs e)
        {
            if (variables.botonSeleccionado != null)
                variables.botonSeleccionado.BackColor = variables.colores.primaryBaseColor;

            Button boton = (Button)sender;

            variables.botonSeleccionado = boton;
            boton.BackColor = variables.colores.primarySelectedColor;

            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(boton.Tag.ToString()), pnl_displayPrincipal);
        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

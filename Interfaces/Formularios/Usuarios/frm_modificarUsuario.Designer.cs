﻿namespace Interfaces
{
    partial class frm_modificarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox_datos = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmb_permisoRol = new System.Windows.Forms.ComboBox();
            this.lbl_permisoRol = new System.Windows.Forms.Label();
            this.btn_modificarUsuario = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_aclaracionContrasenia = new System.Windows.Forms.Label();
            this.txt_contraseniaUsuario = new System.Windows.Forms.TextBox();
            this.lbl_contraseniaUsuario = new System.Windows.Forms.Label();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.pnl_division = new System.Windows.Forms.Panel();
            this.txt_telefonoDocente = new System.Windows.Forms.TextBox();
            this.lbl_telefonoDocente = new System.Windows.Forms.Label();
            this.lbl_cuilDocente = new System.Windows.Forms.Label();
            this.txt_cuilDocente3 = new System.Windows.Forms.TextBox();
            this.txt_cuilDocente2 = new System.Windows.Forms.TextBox();
            this.txt_cuilDocente1 = new System.Windows.Forms.TextBox();
            this.txt_apellidoDocente = new System.Windows.Forms.TextBox();
            this.lbl_apellidoDocente = new System.Windows.Forms.Label();
            this.txt_nombreDocente = new System.Windows.Forms.TextBox();
            this.lbl_nombreDocente = new System.Windows.Forms.Label();
            this.pnl_encabezadoListaUsuarios = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_usuariosEncabezado = new System.Windows.Forms.Label();
            this.dtg_usuarios = new System.Windows.Forms.DataGridView();
            this.dtgvDocentesInactivos = new System.Windows.Forms.DataGridView();
            this.lblDocente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbox_datos.SuspendLayout();
            this.pnl_encabezadoListaUsuarios.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDocentesInactivos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_datos
            // 
            this.gbox_datos.Controls.Add(this.cmbEstado);
            this.gbox_datos.Controls.Add(this.lblEstado);
            this.gbox_datos.Controls.Add(this.cmb_permisoRol);
            this.gbox_datos.Controls.Add(this.lbl_permisoRol);
            this.gbox_datos.Controls.Add(this.btn_modificarUsuario);
            this.gbox_datos.Controls.Add(this.btn_regresar);
            this.gbox_datos.Controls.Add(this.lbl_aclaracionContrasenia);
            this.gbox_datos.Controls.Add(this.txt_contraseniaUsuario);
            this.gbox_datos.Controls.Add(this.lbl_contraseniaUsuario);
            this.gbox_datos.Controls.Add(this.txt_nombreUsuario);
            this.gbox_datos.Controls.Add(this.lbl_nombreUsuario);
            this.gbox_datos.Controls.Add(this.pnl_division);
            this.gbox_datos.Controls.Add(this.txt_telefonoDocente);
            this.gbox_datos.Controls.Add(this.lbl_telefonoDocente);
            this.gbox_datos.Controls.Add(this.lbl_cuilDocente);
            this.gbox_datos.Controls.Add(this.txt_cuilDocente3);
            this.gbox_datos.Controls.Add(this.txt_cuilDocente2);
            this.gbox_datos.Controls.Add(this.txt_cuilDocente1);
            this.gbox_datos.Controls.Add(this.txt_apellidoDocente);
            this.gbox_datos.Controls.Add(this.lbl_apellidoDocente);
            this.gbox_datos.Controls.Add(this.txt_nombreDocente);
            this.gbox_datos.Controls.Add(this.lbl_nombreDocente);
            this.gbox_datos.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbox_datos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_datos.Location = new System.Drawing.Point(0, 0);
            this.gbox_datos.Name = "gbox_datos";
            this.gbox_datos.Size = new System.Drawing.Size(471, 530);
            this.gbox_datos.TabIndex = 0;
            this.gbox_datos.TabStop = false;
            this.gbox_datos.Text = "Datos del Usuario";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Seleccionar",
            "Inactivo",
            "Activo"});
            this.cmbEstado.Location = new System.Drawing.Point(12, 189);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 28);
            this.cmbEstado.TabIndex = 29;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Location = new System.Drawing.Point(8, 166);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 20);
            this.lblEstado.TabIndex = 28;
            this.lblEstado.Text = "Estado";
            // 
            // cmb_permisoRol
            // 
            this.cmb_permisoRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_permisoRol.FormattingEnabled = true;
            this.cmb_permisoRol.Items.AddRange(new object[] {
            "Seleccionar",
            "Docente",
            "Director/a"});
            this.cmb_permisoRol.Location = new System.Drawing.Point(12, 406);
            this.cmb_permisoRol.Name = "cmb_permisoRol";
            this.cmb_permisoRol.Size = new System.Drawing.Size(121, 28);
            this.cmb_permisoRol.TabIndex = 27;
            this.cmb_permisoRol.SelectedIndexChanged += new System.EventHandler(this.cmb_permisoRol_SelectedIndexChanged);
            // 
            // lbl_permisoRol
            // 
            this.lbl_permisoRol.AutoSize = true;
            this.lbl_permisoRol.Location = new System.Drawing.Point(12, 383);
            this.lbl_permisoRol.Name = "lbl_permisoRol";
            this.lbl_permisoRol.Size = new System.Drawing.Size(44, 20);
            this.lbl_permisoRol.TabIndex = 26;
            this.lbl_permisoRol.Text = "Perfil";
            // 
            // btn_modificarUsuario
            // 
            this.btn_modificarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_modificarUsuario.Enabled = false;
            this.btn_modificarUsuario.Location = new System.Drawing.Point(12, 485);
            this.btn_modificarUsuario.Name = "btn_modificarUsuario";
            this.btn_modificarUsuario.Size = new System.Drawing.Size(126, 35);
            this.btn_modificarUsuario.TabIndex = 8;
            this.btn_modificarUsuario.Tag = "administracionUsuarios";
            this.btn_modificarUsuario.Text = "Modificar";
            this.btn_modificarUsuario.UseVisualStyleBackColor = false;
            this.btn_modificarUsuario.Click += new System.EventHandler(this.btn_modificarUsuario_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_regresar.Location = new System.Drawing.Point(312, 485);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(126, 35);
            this.btn_regresar.TabIndex = 9;
            this.btn_regresar.Tag = "administracionUsuarios";
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // lbl_aclaracionContrasenia
            // 
            this.lbl_aclaracionContrasenia.AutoSize = true;
            this.lbl_aclaracionContrasenia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aclaracionContrasenia.Location = new System.Drawing.Point(176, 367);
            this.lbl_aclaracionContrasenia.Name = "lbl_aclaracionContrasenia";
            this.lbl_aclaracionContrasenia.Size = new System.Drawing.Size(271, 36);
            this.lbl_aclaracionContrasenia.TabIndex = 25;
            this.lbl_aclaracionContrasenia.Text = "Si la contraseña permanece vacía, \r\nse creará una aleatoria";
            // 
            // txt_contraseniaUsuario
            // 
            this.txt_contraseniaUsuario.Location = new System.Drawing.Point(191, 337);
            this.txt_contraseniaUsuario.Name = "txt_contraseniaUsuario";
            this.txt_contraseniaUsuario.Size = new System.Drawing.Size(160, 26);
            this.txt_contraseniaUsuario.TabIndex = 7;
            this.txt_contraseniaUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contraseniaUsuario_KeyPress);
            // 
            // lbl_contraseniaUsuario
            // 
            this.lbl_contraseniaUsuario.AutoSize = true;
            this.lbl_contraseniaUsuario.Location = new System.Drawing.Point(187, 313);
            this.lbl_contraseniaUsuario.Name = "lbl_contraseniaUsuario";
            this.lbl_contraseniaUsuario.Size = new System.Drawing.Size(95, 20);
            this.lbl_contraseniaUsuario.TabIndex = 23;
            this.lbl_contraseniaUsuario.Text = "Contraseña";
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(12, 337);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(160, 26);
            this.txt_nombreUsuario.TabIndex = 6;
            this.txt_nombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreUsuario_KeyPress);
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(8, 313);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(68, 20);
            this.lbl_nombreUsuario.TabIndex = 22;
            this.lbl_nombreUsuario.Text = "Nombre";
            // 
            // pnl_division
            // 
            this.pnl_division.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_division.Location = new System.Drawing.Point(-1, 238);
            this.pnl_division.Name = "pnl_division";
            this.pnl_division.Size = new System.Drawing.Size(472, 55);
            this.pnl_division.TabIndex = 21;
            // 
            // txt_telefonoDocente
            // 
            this.txt_telefonoDocente.Location = new System.Drawing.Point(191, 124);
            this.txt_telefonoDocente.Name = "txt_telefonoDocente";
            this.txt_telefonoDocente.Size = new System.Drawing.Size(233, 26);
            this.txt_telefonoDocente.TabIndex = 5;
            this.txt_telefonoDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefonoDocente_KeyPress);
            // 
            // lbl_telefonoDocente
            // 
            this.lbl_telefonoDocente.AutoSize = true;
            this.lbl_telefonoDocente.Location = new System.Drawing.Point(187, 100);
            this.lbl_telefonoDocente.Name = "lbl_telefonoDocente";
            this.lbl_telefonoDocente.Size = new System.Drawing.Size(71, 20);
            this.lbl_telefonoDocente.TabIndex = 20;
            this.lbl_telefonoDocente.Text = "Teléfono";
            // 
            // lbl_cuilDocente
            // 
            this.lbl_cuilDocente.AutoSize = true;
            this.lbl_cuilDocente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuilDocente.Location = new System.Drawing.Point(187, 33);
            this.lbl_cuilDocente.Name = "lbl_cuilDocente";
            this.lbl_cuilDocente.Size = new System.Drawing.Size(36, 20);
            this.lbl_cuilDocente.TabIndex = 19;
            this.lbl_cuilDocente.Text = "Cuil";
            // 
            // txt_cuilDocente3
            // 
            this.txt_cuilDocente3.Location = new System.Drawing.Point(402, 60);
            this.txt_cuilDocente3.MaxLength = 1;
            this.txt_cuilDocente3.Name = "txt_cuilDocente3";
            this.txt_cuilDocente3.Size = new System.Drawing.Size(22, 26);
            this.txt_cuilDocente3.TabIndex = 3;
            this.txt_cuilDocente3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cuilDocente3_KeyPress);
            // 
            // txt_cuilDocente2
            // 
            this.txt_cuilDocente2.Location = new System.Drawing.Point(240, 60);
            this.txt_cuilDocente2.MaxLength = 8;
            this.txt_cuilDocente2.Name = "txt_cuilDocente2";
            this.txt_cuilDocente2.Size = new System.Drawing.Size(156, 26);
            this.txt_cuilDocente2.TabIndex = 2;
            this.txt_cuilDocente2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cuilDocente2_KeyPress);
            // 
            // txt_cuilDocente1
            // 
            this.txt_cuilDocente1.Location = new System.Drawing.Point(191, 60);
            this.txt_cuilDocente1.MaxLength = 2;
            this.txt_cuilDocente1.Name = "txt_cuilDocente1";
            this.txt_cuilDocente1.Size = new System.Drawing.Size(43, 26);
            this.txt_cuilDocente1.TabIndex = 1;
            this.txt_cuilDocente1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cuilDocente1_KeyPress);
            // 
            // txt_apellidoDocente
            // 
            this.txt_apellidoDocente.Location = new System.Drawing.Point(12, 124);
            this.txt_apellidoDocente.Name = "txt_apellidoDocente";
            this.txt_apellidoDocente.Size = new System.Drawing.Size(160, 26);
            this.txt_apellidoDocente.TabIndex = 4;
            this.txt_apellidoDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellidoDocente_KeyPress);
            // 
            // lbl_apellidoDocente
            // 
            this.lbl_apellidoDocente.AutoSize = true;
            this.lbl_apellidoDocente.Location = new System.Drawing.Point(8, 100);
            this.lbl_apellidoDocente.Name = "lbl_apellidoDocente";
            this.lbl_apellidoDocente.Size = new System.Drawing.Size(138, 20);
            this.lbl_apellidoDocente.TabIndex = 14;
            this.lbl_apellidoDocente.Text = "Apellido Docente";
            // 
            // txt_nombreDocente
            // 
            this.txt_nombreDocente.Location = new System.Drawing.Point(12, 60);
            this.txt_nombreDocente.Name = "txt_nombreDocente";
            this.txt_nombreDocente.Size = new System.Drawing.Size(160, 26);
            this.txt_nombreDocente.TabIndex = 0;
            this.txt_nombreDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreDocente_KeyPress);
            // 
            // lbl_nombreDocente
            // 
            this.lbl_nombreDocente.AutoSize = true;
            this.lbl_nombreDocente.Location = new System.Drawing.Point(8, 36);
            this.lbl_nombreDocente.Name = "lbl_nombreDocente";
            this.lbl_nombreDocente.Size = new System.Drawing.Size(137, 20);
            this.lbl_nombreDocente.TabIndex = 12;
            this.lbl_nombreDocente.Text = "Nombre Docente";
            // 
            // pnl_encabezadoListaUsuarios
            // 
            this.pnl_encabezadoListaUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl_encabezadoListaUsuarios.Controls.Add(this.panel1);
            this.pnl_encabezadoListaUsuarios.Controls.Add(this.lbl_usuariosEncabezado);
            this.pnl_encabezadoListaUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_encabezadoListaUsuarios.Location = new System.Drawing.Point(471, 0);
            this.pnl_encabezadoListaUsuarios.Name = "pnl_encabezadoListaUsuarios";
            this.pnl_encabezadoListaUsuarios.Size = new System.Drawing.Size(409, 70);
            this.pnl_encabezadoListaUsuarios.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 70);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // lbl_usuariosEncabezado
            // 
            this.lbl_usuariosEncabezado.AutoSize = true;
            this.lbl_usuariosEncabezado.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuariosEncabezado.Location = new System.Drawing.Point(157, 19);
            this.lbl_usuariosEncabezado.Name = "lbl_usuariosEncabezado";
            this.lbl_usuariosEncabezado.Size = new System.Drawing.Size(123, 32);
            this.lbl_usuariosEncabezado.TabIndex = 0;
            this.lbl_usuariosEncabezado.Text = "Usuarios";
            // 
            // dtg_usuarios
            // 
            this.dtg_usuarios.AllowUserToAddRows = false;
            this.dtg_usuarios.AllowUserToDeleteRows = false;
            this.dtg_usuarios.AllowUserToResizeColumns = false;
            this.dtg_usuarios.AllowUserToResizeRows = false;
            this.dtg_usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_usuarios.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtg_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_usuarios.Location = new System.Drawing.Point(471, 70);
            this.dtg_usuarios.Name = "dtg_usuarios";
            this.dtg_usuarios.ReadOnly = true;
            this.dtg_usuarios.RowHeadersWidth = 20;
            this.dtg_usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_usuarios.Size = new System.Drawing.Size(409, 212);
            this.dtg_usuarios.TabIndex = 3;
            this.dtg_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_usuarios_CellClick);
            // 
            // dtgvDocentesInactivos
            // 
            this.dtgvDocentesInactivos.AllowUserToAddRows = false;
            this.dtgvDocentesInactivos.AllowUserToResizeColumns = false;
            this.dtgvDocentesInactivos.AllowUserToResizeRows = false;
            this.dtgvDocentesInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDocentesInactivos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvDocentesInactivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDocentesInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDocentesInactivos.Location = new System.Drawing.Point(471, 340);
            this.dtgvDocentesInactivos.Name = "dtgvDocentesInactivos";
            this.dtgvDocentesInactivos.ReadOnly = true;
            this.dtgvDocentesInactivos.RowHeadersWidth = 20;
            this.dtgvDocentesInactivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvDocentesInactivos.Size = new System.Drawing.Size(409, 190);
            this.dtgvDocentesInactivos.TabIndex = 31;
            this.dtgvDocentesInactivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDocentesInactivos_CellClick);
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocente.Location = new System.Drawing.Point(114, 17);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(204, 25);
            this.lblDocente.TabIndex = 0;
            this.lblDocente.Text = "Docentes Inactivos";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(165)))), ((int)(((byte)(138)))));
            this.panel2.Controls.Add(this.lblDocente);
            this.panel2.Location = new System.Drawing.Point(471, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 58);
            this.panel2.TabIndex = 30;
            // 
            // frm_modificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.dtgvDocentesInactivos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtg_usuarios);
            this.Controls.Add(this.pnl_encabezadoListaUsuarios);
            this.Controls.Add(this.gbox_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_modificarUsuario";
            this.Text = "frm_modificarUsuario";
            this.Load += new System.EventHandler(this.frm_modificarUsuario_Load);
            this.gbox_datos.ResumeLayout(false);
            this.gbox_datos.PerformLayout();
            this.pnl_encabezadoListaUsuarios.ResumeLayout(false);
            this.pnl_encabezadoListaUsuarios.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDocentesInactivos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_datos;
        private System.Windows.Forms.TextBox txt_telefonoDocente;
        private System.Windows.Forms.Label lbl_telefonoDocente;
        private System.Windows.Forms.Label lbl_cuilDocente;
        private System.Windows.Forms.TextBox txt_cuilDocente3;
        private System.Windows.Forms.TextBox txt_cuilDocente2;
        private System.Windows.Forms.TextBox txt_cuilDocente1;
        private System.Windows.Forms.TextBox txt_apellidoDocente;
        private System.Windows.Forms.Label lbl_apellidoDocente;
        private System.Windows.Forms.TextBox txt_nombreDocente;
        private System.Windows.Forms.Label lbl_nombreDocente;
        private System.Windows.Forms.Button btn_modificarUsuario;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_aclaracionContrasenia;
        private System.Windows.Forms.TextBox txt_contraseniaUsuario;
        private System.Windows.Forms.Label lbl_contraseniaUsuario;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.Panel pnl_encabezadoListaUsuarios;
        private System.Windows.Forms.DataGridView dtg_usuarios;
        private System.Windows.Forms.Label lbl_usuariosEncabezado;
        private System.Windows.Forms.ComboBox cmb_permisoRol;
        private System.Windows.Forms.Label lbl_permisoRol;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDocentesInactivos;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_division;
    }
}
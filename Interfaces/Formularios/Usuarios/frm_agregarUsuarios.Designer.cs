namespace Interfaces
{
    partial class frm_agregarUsuarios
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
            this.gbox_docente = new System.Windows.Forms.GroupBox();
            this.txt_telefonoDocente = new System.Windows.Forms.TextBox();
            this.lbl_teléfonoDocente = new System.Windows.Forms.Label();
            this.lbl_cuilDocente = new System.Windows.Forms.Label();
            this.txt_cuilDocente3 = new System.Windows.Forms.TextBox();
            this.txt_cuilDocente2 = new System.Windows.Forms.TextBox();
            this.txt_cuilDocente1 = new System.Windows.Forms.TextBox();
            this.txt_apellidoDocente = new System.Windows.Forms.TextBox();
            this.lbl_apellidoDocente = new System.Windows.Forms.Label();
            this.txt_nombreDocente = new System.Windows.Forms.TextBox();
            this.lbl_nombreDocente = new System.Windows.Forms.Label();
            this.gbox_usuario = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.cmb_permisoRol = new System.Windows.Forms.ComboBox();
            this.lbl_permisoRol = new System.Windows.Forms.Label();
            this.btn_agregarUsuario = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_aclaracionContrasenia = new System.Windows.Forms.Label();
            this.txt_contraseniaUsuario = new System.Windows.Forms.TextBox();
            this.lbl_contraseniaUsuario = new System.Windows.Forms.Label();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.pnl_division = new System.Windows.Forms.Panel();
            this.gbox_docente.SuspendLayout();
            this.gbox_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_docente
            // 
            this.gbox_docente.BackColor = System.Drawing.Color.Transparent;
            this.gbox_docente.Controls.Add(this.txt_telefonoDocente);
            this.gbox_docente.Controls.Add(this.lbl_teléfonoDocente);
            this.gbox_docente.Controls.Add(this.lbl_cuilDocente);
            this.gbox_docente.Controls.Add(this.txt_cuilDocente3);
            this.gbox_docente.Controls.Add(this.txt_cuilDocente2);
            this.gbox_docente.Controls.Add(this.txt_cuilDocente1);
            this.gbox_docente.Controls.Add(this.txt_apellidoDocente);
            this.gbox_docente.Controls.Add(this.lbl_apellidoDocente);
            this.gbox_docente.Controls.Add(this.txt_nombreDocente);
            this.gbox_docente.Controls.Add(this.lbl_nombreDocente);
            this.gbox_docente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_docente.Location = new System.Drawing.Point(12, 12);
            this.gbox_docente.Name = "gbox_docente";
            this.gbox_docente.Size = new System.Drawing.Size(856, 190);
            this.gbox_docente.TabIndex = 0;
            this.gbox_docente.TabStop = false;
            this.gbox_docente.Text = "Datos del Docente";
            this.gbox_docente.Enter += new System.EventHandler(this.gbox_docente_Enter);
            // 
            // txt_telefonoDocente
            // 
            this.txt_telefonoDocente.Location = new System.Drawing.Point(458, 50);
            this.txt_telefonoDocente.Name = "txt_telefonoDocente";
            this.txt_telefonoDocente.Size = new System.Drawing.Size(233, 26);
            this.txt_telefonoDocente.TabIndex = 5;
            this.txt_telefonoDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefonoDocente_KeyPress);
            // 
            // lbl_teléfonoDocente
            // 
            this.lbl_teléfonoDocente.AutoSize = true;
            this.lbl_teléfonoDocente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_teléfonoDocente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teléfonoDocente.Location = new System.Drawing.Point(454, 26);
            this.lbl_teléfonoDocente.Name = "lbl_teléfonoDocente";
            this.lbl_teléfonoDocente.Size = new System.Drawing.Size(71, 18);
            this.lbl_teléfonoDocente.TabIndex = 10;
            this.lbl_teléfonoDocente.Text = "Teléfono";
            // 
            // lbl_cuilDocente
            // 
            this.lbl_cuilDocente.AutoSize = true;
            this.lbl_cuilDocente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cuilDocente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuilDocente.Location = new System.Drawing.Point(205, 23);
            this.lbl_cuilDocente.Name = "lbl_cuilDocente";
            this.lbl_cuilDocente.Size = new System.Drawing.Size(37, 18);
            this.lbl_cuilDocente.TabIndex = 9;
            this.lbl_cuilDocente.Text = "Cuil";
            // 
            // txt_cuilDocente3
            // 
            this.txt_cuilDocente3.Location = new System.Drawing.Point(420, 50);
            this.txt_cuilDocente3.MaxLength = 1;
            this.txt_cuilDocente3.Name = "txt_cuilDocente3";
            this.txt_cuilDocente3.Size = new System.Drawing.Size(22, 26);
            this.txt_cuilDocente3.TabIndex = 4;
            this.txt_cuilDocente3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cuilDocente3_KeyPress);
            // 
            // txt_cuilDocente2
            // 
            this.txt_cuilDocente2.Location = new System.Drawing.Point(258, 50);
            this.txt_cuilDocente2.MaxLength = 8;
            this.txt_cuilDocente2.Name = "txt_cuilDocente2";
            this.txt_cuilDocente2.Size = new System.Drawing.Size(156, 26);
            this.txt_cuilDocente2.TabIndex = 3;
            this.txt_cuilDocente2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cuilDocente2_KeyPress);
            // 
            // txt_cuilDocente1
            // 
            this.txt_cuilDocente1.Location = new System.Drawing.Point(209, 50);
            this.txt_cuilDocente1.MaxLength = 2;
            this.txt_cuilDocente1.Name = "txt_cuilDocente1";
            this.txt_cuilDocente1.Size = new System.Drawing.Size(43, 26);
            this.txt_cuilDocente1.TabIndex = 2;
            this.txt_cuilDocente1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cuilDocente1_KeyPress);
            // 
            // txt_apellidoDocente
            // 
            this.txt_apellidoDocente.Location = new System.Drawing.Point(30, 114);
            this.txt_apellidoDocente.Name = "txt_apellidoDocente";
            this.txt_apellidoDocente.Size = new System.Drawing.Size(160, 26);
            this.txt_apellidoDocente.TabIndex = 1;
            this.txt_apellidoDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellidoDocente_KeyPress);
            // 
            // lbl_apellidoDocente
            // 
            this.lbl_apellidoDocente.AutoSize = true;
            this.lbl_apellidoDocente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellidoDocente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoDocente.Location = new System.Drawing.Point(26, 90);
            this.lbl_apellidoDocente.Name = "lbl_apellidoDocente";
            this.lbl_apellidoDocente.Size = new System.Drawing.Size(71, 18);
            this.lbl_apellidoDocente.TabIndex = 2;
            this.lbl_apellidoDocente.Text = "Apellido";
            // 
            // txt_nombreDocente
            // 
            this.txt_nombreDocente.Location = new System.Drawing.Point(30, 50);
            this.txt_nombreDocente.Name = "txt_nombreDocente";
            this.txt_nombreDocente.Size = new System.Drawing.Size(160, 26);
            this.txt_nombreDocente.TabIndex = 0;
            this.txt_nombreDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreDocente_KeyPress);
            // 
            // lbl_nombreDocente
            // 
            this.lbl_nombreDocente.AutoSize = true;
            this.lbl_nombreDocente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreDocente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreDocente.Location = new System.Drawing.Point(26, 26);
            this.lbl_nombreDocente.Name = "lbl_nombreDocente";
            this.lbl_nombreDocente.Size = new System.Drawing.Size(68, 18);
            this.lbl_nombreDocente.TabIndex = 0;
            this.lbl_nombreDocente.Text = "Nombre";
            // 
            // gbox_usuario
            // 
            this.gbox_usuario.BackColor = System.Drawing.Color.Transparent;
            this.gbox_usuario.Controls.Add(this.label1);
            this.gbox_usuario.Controls.Add(this.dtgvUsuarios);
            this.gbox_usuario.Controls.Add(this.cmb_permisoRol);
            this.gbox_usuario.Controls.Add(this.lbl_permisoRol);
            this.gbox_usuario.Controls.Add(this.btn_agregarUsuario);
            this.gbox_usuario.Controls.Add(this.btn_regresar);
            this.gbox_usuario.Controls.Add(this.lbl_aclaracionContrasenia);
            this.gbox_usuario.Controls.Add(this.txt_contraseniaUsuario);
            this.gbox_usuario.Controls.Add(this.lbl_contraseniaUsuario);
            this.gbox_usuario.Controls.Add(this.txt_nombreUsuario);
            this.gbox_usuario.Controls.Add(this.lbl_nombreUsuario);
            this.gbox_usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_usuario.Location = new System.Drawing.Point(12, 283);
            this.gbox_usuario.Name = "gbox_usuario";
            this.gbox_usuario.Size = new System.Drawing.Size(856, 223);
            this.gbox_usuario.TabIndex = 1;
            this.gbox_usuario.TabStop = false;
            this.gbox_usuario.Text = "Datos del Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(527, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Usuarios:";
            this.label1.Visible = false;
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.AllowUserToAddRows = false;
            this.dtgvUsuarios.AllowUserToDeleteRows = false;
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(531, 43);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.ReadOnly = true;
            this.dtgvUsuarios.RowHeadersVisible = false;
            this.dtgvUsuarios.Size = new System.Drawing.Size(319, 174);
            this.dtgvUsuarios.TabIndex = 24;
            this.dtgvUsuarios.Visible = false;
            // 
            // cmb_permisoRol
            // 
            this.cmb_permisoRol.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmb_permisoRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_permisoRol.FormattingEnabled = true;
            this.cmb_permisoRol.Items.AddRange(new object[] {
            "Docente",
            "Director/a"});
            this.cmb_permisoRol.Location = new System.Drawing.Point(380, 56);
            this.cmb_permisoRol.Name = "cmb_permisoRol";
            this.cmb_permisoRol.Size = new System.Drawing.Size(121, 28);
            this.cmb_permisoRol.TabIndex = 23;
            // 
            // lbl_permisoRol
            // 
            this.lbl_permisoRol.AutoSize = true;
            this.lbl_permisoRol.BackColor = System.Drawing.Color.Transparent;
            this.lbl_permisoRol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_permisoRol.Location = new System.Drawing.Point(376, 32);
            this.lbl_permisoRol.Name = "lbl_permisoRol";
            this.lbl_permisoRol.Size = new System.Drawing.Size(43, 18);
            this.lbl_permisoRol.TabIndex = 22;
            this.lbl_permisoRol.Text = "Perfil";
            // 
            // btn_agregarUsuario
            // 
            this.btn_agregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_agregarUsuario.Location = new System.Drawing.Point(30, 166);
            this.btn_agregarUsuario.Name = "btn_agregarUsuario";
            this.btn_agregarUsuario.Size = new System.Drawing.Size(126, 35);
            this.btn_agregarUsuario.TabIndex = 21;
            this.btn_agregarUsuario.Tag = "administracionUsuarios";
            this.btn_agregarUsuario.Text = "Agregar";
            this.btn_agregarUsuario.UseVisualStyleBackColor = false;
            this.btn_agregarUsuario.Click += new System.EventHandler(this.btn_agregarUsuario_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_regresar.Location = new System.Drawing.Point(174, 166);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(126, 35);
            this.btn_regresar.TabIndex = 20;
            this.btn_regresar.Tag = "administracionUsuarios";
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // lbl_aclaracionContrasenia
            // 
            this.lbl_aclaracionContrasenia.AutoSize = true;
            this.lbl_aclaracionContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_aclaracionContrasenia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aclaracionContrasenia.Location = new System.Drawing.Point(27, 102);
            this.lbl_aclaracionContrasenia.Name = "lbl_aclaracionContrasenia";
            this.lbl_aclaracionContrasenia.Size = new System.Drawing.Size(444, 18);
            this.lbl_aclaracionContrasenia.TabIndex = 6;
            this.lbl_aclaracionContrasenia.Text = "Si la contraseña permanece vacía, se creará una aleatoria";
            // 
            // txt_contraseniaUsuario
            // 
            this.txt_contraseniaUsuario.Location = new System.Drawing.Point(209, 56);
            this.txt_contraseniaUsuario.Name = "txt_contraseniaUsuario";
            this.txt_contraseniaUsuario.Size = new System.Drawing.Size(160, 26);
            this.txt_contraseniaUsuario.TabIndex = 7;
            this.txt_contraseniaUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contraseniaUsuario_KeyPress);
            // 
            // lbl_contraseniaUsuario
            // 
            this.lbl_contraseniaUsuario.AutoSize = true;
            this.lbl_contraseniaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contraseniaUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseniaUsuario.Location = new System.Drawing.Point(205, 32);
            this.lbl_contraseniaUsuario.Name = "lbl_contraseniaUsuario";
            this.lbl_contraseniaUsuario.Size = new System.Drawing.Size(93, 18);
            this.lbl_contraseniaUsuario.TabIndex = 4;
            this.lbl_contraseniaUsuario.Text = "Contraseña";
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(30, 56);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(160, 26);
            this.txt_nombreUsuario.TabIndex = 6;
            this.txt_nombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreUsuario_KeyPress);
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(26, 32);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(68, 18);
            this.lbl_nombreUsuario.TabIndex = 2;
            this.lbl_nombreUsuario.Text = "Nombre";
            // 
            // pnl_division
            // 
            this.pnl_division.BackColor = System.Drawing.Color.Transparent;
            this.pnl_division.Location = new System.Drawing.Point(-30, 218);
            this.pnl_division.Name = "pnl_division";
            this.pnl_division.Size = new System.Drawing.Size(975, 55);
            this.pnl_division.TabIndex = 2;
            // 
            // frm_agregarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interfaces.Properties.Resources.altaUsuarios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.pnl_division);
            this.Controls.Add(this.gbox_usuario);
            this.Controls.Add(this.gbox_docente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_agregarUsuarios";
            this.Text = "frm_agregarUsuarios";
            this.Load += new System.EventHandler(this.frm_agregarUsuarios_Load);
            this.gbox_docente.ResumeLayout(false);
            this.gbox_docente.PerformLayout();
            this.gbox_usuario.ResumeLayout(false);
            this.gbox_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_docente;
        private System.Windows.Forms.GroupBox gbox_usuario;
        private System.Windows.Forms.Panel pnl_division;
        private System.Windows.Forms.Label lbl_nombreDocente;
        private System.Windows.Forms.TextBox txt_nombreDocente;
        private System.Windows.Forms.TextBox txt_apellidoDocente;
        private System.Windows.Forms.Label lbl_apellidoDocente;
        private System.Windows.Forms.Label lbl_cuilDocente;
        private System.Windows.Forms.TextBox txt_cuilDocente3;
        private System.Windows.Forms.TextBox txt_cuilDocente2;
        private System.Windows.Forms.TextBox txt_cuilDocente1;
        private System.Windows.Forms.TextBox txt_telefonoDocente;
        private System.Windows.Forms.Label lbl_teléfonoDocente;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.TextBox txt_contraseniaUsuario;
        private System.Windows.Forms.Label lbl_contraseniaUsuario;
        private System.Windows.Forms.Label lbl_aclaracionContrasenia;
        private System.Windows.Forms.Button btn_agregarUsuario;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_permisoRol;
        private System.Windows.Forms.Label lbl_permisoRol;
    }
}
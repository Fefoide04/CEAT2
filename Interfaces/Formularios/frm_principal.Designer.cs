namespace Interfaces
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.pnl_divisorVertical = new System.Windows.Forms.Panel();
            this.pnl_displayPrincipal = new System.Windows.Forms.Panel();
            this.pnl_botones = new System.Windows.Forms.Panel();
            this.pnl_divisorHorizontal = new System.Windows.Forms.Panel();
            this.pnl_encabezado = new System.Windows.Forms.Panel();
            this.btn_autorizados = new System.Windows.Forms.Button();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_estudiantes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_botones.SuspendLayout();
            this.pnl_encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_divisorVertical
            // 
            this.pnl_divisorVertical.BackColor = System.Drawing.Color.Gray;
            this.pnl_divisorVertical.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_divisorVertical.Location = new System.Drawing.Point(183, 0);
            this.pnl_divisorVertical.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnl_divisorVertical.Name = "pnl_divisorVertical";
            this.pnl_divisorVertical.Size = new System.Drawing.Size(2, 530);
            this.pnl_divisorVertical.TabIndex = 3;
            // 
            // pnl_displayPrincipal
            // 
            this.pnl_displayPrincipal.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_displayPrincipal.Location = new System.Drawing.Point(185, 0);
            this.pnl_displayPrincipal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnl_displayPrincipal.Name = "pnl_displayPrincipal";
            this.pnl_displayPrincipal.Size = new System.Drawing.Size(880, 530);
            this.pnl_displayPrincipal.TabIndex = 0;
            // 
            // pnl_botones
            // 
            this.pnl_botones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_botones.Controls.Add(this.btn_autorizados);
            this.pnl_botones.Controls.Add(this.btn_cerrarSesion);
            this.pnl_botones.Controls.Add(this.btn_usuarios);
            this.pnl_botones.Controls.Add(this.btn_reportes);
            this.pnl_botones.Controls.Add(this.btn_estudiantes);
            this.pnl_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_botones.Location = new System.Drawing.Point(0, 154);
            this.pnl_botones.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(183, 376);
            this.pnl_botones.TabIndex = 2;
            // 
            // pnl_divisorHorizontal
            // 
            this.pnl_divisorHorizontal.BackColor = System.Drawing.Color.Gray;
            this.pnl_divisorHorizontal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_divisorHorizontal.Location = new System.Drawing.Point(0, 152);
            this.pnl_divisorHorizontal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnl_divisorHorizontal.Name = "pnl_divisorHorizontal";
            this.pnl_divisorHorizontal.Size = new System.Drawing.Size(183, 2);
            this.pnl_divisorHorizontal.TabIndex = 0;
            // 
            // pnl_encabezado
            // 
            this.pnl_encabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_encabezado.Controls.Add(this.pictureBox1);
            this.pnl_encabezado.Controls.Add(this.pnl_divisorHorizontal);
            this.pnl_encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_encabezado.Location = new System.Drawing.Point(0, 0);
            this.pnl_encabezado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnl_encabezado.Name = "pnl_encabezado";
            this.pnl_encabezado.Size = new System.Drawing.Size(183, 154);
            this.pnl_encabezado.TabIndex = 1;
            // 
            // btn_autorizados
            // 
            this.btn_autorizados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_autorizados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_autorizados.FlatAppearance.BorderSize = 0;
            this.btn_autorizados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autorizados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_autorizados.Image = global::Interfaces.Properties.Resources.autorizados;
            this.btn_autorizados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_autorizados.Location = new System.Drawing.Point(0, 171);
            this.btn_autorizados.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_autorizados.Name = "btn_autorizados";
            this.btn_autorizados.Size = new System.Drawing.Size(183, 57);
            this.btn_autorizados.TabIndex = 14;
            this.btn_autorizados.Tag = "adultosAutorizados";
            this.btn_autorizados.Text = "Autorizaciones";
            this.btn_autorizados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_autorizados.UseVisualStyleBackColor = false;
            this.btn_autorizados.Click += new System.EventHandler(this.botonesClick);
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_cerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cerrarSesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarSesion.Image = global::Interfaces.Properties.Resources.cerrarsesion;
            this.btn_cerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(0, 319);
            this.btn_cerrarSesion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(183, 57);
            this.btn_cerrarSesion.TabIndex = 13;
            this.btn_cerrarSesion.Text = "Cerrar Sesión";
            this.btn_cerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrarSesion.UseVisualStyleBackColor = false;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.Image = global::Interfaces.Properties.Resources.profesoresIcono;
            this.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.Location = new System.Drawing.Point(0, 114);
            this.btn_usuarios.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(183, 57);
            this.btn_usuarios.TabIndex = 12;
            this.btn_usuarios.Tag = "administracionUsuarios";
            this.btn_usuarios.Text = "Docentes";
            this.btn_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_usuarios.UseVisualStyleBackColor = false;
            this.btn_usuarios.Click += new System.EventHandler(this.botonesClick);
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.Image = global::Interfaces.Properties.Resources.reportesIcono;
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(0, 57);
            this.btn_reportes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(183, 57);
            this.btn_reportes.TabIndex = 11;
            this.btn_reportes.Tag = "reportes";
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reportes.UseVisualStyleBackColor = false;
            this.btn_reportes.Click += new System.EventHandler(this.botonesClick);
            // 
            // btn_estudiantes
            // 
            this.btn_estudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_estudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_estudiantes.FlatAppearance.BorderSize = 0;
            this.btn_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estudiantes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estudiantes.Image = global::Interfaces.Properties.Resources.estudiantesIcono;
            this.btn_estudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estudiantes.Location = new System.Drawing.Point(0, 0);
            this.btn_estudiantes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_estudiantes.Name = "btn_estudiantes";
            this.btn_estudiantes.Size = new System.Drawing.Size(183, 57);
            this.btn_estudiantes.TabIndex = 10;
            this.btn_estudiantes.Tag = "estudiantes";
            this.btn_estudiantes.Text = "Estudiantes";
            this.btn_estudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_estudiantes.UseVisualStyleBackColor = false;
            this.btn_estudiantes.Click += new System.EventHandler(this.botonesClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Interfaces.Properties.Resources.Logo_CEAT;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 152);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1065, 530);
            this.Controls.Add(this.pnl_botones);
            this.Controls.Add(this.pnl_encabezado);
            this.Controls.Add(this.pnl_divisorVertical);
            this.Controls.Add(this.pnl_displayPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "frm_principal";
            this.Text = "Software CEAT San Vicente";
            this.pnl_botones.ResumeLayout(false);
            this.pnl_encabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_divisorVertical;
        private System.Windows.Forms.Panel pnl_displayPrincipal;
        private System.Windows.Forms.Button btn_estudiantes;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.Panel pnl_botones;
        private System.Windows.Forms.Panel pnl_divisorHorizontal;
        private System.Windows.Forms.Panel pnl_encabezado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_autorizados;
    }
}
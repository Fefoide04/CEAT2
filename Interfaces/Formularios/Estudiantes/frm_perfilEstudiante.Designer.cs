namespace Interfaces
{
    partial class frm_perfilEstudiante
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
            this.lbl_nombreApellidoEstudiante = new System.Windows.Forms.Label();
            this.pnl_columnaDerecha = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_turnoEstudiante = new System.Windows.Forms.Label();
            this.lbl_caracterizacionEstudiante = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_modificarDatos = new System.Windows.Forms.Button();
            this.pnl_columnaDerecha.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombreApellidoEstudiante
            // 
            this.lbl_nombreApellidoEstudiante.AutoSize = true;
            this.lbl_nombreApellidoEstudiante.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_nombreApellidoEstudiante.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreApellidoEstudiante.Location = new System.Drawing.Point(0, 0);
            this.lbl_nombreApellidoEstudiante.Name = "lbl_nombreApellidoEstudiante";
            this.lbl_nombreApellidoEstudiante.Size = new System.Drawing.Size(280, 36);
            this.lbl_nombreApellidoEstudiante.TabIndex = 1;
            this.lbl_nombreApellidoEstudiante.Text = "Nombre y Apellido";
            // 
            // pnl_columnaDerecha
            // 
            this.pnl_columnaDerecha.Controls.Add(this.panel1);
            this.pnl_columnaDerecha.Controls.Add(this.lbl_nombreApellidoEstudiante);
            this.pnl_columnaDerecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_columnaDerecha.Location = new System.Drawing.Point(0, 0);
            this.pnl_columnaDerecha.Name = "pnl_columnaDerecha";
            this.pnl_columnaDerecha.Size = new System.Drawing.Size(880, 152);
            this.pnl_columnaDerecha.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_turnoEstudiante);
            this.panel1.Controls.Add(this.lbl_caracterizacionEstudiante);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(680, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 152);
            this.panel1.TabIndex = 2;
            // 
            // lbl_turnoEstudiante
            // 
            this.lbl_turnoEstudiante.AutoSize = true;
            this.lbl_turnoEstudiante.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_turnoEstudiante.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turnoEstudiante.Location = new System.Drawing.Point(0, 30);
            this.lbl_turnoEstudiante.Name = "lbl_turnoEstudiante";
            this.lbl_turnoEstudiante.Size = new System.Drawing.Size(77, 30);
            this.lbl_turnoEstudiante.TabIndex = 3;
            this.lbl_turnoEstudiante.Text = "Turno";
            // 
            // lbl_caracterizacionEstudiante
            // 
            this.lbl_caracterizacionEstudiante.AutoSize = true;
            this.lbl_caracterizacionEstudiante.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_caracterizacionEstudiante.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caracterizacionEstudiante.Location = new System.Drawing.Point(0, 0);
            this.lbl_caracterizacionEstudiante.Name = "lbl_caracterizacionEstudiante";
            this.lbl_caracterizacionEstudiante.Size = new System.Drawing.Size(204, 30);
            this.lbl_caracterizacionEstudiante.TabIndex = 2;
            this.lbl_caracterizacionEstudiante.Text = "Caracterización";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_regresar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(0, 314);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(880, 81);
            this.btn_regresar.TabIndex = 7;
            this.btn_regresar.Tag = "estudiantes";
            this.btn_regresar.Text = "Regresar a Estudiantes";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_baja
            // 
            this.btn_baja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_baja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_baja.FlatAppearance.BorderSize = 0;
            this.btn_baja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_baja.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baja.Location = new System.Drawing.Point(0, 233);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(880, 81);
            this.btn_baja.TabIndex = 6;
            this.btn_baja.Tag = "estudiantes";
            this.btn_baja.Text = "Relevar / Dar de baja";
            this.btn_baja.UseVisualStyleBackColor = false;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_modificarDatos
            // 
            this.btn_modificarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btn_modificarDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_modificarDatos.FlatAppearance.BorderSize = 0;
            this.btn_modificarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarDatos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarDatos.Location = new System.Drawing.Point(0, 152);
            this.btn_modificarDatos.Name = "btn_modificarDatos";
            this.btn_modificarDatos.Size = new System.Drawing.Size(880, 81);
            this.btn_modificarDatos.TabIndex = 5;
            this.btn_modificarDatos.Tag = "modificacionEstudiante";
            this.btn_modificarDatos.Text = "Modificar Datos";
            this.btn_modificarDatos.UseVisualStyleBackColor = false;
            this.btn_modificarDatos.Click += new System.EventHandler(this.btn_modificarDatos_Click);
            // 
            // frm_perfilEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_modificarDatos);
            this.Controls.Add(this.pnl_columnaDerecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_perfilEstudiante";
            this.Text = "frm_perfilEstudiante";
            this.pnl_columnaDerecha.ResumeLayout(false);
            this.pnl_columnaDerecha.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreApellidoEstudiante;
        private System.Windows.Forms.Panel pnl_columnaDerecha;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modificarDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_turnoEstudiante;
        private System.Windows.Forms.Label lbl_caracterizacionEstudiante;
    }
}
namespace Interfaces
{
    partial class frm_seleccionarTipoReporte
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_relevamientoEspecifico = new System.Windows.Forms.Button();
            this.btn_reporteGeneral = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 152);
            this.panel1.TabIndex = 1;
            // 
            // btn_relevamientoEspecifico
            // 
            this.btn_relevamientoEspecifico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_relevamientoEspecifico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_relevamientoEspecifico.FlatAppearance.BorderSize = 0;
            this.btn_relevamientoEspecifico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relevamientoEspecifico.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_relevamientoEspecifico.Location = new System.Drawing.Point(0, 233);
            this.btn_relevamientoEspecifico.Name = "btn_relevamientoEspecifico";
            this.btn_relevamientoEspecifico.Size = new System.Drawing.Size(880, 81);
            this.btn_relevamientoEspecifico.TabIndex = 3;
            this.btn_relevamientoEspecifico.Tag = "reporteEspecifico";
            this.btn_relevamientoEspecifico.Text = "Reporte Específico";
            this.btn_relevamientoEspecifico.UseVisualStyleBackColor = false;
            this.btn_relevamientoEspecifico.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_reporteGeneral
            // 
            this.btn_reporteGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btn_reporteGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reporteGeneral.FlatAppearance.BorderSize = 0;
            this.btn_reporteGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporteGeneral.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporteGeneral.Location = new System.Drawing.Point(0, 152);
            this.btn_reporteGeneral.Name = "btn_reporteGeneral";
            this.btn_reporteGeneral.Size = new System.Drawing.Size(880, 81);
            this.btn_reporteGeneral.TabIndex = 2;
            this.btn_reporteGeneral.Tag = "relevamientoAnual";
            this.btn_reporteGeneral.Text = "Reporte General";
            this.btn_reporteGeneral.UseVisualStyleBackColor = false;
            this.btn_reporteGeneral.Click += new System.EventHandler(this.btn_click);
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
            this.btn_regresar.TabIndex = 4;
            this.btn_regresar.Tag = "estudiantes";
            this.btn_regresar.Text = "Regresar a Estudiantes";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_click);
            // 
            // frm_seleccionarTipoReporte
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_relevamientoEspecifico);
            this.Controls.Add(this.btn_reporteGeneral);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_seleccionarTipoReporte";
            this.Text = "frm_seleccionarTipoReporte";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_relevamientoEspecifico;
        private System.Windows.Forms.Button btn_reporteGeneral;
        private System.Windows.Forms.Button btn_regresar;
    }
}
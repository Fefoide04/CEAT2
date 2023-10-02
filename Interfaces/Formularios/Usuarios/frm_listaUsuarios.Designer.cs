namespace Interfaces
{
    partial class frm_listaUsuarios
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
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.cmb_filtros = new System.Windows.Forms.ComboBox();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.dtg_vistaDocentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vistaDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro.Location = new System.Drawing.Point(752, 19);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(48, 20);
            this.lbl_filtro.TabIndex = 12;
            this.lbl_filtro.Text = "Filtros";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(16, 19);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(209, 20);
            this.lbl_buscar.TabIndex = 11;
            this.lbl_buscar.Text = "Presione ENTER para buscar";
            // 
            // cmb_filtros
            // 
            this.cmb_filtros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_filtros.FormattingEnabled = true;
            this.cmb_filtros.Items.AddRange(new object[] {
            "N. Usuario",
            "N. Docente"});
            this.cmb_filtros.Location = new System.Drawing.Point(717, 42);
            this.cmb_filtros.Name = "cmb_filtros";
            this.cmb_filtros.Size = new System.Drawing.Size(138, 29);
            this.cmb_filtros.TabIndex = 10;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(20, 42);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(682, 27);
            this.txt_busqueda.TabIndex = 9;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(20, 470);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(157, 43);
            this.btn_regresar.TabIndex = 8;
            this.btn_regresar.Tag = "administracionUsuarios";
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // dtg_vistaDocentes
            // 
            this.dtg_vistaDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_vistaDocentes.Location = new System.Drawing.Point(20, 88);
            this.dtg_vistaDocentes.Name = "dtg_vistaDocentes";
            this.dtg_vistaDocentes.Size = new System.Drawing.Size(835, 369);
            this.dtg_vistaDocentes.TabIndex = 6;
            this.dtg_vistaDocentes.Tag = "perfilEstudiante";
            // 
            // frm_listaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.lbl_filtro);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.cmb_filtros);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.dtg_vistaDocentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_listaUsuarios";
            this.Text = "frm_listaUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vistaDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.ComboBox cmb_filtros;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.DataGridView dtg_vistaDocentes;

    }
}
namespace Interfaces
{
    partial class frm_relevamientoEspecifico
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
            this.cbox_sexoFiltro = new System.Windows.Forms.ComboBox();
            this.dtg_estudiantesFiltro = new System.Windows.Forms.DataGridView();
            this.cbox_categoriaFiltro = new System.Windows.Forms.ComboBox();
            this.cbox_turnoFiltro = new System.Windows.Forms.ComboBox();
            this.cbox_caracterizacionFiltro = new System.Windows.Forms.ComboBox();
            this.txt_conteoFiltro = new System.Windows.Forms.TextBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_caracterizacion = new System.Windows.Forms.Label();
            this.lbl_turno = new System.Windows.Forms.Label();
            this.lbl_conteo = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_estudiantesFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox_sexoFiltro
            // 
            this.cbox_sexoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_sexoFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_sexoFiltro.FormattingEnabled = true;
            this.cbox_sexoFiltro.Items.AddRange(new object[] {
            "elija genero",
            "Masculino",
            "Femenino"});
            this.cbox_sexoFiltro.Location = new System.Drawing.Point(193, 45);
            this.cbox_sexoFiltro.Name = "cbox_sexoFiltro";
            this.cbox_sexoFiltro.Size = new System.Drawing.Size(143, 28);
            this.cbox_sexoFiltro.TabIndex = 0;
            this.cbox_sexoFiltro.SelectedIndexChanged += new System.EventHandler(this.cbox_sexoFiltro_SelectedIndexChanged);
            // 
            // dtg_estudiantesFiltro
            // 
            this.dtg_estudiantesFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_estudiantesFiltro.Location = new System.Drawing.Point(12, 94);
            this.dtg_estudiantesFiltro.Name = "dtg_estudiantesFiltro";
            this.dtg_estudiantesFiltro.Size = new System.Drawing.Size(829, 369);
            this.dtg_estudiantesFiltro.TabIndex = 1;
            this.dtg_estudiantesFiltro.Tag = "perfilEstudiante";
            // 
            // cbox_categoriaFiltro
            // 
            this.cbox_categoriaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_categoriaFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_categoriaFiltro.FormattingEnabled = true;
            this.cbox_categoriaFiltro.Location = new System.Drawing.Point(17, 45);
            this.cbox_categoriaFiltro.Name = "cbox_categoriaFiltro";
            this.cbox_categoriaFiltro.Size = new System.Drawing.Size(143, 28);
            this.cbox_categoriaFiltro.TabIndex = 0;
            this.cbox_categoriaFiltro.SelectedIndexChanged += new System.EventHandler(this.cbox_categoriaFiltro_SelectedIndexChanged);
            // 
            // cbox_turnoFiltro
            // 
            this.cbox_turnoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_turnoFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_turnoFiltro.FormattingEnabled = true;
            this.cbox_turnoFiltro.Items.AddRange(new object[] {
            "elija turno",
            "Mañana",
            "Tarde"});
            this.cbox_turnoFiltro.Location = new System.Drawing.Point(698, 45);
            this.cbox_turnoFiltro.Name = "cbox_turnoFiltro";
            this.cbox_turnoFiltro.Size = new System.Drawing.Size(143, 28);
            this.cbox_turnoFiltro.TabIndex = 0;
            this.cbox_turnoFiltro.SelectedIndexChanged += new System.EventHandler(this.cbox_turnoFiltro_SelectedIndexChanged);
            // 
            // cbox_caracterizacionFiltro
            // 
            this.cbox_caracterizacionFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_caracterizacionFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_caracterizacionFiltro.FormattingEnabled = true;
            this.cbox_caracterizacionFiltro.Items.AddRange(new object[] {
            "Discapacidad Auditiva",
            "Discapacidad Visual",
            "Sordo - Ceguera",
            "Discapacidad Motora",
            "Alt. en el desarrollo y la const. subjetiva",
            "Discapacidad Intelectual ",
            "Trastronos específicos en el lenguaje",
            "Discapacidad múltiple",
            "Riesgo ambiental"});
            this.cbox_caracterizacionFiltro.Location = new System.Drawing.Point(369, 45);
            this.cbox_caracterizacionFiltro.Name = "cbox_caracterizacionFiltro";
            this.cbox_caracterizacionFiltro.Size = new System.Drawing.Size(295, 28);
            this.cbox_caracterizacionFiltro.TabIndex = 0;
            this.cbox_caracterizacionFiltro.SelectedIndexChanged += new System.EventHandler(this.cbox_caracterizacionFiltro_SelectedIndexChanged);
            // 
            // txt_conteoFiltro
            // 
            this.txt_conteoFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conteoFiltro.Location = new System.Drawing.Point(741, 492);
            this.txt_conteoFiltro.Name = "txt_conteoFiltro";
            this.txt_conteoFiltro.ReadOnly = true;
            this.txt_conteoFiltro.ShortcutsEnabled = false;
            this.txt_conteoFiltro.Size = new System.Drawing.Size(100, 26);
            this.txt_conteoFiltro.TabIndex = 2;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(13, 22);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(84, 20);
            this.lbl_categoria.TabIndex = 3;
            this.lbl_categoria.Text = "Categoría";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.Location = new System.Drawing.Point(189, 22);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(43, 20);
            this.lbl_sexo.TabIndex = 3;
            this.lbl_sexo.Text = "Sexo";
            // 
            // lbl_caracterizacion
            // 
            this.lbl_caracterizacion.AutoSize = true;
            this.lbl_caracterizacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caracterizacion.Location = new System.Drawing.Point(365, 22);
            this.lbl_caracterizacion.Name = "lbl_caracterizacion";
            this.lbl_caracterizacion.Size = new System.Drawing.Size(127, 20);
            this.lbl_caracterizacion.TabIndex = 3;
            this.lbl_caracterizacion.Text = "Caracterización";
            // 
            // lbl_turno
            // 
            this.lbl_turno.AutoSize = true;
            this.lbl_turno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turno.Location = new System.Drawing.Point(694, 22);
            this.lbl_turno.Name = "lbl_turno";
            this.lbl_turno.Size = new System.Drawing.Size(47, 20);
            this.lbl_turno.TabIndex = 3;
            this.lbl_turno.Text = "Turno";
            // 
            // lbl_conteo
            // 
            this.lbl_conteo.AutoSize = true;
            this.lbl_conteo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conteo.Location = new System.Drawing.Point(726, 469);
            this.lbl_conteo.Name = "lbl_conteo";
            this.lbl_conteo.Size = new System.Drawing.Size(115, 20);
            this.lbl_conteo.TabIndex = 4;
            this.lbl_conteo.Text = "Cantidad Total";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_regresar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(12, 479);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(127, 39);
            this.btn_regresar.TabIndex = 5;
            this.btn_regresar.Tag = "reportes";
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // frm_relevamientoEspecifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_conteo);
            this.Controls.Add(this.lbl_turno);
            this.Controls.Add(this.lbl_caracterizacion);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.txt_conteoFiltro);
            this.Controls.Add(this.dtg_estudiantesFiltro);
            this.Controls.Add(this.cbox_caracterizacionFiltro);
            this.Controls.Add(this.cbox_turnoFiltro);
            this.Controls.Add(this.cbox_categoriaFiltro);
            this.Controls.Add(this.cbox_sexoFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_relevamientoEspecifico";
            this.Text = "frm_relevamientoEspecifico";
            this.Load += new System.EventHandler(this.frm_relevamientoEspecifico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_estudiantesFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_sexoFiltro;
        private System.Windows.Forms.DataGridView dtg_estudiantesFiltro;
        private System.Windows.Forms.ComboBox cbox_categoriaFiltro;
        private System.Windows.Forms.ComboBox cbox_turnoFiltro;
        private System.Windows.Forms.ComboBox cbox_caracterizacionFiltro;
        private System.Windows.Forms.TextBox txt_conteoFiltro;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_caracterizacion;
        private System.Windows.Forms.Label lbl_turno;
        private System.Windows.Forms.Label lbl_conteo;
        private System.Windows.Forms.Button btn_regresar;
    }
}
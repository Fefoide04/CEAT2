namespace Interfaces
{
    partial class frm_visualizacionEstudiantes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtg_vistaEstudiantes = new System.Windows.Forms.DataGridView();
            this.btn_irConsultas = new System.Windows.Forms.Button();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.cmb_filtros = new System.Windows.Forms.ComboBox();
            this.btn_agregarEstudiantes = new System.Windows.Forms.Button();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lbl_filtro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vistaEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_vistaEstudiantes
            // 
            this.dtg_vistaEstudiantes.AllowUserToAddRows = false;
            this.dtg_vistaEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_vistaEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_vistaEstudiantes.Location = new System.Drawing.Point(25, 90);
            this.dtg_vistaEstudiantes.Name = "dtg_vistaEstudiantes";
            this.dtg_vistaEstudiantes.RowHeadersVisible = false;
            this.dtg_vistaEstudiantes.Size = new System.Drawing.Size(829, 369);
            this.dtg_vistaEstudiantes.TabIndex = 0;
            this.dtg_vistaEstudiantes.Tag = "perfilEstudiante";
            this.dtg_vistaEstudiantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_vistaEstudiantes_CellDoubleClick);
            this.dtg_vistaEstudiantes.DoubleClick += new System.EventHandler(this.dtg_vistaEstudiantes_DoubleClick);
            // 
            // btn_irConsultas
            // 
            this.btn_irConsultas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_irConsultas.Location = new System.Drawing.Point(25, 465);
            this.btn_irConsultas.Name = "btn_irConsultas";
            this.btn_irConsultas.Size = new System.Drawing.Size(157, 43);
            this.btn_irConsultas.TabIndex = 1;
            this.btn_irConsultas.Tag = "reportes";
            this.btn_irConsultas.Text = "Realizar reportes";
            this.btn_irConsultas.UseVisualStyleBackColor = true;
            this.btn_irConsultas.Click += new System.EventHandler(this.btn_irConsultas_Click);
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(25, 44);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(682, 27);
            this.txt_busqueda.TabIndex = 2;
            this.txt_busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_busqueda_KeyPress);
            // 
            // cmb_filtros
            // 
            this.cmb_filtros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_filtros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_filtros.FormattingEnabled = true;
            this.cmb_filtros.Items.AddRange(new object[] {
            "Mostrar Todo",
            "Nombre",
            "Apellido",
            "Caracterización",
            "Categoria"});
            this.cmb_filtros.Location = new System.Drawing.Point(722, 44);
            this.cmb_filtros.Name = "cmb_filtros";
            this.cmb_filtros.Size = new System.Drawing.Size(132, 29);
            this.cmb_filtros.TabIndex = 3;
            this.cmb_filtros.SelectedIndexChanged += new System.EventHandler(this.cmb_filtros_SelectedIndexChanged);
            // 
            // btn_agregarEstudiantes
            // 
            this.btn_agregarEstudiantes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarEstudiantes.Location = new System.Drawing.Point(188, 465);
            this.btn_agregarEstudiantes.Name = "btn_agregarEstudiantes";
            this.btn_agregarEstudiantes.Size = new System.Drawing.Size(182, 43);
            this.btn_agregarEstudiantes.TabIndex = 1;
            this.btn_agregarEstudiantes.Tag = "altaEstudiantes";
            this.btn_agregarEstudiantes.Text = "Agregar Estudiantes";
            this.btn_agregarEstudiantes.UseVisualStyleBackColor = true;
            this.btn_agregarEstudiantes.Click += new System.EventHandler(this.btn_agregarEstudiantes_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(21, 21);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(209, 20);
            this.lbl_buscar.TabIndex = 4;
            this.lbl_buscar.Text = "Presione ENTER para buscar";
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro.Location = new System.Drawing.Point(757, 21);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(48, 20);
            this.lbl_filtro.TabIndex = 5;
            this.lbl_filtro.Text = "Filtros";
            // 
            // frm_visualizacionEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.lbl_filtro);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.cmb_filtros);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.btn_agregarEstudiantes);
            this.Controls.Add(this.btn_irConsultas);
            this.Controls.Add(this.dtg_vistaEstudiantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_visualizacionEstudiantes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_visualizacionEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vistaEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_vistaEstudiantes;
        private System.Windows.Forms.Button btn_irConsultas;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.ComboBox cmb_filtros;
        private System.Windows.Forms.Button btn_agregarEstudiantes;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label lbl_filtro;
    }
}


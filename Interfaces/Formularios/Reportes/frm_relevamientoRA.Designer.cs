namespace Interfaces
{
    partial class frm_relevamientoRA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_relevamientoCaracterizacion = new System.Windows.Forms.DataGridView();
            this.pnl_encabezadoRelevamientoRA = new System.Windows.Forms.Panel();
            this.dtg_relevamientoTurno = new System.Windows.Forms.DataGridView();
            this.lbl_encabezadoRA = new System.Windows.Forms.Label();
            this.caracterizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.femenino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masculino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_relevamientoCaracterizacion)).BeginInit();
            this.pnl_encabezadoRelevamientoRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_relevamientoTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_relevamientoCaracterizacion
            // 
            this.dtg_relevamientoCaracterizacion.AllowUserToAddRows = false;
            this.dtg_relevamientoCaracterizacion.AllowUserToDeleteRows = false;
            this.dtg_relevamientoCaracterizacion.AllowUserToResizeColumns = false;
            this.dtg_relevamientoCaracterizacion.AllowUserToResizeRows = false;
            this.dtg_relevamientoCaracterizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_relevamientoCaracterizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtg_relevamientoCaracterizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_relevamientoCaracterizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caracterizacion,
            this.femenino,
            this.masculino});
            this.dtg_relevamientoCaracterizacion.Location = new System.Drawing.Point(110, 106);
            this.dtg_relevamientoCaracterizacion.Name = "dtg_relevamientoCaracterizacion";
            this.dtg_relevamientoCaracterizacion.RowHeadersVisible = false;
            this.dtg_relevamientoCaracterizacion.Size = new System.Drawing.Size(383, 317);
            this.dtg_relevamientoCaracterizacion.TabIndex = 0;
            // 
            // pnl_encabezadoRelevamientoRA
            // 
            this.pnl_encabezadoRelevamientoRA.Controls.Add(this.lbl_encabezadoRA);
            this.pnl_encabezadoRelevamientoRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_encabezadoRelevamientoRA.Location = new System.Drawing.Point(0, 0);
            this.pnl_encabezadoRelevamientoRA.Name = "pnl_encabezadoRelevamientoRA";
            this.pnl_encabezadoRelevamientoRA.Size = new System.Drawing.Size(880, 73);
            this.pnl_encabezadoRelevamientoRA.TabIndex = 1;
            // 
            // dtg_relevamientoTurno
            // 
            this.dtg_relevamientoTurno.AllowUserToAddRows = false;
            this.dtg_relevamientoTurno.AllowUserToDeleteRows = false;
            this.dtg_relevamientoTurno.AllowUserToResizeColumns = false;
            this.dtg_relevamientoTurno.AllowUserToResizeRows = false;
            this.dtg_relevamientoTurno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_relevamientoTurno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtg_relevamientoTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_relevamientoTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turnos,
            this.nivel});
            this.dtg_relevamientoTurno.Location = new System.Drawing.Point(530, 106);
            this.dtg_relevamientoTurno.Name = "dtg_relevamientoTurno";
            this.dtg_relevamientoTurno.RowHeadersVisible = false;
            this.dtg_relevamientoTurno.Size = new System.Drawing.Size(203, 317);
            this.dtg_relevamientoTurno.TabIndex = 2;
            // 
            // lbl_encabezadoRA
            // 
            this.lbl_encabezadoRA.AutoSize = true;
            this.lbl_encabezadoRA.BackColor = System.Drawing.Color.Transparent;
            this.lbl_encabezadoRA.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_encabezadoRA.Location = new System.Drawing.Point(282, 19);
            this.lbl_encabezadoRA.Name = "lbl_encabezadoRA";
            this.lbl_encabezadoRA.Size = new System.Drawing.Size(306, 36);
            this.lbl_encabezadoRA.TabIndex = 0;
            this.lbl_encabezadoRA.Text = "Relevamiento Anual";
            // 
            // caracterizacion
            // 
            this.caracterizacion.FillWeight = 152.2843F;
            this.caracterizacion.HeaderText = "Discapacidad / Trastorno";
            this.caracterizacion.Name = "caracterizacion";
            this.caracterizacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // femenino
            // 
            this.femenino.FillWeight = 73.85786F;
            this.femenino.HeaderText = "Mujer";
            this.femenino.Name = "femenino";
            this.femenino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // masculino
            // 
            this.masculino.FillWeight = 73.85786F;
            this.masculino.HeaderText = "Varón";
            this.masculino.Name = "masculino";
            this.masculino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // turnos
            // 
            this.turnos.HeaderText = "TURNOS";
            this.turnos.Name = "turnos";
            this.turnos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nivel
            // 
            this.nivel.HeaderText = "Nivel Inicial";
            this.nivel.Name = "nivel";
            this.nivel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_regresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(0, 449);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(880, 81);
            this.btn_regresar.TabIndex = 5;
            this.btn_regresar.Tag = "reportes";
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // frm_relevamientoRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.dtg_relevamientoTurno);
            this.Controls.Add(this.pnl_encabezadoRelevamientoRA);
            this.Controls.Add(this.dtg_relevamientoCaracterizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_relevamientoRA";
            this.Text = "frm_relevamientoRA";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_relevamientoCaracterizacion)).EndInit();
            this.pnl_encabezadoRelevamientoRA.ResumeLayout(false);
            this.pnl_encabezadoRelevamientoRA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_relevamientoTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_relevamientoCaracterizacion;
        private System.Windows.Forms.Panel pnl_encabezadoRelevamientoRA;
        private System.Windows.Forms.DataGridView dtg_relevamientoTurno;
        private System.Windows.Forms.Label lbl_encabezadoRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn caracterizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn femenino;
        private System.Windows.Forms.DataGridViewTextBoxColumn masculino;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
        private System.Windows.Forms.Button btn_regresar;
    }
}
namespace Interfaces
{
    partial class frm_administracionUsuarios
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
            this.btn_verUsuarios = new System.Windows.Forms.Button();
            this.btn_agregarUsuarios = new System.Windows.Forms.Button();
            this.btn_modificarUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 152);
            this.panel1.TabIndex = 11;
            // 
            // btn_verUsuarios
            // 
            this.btn_verUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_verUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_verUsuarios.FlatAppearance.BorderSize = 0;
            this.btn_verUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verUsuarios.Location = new System.Drawing.Point(0, 314);
            this.btn_verUsuarios.Name = "btn_verUsuarios";
            this.btn_verUsuarios.Size = new System.Drawing.Size(880, 81);
            this.btn_verUsuarios.TabIndex = 14;
            this.btn_verUsuarios.Tag = "listaUsuarios";
            this.btn_verUsuarios.Text = "Ver Lista Docentes";
            this.btn_verUsuarios.UseVisualStyleBackColor = false;
            this.btn_verUsuarios.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_agregarUsuarios
            // 
            this.btn_agregarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_agregarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agregarUsuarios.FlatAppearance.BorderSize = 0;
            this.btn_agregarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarUsuarios.Location = new System.Drawing.Point(0, 233);
            this.btn_agregarUsuarios.Name = "btn_agregarUsuarios";
            this.btn_agregarUsuarios.Size = new System.Drawing.Size(880, 81);
            this.btn_agregarUsuarios.TabIndex = 13;
            this.btn_agregarUsuarios.Tag = "altaUsuarios";
            this.btn_agregarUsuarios.Text = "Agregar Docentes";
            this.btn_agregarUsuarios.UseVisualStyleBackColor = false;
            this.btn_agregarUsuarios.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_modificarUsuarios
            // 
            this.btn_modificarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.btn_modificarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_modificarUsuarios.FlatAppearance.BorderSize = 0;
            this.btn_modificarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarUsuarios.Location = new System.Drawing.Point(0, 152);
            this.btn_modificarUsuarios.Name = "btn_modificarUsuarios";
            this.btn_modificarUsuarios.Size = new System.Drawing.Size(880, 81);
            this.btn_modificarUsuarios.TabIndex = 12;
            this.btn_modificarUsuarios.Tag = "modificarUsuarios";
            this.btn_modificarUsuarios.Text = "Modificar Docentes";
            this.btn_modificarUsuarios.UseVisualStyleBackColor = false;
            this.btn_modificarUsuarios.Click += new System.EventHandler(this.btn_click);
            // 
            // frm_administracionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.btn_verUsuarios);
            this.Controls.Add(this.btn_agregarUsuarios);
            this.Controls.Add(this.btn_modificarUsuarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_administracionUsuarios";
            this.Text = "frm_administracionUsuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_verUsuarios;
        private System.Windows.Forms.Button btn_agregarUsuarios;
        private System.Windows.Forms.Button btn_modificarUsuarios;

    }
}
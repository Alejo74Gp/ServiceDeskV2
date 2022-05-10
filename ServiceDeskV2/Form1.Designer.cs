namespace ServiceDeskV2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Documento = new System.Windows.Forms.TextBox();
            this.Verificar = new System.Windows.Forms.Button();
            this.GtUsuarios = new System.Windows.Forms.Button();
            this.Incidente = new System.Windows.Forms.Button();
            this.GtIncidentes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento";
            // 
            // Documento
            // 
            this.Documento.Location = new System.Drawing.Point(788, 70);
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(170, 28);
            this.Documento.TabIndex = 2;
            // 
            // Verificar
            // 
            this.Verificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Verificar.BackgroundImage")));
            this.Verificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Verificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Verificar.Location = new System.Drawing.Point(762, 181);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(134, 51);
            this.Verificar.TabIndex = 4;
            this.Verificar.Text = "Verificar";
            this.Verificar.UseVisualStyleBackColor = true;
            this.Verificar.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // GtUsuarios
            // 
            this.GtUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GtUsuarios.BackgroundImage")));
            this.GtUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GtUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GtUsuarios.Location = new System.Drawing.Point(1102, 632);
            this.GtUsuarios.Name = "GtUsuarios";
            this.GtUsuarios.Size = new System.Drawing.Size(190, 45);
            this.GtUsuarios.TabIndex = 13;
            this.GtUsuarios.Text = "Gestionar usuarios";
            this.GtUsuarios.UseVisualStyleBackColor = true;
            this.GtUsuarios.Click += new System.EventHandler(this.GtUsuarios_Click);
            // 
            // Incidente
            // 
            this.Incidente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Incidente.BackgroundImage")));
            this.Incidente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Incidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Incidente.Location = new System.Drawing.Point(1361, 765);
            this.Incidente.Name = "Incidente";
            this.Incidente.Size = new System.Drawing.Size(190, 45);
            this.Incidente.TabIndex = 14;
            this.Incidente.Text = "Registrar incidente";
            this.Incidente.UseVisualStyleBackColor = true;
            this.Incidente.Visible = false;
            this.Incidente.Click += new System.EventHandler(this.Incidente_Click);
            // 
            // GtIncidentes
            // 
            this.GtIncidentes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GtIncidentes.BackgroundImage")));
            this.GtIncidentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GtIncidentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GtIncidentes.Location = new System.Drawing.Point(1361, 632);
            this.GtIncidentes.Name = "GtIncidentes";
            this.GtIncidentes.Size = new System.Drawing.Size(190, 45);
            this.GtIncidentes.TabIndex = 15;
            this.GtIncidentes.Text = "Gestionar incidentes";
            this.GtIncidentes.UseVisualStyleBackColor = true;
            this.GtIncidentes.Click += new System.EventHandler(this.GtIncidentes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Correo";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(134, 413);
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Size = new System.Drawing.Size(215, 28);
            this.Nombre.TabIndex = 19;
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(459, 413);
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Size = new System.Drawing.Size(215, 28);
            this.Apellido.TabIndex = 20;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(788, 413);
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Size = new System.Drawing.Size(239, 28);
            this.Correo.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1086, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Teléfono";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(1174, 413);
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Size = new System.Drawing.Size(235, 28);
            this.Telefono.TabIndex = 23;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(13, 13);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(43, 28);
            this.ID.TabIndex = 24;
            this.ID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1599, 886);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GtIncidentes);
            this.Controls.Add(this.Incidente);
            this.Controls.Add(this.GtUsuarios);
            this.Controls.Add(this.Verificar);
            this.Controls.Add(this.Documento);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Service Desk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Documento;
        private System.Windows.Forms.Button Verificar;
        private System.Windows.Forms.Button GtUsuarios;
        private System.Windows.Forms.Button Incidente;
        private System.Windows.Forms.Button GtIncidentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox ID;
    }
}
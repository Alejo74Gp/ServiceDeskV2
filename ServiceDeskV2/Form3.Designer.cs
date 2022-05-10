namespace ServiceDeskV2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Problema = new System.Windows.Forms.RichTextBox();
            this.AccionesTomadas = new System.Windows.Forms.RichTextBox();
            this.Prediagnosticos = new System.Windows.Forms.RichTextBox();
            this.Motivo = new System.Windows.Forms.ComboBox();
            this.TipoIncidente = new System.Windows.Forms.ComboBox();
            this.GtMotivos = new System.Windows.Forms.Button();
            this.GtTipos = new System.Windows.Forms.Button();
            this.Generar = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Estado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Prioridad = new System.Windows.Forms.TextBox();
            this.Id_Motivosolicitud = new System.Windows.Forms.TextBox();
            this.Id_Tipoincidente = new System.Windows.Forms.TextBox();
            this.Id_Estado = new System.Windows.Forms.TextBox();
            this.Id_incidente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de incidente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(954, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prioridad ( 1 - 5 )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 755);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Acciones tomadas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(793, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Prediagnostico";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(793, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Motivo de solicitud";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Problema";
            // 
            // Problema
            // 
            this.Problema.Location = new System.Drawing.Point(249, 64);
            this.Problema.Name = "Problema";
            this.Problema.Size = new System.Drawing.Size(492, 264);
            this.Problema.TabIndex = 10;
            this.Problema.Text = "";
            // 
            // AccionesTomadas
            // 
            this.AccionesTomadas.Location = new System.Drawing.Point(249, 405);
            this.AccionesTomadas.Name = "AccionesTomadas";
            this.AccionesTomadas.Size = new System.Drawing.Size(492, 287);
            this.AccionesTomadas.TabIndex = 11;
            this.AccionesTomadas.Text = "";
            // 
            // Prediagnosticos
            // 
            this.Prediagnosticos.Location = new System.Drawing.Point(948, 191);
            this.Prediagnosticos.Name = "Prediagnosticos";
            this.Prediagnosticos.Size = new System.Drawing.Size(465, 228);
            this.Prediagnosticos.TabIndex = 12;
            this.Prediagnosticos.Text = "";
            // 
            // Motivo
            // 
            this.Motivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Motivo.FormattingEnabled = true;
            this.Motivo.Location = new System.Drawing.Point(950, 64);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(347, 28);
            this.Motivo.TabIndex = 13;
            // 
            // TipoIncidente
            // 
            this.TipoIncidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TipoIncidente.FormattingEnabled = true;
            this.TipoIncidente.Location = new System.Drawing.Point(985, 587);
            this.TipoIncidente.Name = "TipoIncidente";
            this.TipoIncidente.Size = new System.Drawing.Size(385, 28);
            this.TipoIncidente.TabIndex = 15;
            this.TipoIncidente.SelectedIndexChanged += new System.EventHandler(this.TipoIncidente_SelectedIndexChanged);
            // 
            // GtMotivos
            // 
            this.GtMotivos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GtMotivos.BackgroundImage")));
            this.GtMotivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GtMotivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GtMotivos.Location = new System.Drawing.Point(1330, 55);
            this.GtMotivos.Name = "GtMotivos";
            this.GtMotivos.Size = new System.Drawing.Size(150, 45);
            this.GtMotivos.TabIndex = 16;
            this.GtMotivos.Text = "Gestionar motivos";
            this.GtMotivos.UseVisualStyleBackColor = true;
            // 
            // GtTipos
            // 
            this.GtTipos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GtTipos.BackgroundImage")));
            this.GtTipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GtTipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GtTipos.Location = new System.Drawing.Point(1394, 575);
            this.GtTipos.Name = "GtTipos";
            this.GtTipos.Size = new System.Drawing.Size(150, 45);
            this.GtTipos.TabIndex = 17;
            this.GtTipos.Text = "Gestionar tipos";
            this.GtTipos.UseVisualStyleBackColor = true;
            this.GtTipos.Click += new System.EventHandler(this.GtTipos_Click);
            // 
            // Generar
            // 
            this.Generar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Generar.BackgroundImage")));
            this.Generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Generar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generar.Location = new System.Drawing.Point(1330, 755);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(150, 45);
            this.Generar.TabIndex = 18;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // Fecha
            // 
            this.Fecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fecha.Enabled = false;
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha.Location = new System.Drawing.Point(249, 755);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(156, 28);
            this.Fecha.TabIndex = 22;
            // 
            // Estado
            // 
            this.Estado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Estado.FormattingEnabled = true;
            this.Estado.Location = new System.Drawing.Point(985, 650);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(385, 28);
            this.Estado.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(875, 658);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Estado";
            // 
            // Prioridad
            // 
            this.Prioridad.Location = new System.Drawing.Point(1097, 499);
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.Size = new System.Drawing.Size(135, 28);
            this.Prioridad.TabIndex = 25;
            // 
            // Id_Motivosolicitud
            // 
            this.Id_Motivosolicitud.Location = new System.Drawing.Point(12, 112);
            this.Id_Motivosolicitud.Name = "Id_Motivosolicitud";
            this.Id_Motivosolicitud.Size = new System.Drawing.Size(51, 28);
            this.Id_Motivosolicitud.TabIndex = 26;
            this.Id_Motivosolicitud.Visible = false;
            // 
            // Id_Tipoincidente
            // 
            this.Id_Tipoincidente.Location = new System.Drawing.Point(12, 146);
            this.Id_Tipoincidente.Name = "Id_Tipoincidente";
            this.Id_Tipoincidente.Size = new System.Drawing.Size(51, 28);
            this.Id_Tipoincidente.TabIndex = 27;
            this.Id_Tipoincidente.Visible = false;
            // 
            // Id_Estado
            // 
            this.Id_Estado.Location = new System.Drawing.Point(12, 180);
            this.Id_Estado.Name = "Id_Estado";
            this.Id_Estado.Size = new System.Drawing.Size(51, 28);
            this.Id_Estado.TabIndex = 28;
            this.Id_Estado.Visible = false;
            // 
            // Id_incidente
            // 
            this.Id_incidente.Location = new System.Drawing.Point(12, 214);
            this.Id_incidente.Name = "Id_incidente";
            this.Id_incidente.Size = new System.Drawing.Size(51, 28);
            this.Id_incidente.TabIndex = 29;
            this.Id_incidente.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 863);
            this.Controls.Add(this.Id_incidente);
            this.Controls.Add(this.Id_Estado);
            this.Controls.Add(this.Id_Tipoincidente);
            this.Controls.Add(this.Id_Motivosolicitud);
            this.Controls.Add(this.Prioridad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.GtTipos);
            this.Controls.Add(this.GtMotivos);
            this.Controls.Add(this.TipoIncidente);
            this.Controls.Add(this.Motivo);
            this.Controls.Add(this.Prediagnosticos);
            this.Controls.Add(this.AccionesTomadas);
            this.Controls.Add(this.Problema);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Service Desk";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox Problema;
        private System.Windows.Forms.RichTextBox AccionesTomadas;
        private System.Windows.Forms.RichTextBox Prediagnosticos;
        private System.Windows.Forms.ComboBox Motivo;
        private System.Windows.Forms.ComboBox TipoIncidente;
        private System.Windows.Forms.Button GtMotivos;
        private System.Windows.Forms.Button GtTipos;
        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Prioridad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Id_Motivosolicitud;
        private System.Windows.Forms.TextBox Id_Tipoincidente;
        private System.Windows.Forms.TextBox Id_Estado;
        private System.Windows.Forms.TextBox Id_incidente;
    }
}
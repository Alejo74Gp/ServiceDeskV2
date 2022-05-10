namespace ServiceDeskV2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumeroIncidente = new System.Windows.Forms.TextBox();
            this.PrioridadIncidente = new System.Windows.Forms.TextBox();
            this.ProblemaIncidente = new System.Windows.Forms.TextBox();
            this.EquipoIncidente = new System.Windows.Forms.TextBox();
            this.DocumentoUsuario = new System.Windows.Forms.TextBox();
            this.EstadoIncidente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "El número de incidente es el:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "La prioridad del incidente es:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "El problema registrado en el incidente es:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "El documento del usuario que reportó el incidente es:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "El equipo registrado en el incidente es:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "El estado del incidente es:";
            // 
            // NumeroIncidente
            // 
            this.NumeroIncidente.Location = new System.Drawing.Point(827, 57);
            this.NumeroIncidente.Name = "NumeroIncidente";
            this.NumeroIncidente.ReadOnly = true;
            this.NumeroIncidente.Size = new System.Drawing.Size(229, 28);
            this.NumeroIncidente.TabIndex = 7;
            // 
            // PrioridadIncidente
            // 
            this.PrioridadIncidente.Location = new System.Drawing.Point(827, 137);
            this.PrioridadIncidente.Name = "PrioridadIncidente";
            this.PrioridadIncidente.ReadOnly = true;
            this.PrioridadIncidente.Size = new System.Drawing.Size(229, 28);
            this.PrioridadIncidente.TabIndex = 8;
            // 
            // ProblemaIncidente
            // 
            this.ProblemaIncidente.Location = new System.Drawing.Point(827, 226);
            this.ProblemaIncidente.Name = "ProblemaIncidente";
            this.ProblemaIncidente.ReadOnly = true;
            this.ProblemaIncidente.Size = new System.Drawing.Size(229, 28);
            this.ProblemaIncidente.TabIndex = 9;
            // 
            // EquipoIncidente
            // 
            this.EquipoIncidente.Location = new System.Drawing.Point(827, 303);
            this.EquipoIncidente.Name = "EquipoIncidente";
            this.EquipoIncidente.ReadOnly = true;
            this.EquipoIncidente.Size = new System.Drawing.Size(229, 28);
            this.EquipoIncidente.TabIndex = 11;
            // 
            // DocumentoUsuario
            // 
            this.DocumentoUsuario.Location = new System.Drawing.Point(827, 388);
            this.DocumentoUsuario.Name = "DocumentoUsuario";
            this.DocumentoUsuario.ReadOnly = true;
            this.DocumentoUsuario.Size = new System.Drawing.Size(229, 28);
            this.DocumentoUsuario.TabIndex = 12;
            // 
            // EstadoIncidente
            // 
            this.EstadoIncidente.Location = new System.Drawing.Point(827, 478);
            this.EstadoIncidente.Name = "EstadoIncidente";
            this.EstadoIncidente.ReadOnly = true;
            this.EstadoIncidente.Size = new System.Drawing.Size(229, 28);
            this.EstadoIncidente.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(518, 646);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(669, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Una vez se le asigne un técnico se le enviará un correo electrónico al usuario qu" +
    "e reportó el incidente.\r\n";
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Salir.BackgroundImage")));
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Salir.Location = new System.Drawing.Point(1466, 802);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(100, 40);
            this.Salir.TabIndex = 15;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1608, 883);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EstadoIncidente);
            this.Controls.Add(this.DocumentoUsuario);
            this.Controls.Add(this.EquipoIncidente);
            this.Controls.Add(this.ProblemaIncidente);
            this.Controls.Add(this.PrioridadIncidente);
            this.Controls.Add(this.NumeroIncidente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Service Desk";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumeroIncidente;
        private System.Windows.Forms.TextBox PrioridadIncidente;
        private System.Windows.Forms.TextBox ProblemaIncidente;
        private System.Windows.Forms.TextBox EquipoIncidente;
        private System.Windows.Forms.TextBox DocumentoUsuario;
        private System.Windows.Forms.TextBox EstadoIncidente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Salir;
    }
}
namespace ServiceDeskV2
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.Usuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Documento = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Cargo = new System.Windows.Forms.ComboBox();
            this.GtCargos = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Crear = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuarios
            // 
            this.Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Usuarios.Location = new System.Drawing.Point(77, 47);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(770, 788);
            this.Usuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1008, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1006, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1008, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1006, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1009, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1009, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1008, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cargo";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(1122, 184);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(121, 28);
            this.Nombre.TabIndex = 8;
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(1122, 271);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(121, 28);
            this.Apellido.TabIndex = 9;
            // 
            // Documento
            // 
            this.Documento.Location = new System.Drawing.Point(1122, 358);
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(121, 28);
            this.Documento.TabIndex = 10;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(1122, 444);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(121, 28);
            this.Correo.TabIndex = 11;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(1122, 528);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(121, 28);
            this.Telefono.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1122, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // Cargo
            // 
            this.Cargo.FormattingEnabled = true;
            this.Cargo.Location = new System.Drawing.Point(1122, 612);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(121, 28);
            this.Cargo.TabIndex = 14;
            // 
            // GtCargos
            // 
            this.GtCargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GtCargos.Location = new System.Drawing.Point(1333, 609);
            this.GtCargos.Name = "GtCargos";
            this.GtCargos.Size = new System.Drawing.Size(145, 33);
            this.GtCargos.TabIndex = 15;
            this.GtCargos.Text = "Gestionar cargos";
            this.GtCargos.UseVisualStyleBackColor = true;
            this.GtCargos.Click += new System.EventHandler(this.GtCargos_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Actualizar.BackgroundImage")));
            this.Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Actualizar.Location = new System.Drawing.Point(1055, 673);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(145, 33);
            this.Actualizar.TabIndex = 16;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Crear
            // 
            this.Crear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Crear.BackgroundImage")));
            this.Crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Crear.Location = new System.Drawing.Point(1055, 738);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(145, 33);
            this.Crear.TabIndex = 17;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Visible = false;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eliminar.BackgroundImage")));
            this.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eliminar.Location = new System.Drawing.Point(1055, 802);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(145, 33);
            this.Eliminar.TabIndex = 18;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 885);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.GtCargos);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Documento);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usuarios);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.Text = "Service Desk";
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Documento;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox Cargo;
        private System.Windows.Forms.Button GtCargos;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button Eliminar;
    }
}
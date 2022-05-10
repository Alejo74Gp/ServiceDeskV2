namespace ServiceDeskV2
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.Cargos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Crear = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cargos)).BeginInit();
            this.SuspendLayout();
            // 
            // Cargos
            // 
            this.Cargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cargos.Location = new System.Drawing.Point(67, 55);
            this.Cargos.Name = "Cargos";
            this.Cargos.Size = new System.Drawing.Size(724, 783);
            this.Cargos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1047, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1065, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(1163, 124);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(150, 28);
            this.Nombre.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(1163, 243);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(150, 28);
            this.ID.TabIndex = 4;
            // 
            // Actualizar
            // 
            this.Actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Actualizar.BackgroundImage")));
            this.Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Actualizar.Location = new System.Drawing.Point(1181, 460);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(120, 37);
            this.Actualizar.TabIndex = 5;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Crear
            // 
            this.Crear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Crear.BackgroundImage")));
            this.Crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Crear.Location = new System.Drawing.Point(1181, 724);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(120, 37);
            this.Crear.TabIndex = 6;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Visible = false;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eliminar.BackgroundImage")));
            this.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eliminar.Location = new System.Drawing.Point(1181, 593);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(120, 37);
            this.Eliminar.TabIndex = 7;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Visible = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1597, 886);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cargos);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form11";
            this.Text = "Service Desk";
            ((System.ComponentModel.ISupportInitialize)(this.Cargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Cargos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button Eliminar;
    }
}
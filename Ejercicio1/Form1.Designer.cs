namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.btnDir = new System.Windows.Forms.Button();
            this.listDirectorio = new System.Windows.Forms.ListBox();
            this.listFicheros = new System.Windows.Forms.ListBox();
            this.lblSubdirectorios = new System.Windows.Forms.Label();
            this.lblFicheros = new System.Windows.Forms.Label();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Location = new System.Drawing.Point(12, 76);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.Size = new System.Drawing.Size(368, 20);
            this.txtDirectorio.TabIndex = 0;
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(12, 116);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(368, 34);
            this.btnDir.TabIndex = 1;
            this.btnDir.Text = "Boton directorio";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // listDirectorio
            // 
            this.listDirectorio.FormattingEnabled = true;
            this.listDirectorio.Location = new System.Drawing.Point(438, 76);
            this.listDirectorio.Name = "listDirectorio";
            this.listDirectorio.Size = new System.Drawing.Size(227, 316);
            this.listDirectorio.TabIndex = 2;
            this.listDirectorio.SelectedIndexChanged += new System.EventHandler(this.listDirectorio_SelectedIndexChanged);
            // 
            // listFicheros
            // 
            this.listFicheros.FormattingEnabled = true;
            this.listFicheros.Location = new System.Drawing.Point(726, 76);
            this.listFicheros.Name = "listFicheros";
            this.listFicheros.Size = new System.Drawing.Size(240, 316);
            this.listFicheros.TabIndex = 3;
            this.listFicheros.SelectedIndexChanged += new System.EventHandler(this.listFicheros_SelectedIndexChanged);
            // 
            // lblSubdirectorios
            // 
            this.lblSubdirectorios.AutoSize = true;
            this.lblSubdirectorios.Location = new System.Drawing.Point(435, 60);
            this.lblSubdirectorios.Name = "lblSubdirectorios";
            this.lblSubdirectorios.Size = new System.Drawing.Size(77, 13);
            this.lblSubdirectorios.TabIndex = 4;
            this.lblSubdirectorios.Text = "Subdirectorios:";
            // 
            // lblFicheros
            // 
            this.lblFicheros.AutoSize = true;
            this.lblFicheros.Location = new System.Drawing.Point(726, 60);
            this.lblFicheros.Name = "lblFicheros";
            this.lblFicheros.Size = new System.Drawing.Size(47, 13);
            this.lblFicheros.TabIndex = 5;
            this.lblFicheros.Text = "Ficheros";
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Location = new System.Drawing.Point(726, 416);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(46, 13);
            this.lblTamaño.TabIndex = 6;
            this.lblTamaño.Text = "Tamaño";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 441);
            this.Controls.Add(this.lblTamaño);
            this.Controls.Add(this.lblFicheros);
            this.Controls.Add(this.lblSubdirectorios);
            this.Controls.Add(this.listFicheros);
            this.Controls.Add(this.listDirectorio);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.txtDirectorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Archivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.ListBox listDirectorio;
        private System.Windows.Forms.Label lblSubdirectorios;
        private System.Windows.Forms.Label lblFicheros;
        private System.Windows.Forms.Label lblTamaño;
        public System.Windows.Forms.ListBox listFicheros;
    }
}


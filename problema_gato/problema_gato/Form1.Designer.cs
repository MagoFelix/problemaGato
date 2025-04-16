namespace problema_gato
{
    partial class Form1
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
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSalida = new System.Windows.Forms.Label();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtIni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(26, 43);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Inicio";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(26, 70);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(18, 13);
            this.lblFin.TabIndex = 1;
            this.lblFin.Text = "fin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Saltos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(26, 161);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(39, 13);
            this.lblSalida.TabIndex = 200;
            this.lblSalida.Text = "Salida:";
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(67, 70);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(100, 20);
            this.txtFin.TabIndex = 4;
            // 
            // txtIni
            // 
            this.txtIni.Location = new System.Drawing.Point(67, 36);
            this.txtIni.Name = "txtIni";
            this.txtIni.Size = new System.Drawing.Size(100, 20);
            this.txtIni.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtIni);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtIni;
    }
}


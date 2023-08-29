namespace PryCarreñoPOO
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.txtDestreza = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(186, 112);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(132, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear personaje";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtFuerza
            // 
            this.txtFuerza.Location = new System.Drawing.Point(186, 46);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(49, 20);
            this.txtFuerza.TabIndex = 1;
            // 
            // txtDestreza
            // 
            this.txtDestreza.Location = new System.Drawing.Point(186, 72);
            this.txtDestreza.Name = "txtDestreza";
            this.txtDestreza.Size = new System.Drawing.Size(49, 20);
            this.txtDestreza.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(136, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(136, 49);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(39, 13);
            this.lblFuerza.TabIndex = 5;
            this.lblFuerza.Text = "Fuerza";
            // 
            // lblDestreza
            // 
            this.lblDestreza.AutoSize = true;
            this.lblDestreza.Location = new System.Drawing.Point(136, 75);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(49, 13);
            this.lblDestreza.TabIndex = 6;
            this.lblDestreza.Text = "Destreza";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.lblDestreza);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblFuerza);
            this.groupBox1.Controls.Add(this.txtFuerza);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtDestreza);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(13, 160);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(494, 245);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 414);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.TextBox txtDestreza;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.Label lblDestreza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInfo;
    }
}


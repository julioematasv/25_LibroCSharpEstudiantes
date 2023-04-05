
namespace primerHolaLibro
{
    partial class FormSaludo
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.telefonoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hola Mundo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuario.Location = new System.Drawing.Point(339, 151);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(149, 29);
            this.nombreUsuario.TabIndex = 1;
            this.nombreUsuario.Text = "Julio Mata";
            this.nombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefonoUsuario
            // 
            this.telefonoUsuario.AutoSize = true;
            this.telefonoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefonoUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoUsuario.Location = new System.Drawing.Point(339, 247);
            this.telefonoUsuario.Name = "telefonoUsuario";
            this.telefonoUsuario.Size = new System.Drawing.Size(192, 31);
            this.telefonoUsuario.TabIndex = 2;
            this.telefonoUsuario.Text = "603 10 62 78";
            // 
            // FormSaludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.telefonoUsuario);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "FormSaludo";
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.Label telefonoUsuario;
    }
}


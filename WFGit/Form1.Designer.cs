﻿namespace WFGit
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSegundo = new System.Windows.Forms.Button();
            this.lblJuanito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(232, 205);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(186, 81);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnSegundo
            // 
            this.btnSegundo.Location = new System.Drawing.Point(530, 382);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(212, 112);
            this.btnSegundo.TabIndex = 1;
            this.btnSegundo.Text = "SEGUNDO";
            this.btnSegundo.UseVisualStyleBackColor = true;
            // 
            // lblJuanito
            // 
            this.lblJuanito.AutoSize = true;
            this.lblJuanito.Location = new System.Drawing.Point(105, 603);
            this.lblJuanito.Name = "lblJuanito";
            this.lblJuanito.Size = new System.Drawing.Size(116, 25);
            this.lblJuanito.TabIndex = 2;
            this.lblJuanito.Text = "Soy Juanito";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 722);
            this.Controls.Add(this.lblJuanito);
            this.Controls.Add(this.btnSegundo);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form1";
            this.Text = "Formulario de ejemplo modificado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.Label lblJuanito;
    }
}


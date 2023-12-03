namespace Practica_1_Tema_3_RMB_2324
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
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.textoLabel = new System.Windows.Forms.Label();
            this.costeLabel = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioBOrdinario = new System.Windows.Forms.RadioButton();
            this.radioBUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(106, 101);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(600, 158);
            this.txtTelegrama.TabIndex = 11;
            // 
            // textoLabel
            // 
            this.textoLabel.AutoSize = true;
            this.textoLabel.Location = new System.Drawing.Point(102, 68);
            this.textoLabel.Name = "textoLabel";
            this.textoLabel.Size = new System.Drawing.Size(48, 20);
            this.textoLabel.TabIndex = 9;
            this.textoLabel.Text = "Texto";
            // 
            // costeLabel
            // 
            this.costeLabel.AutoSize = true;
            this.costeLabel.Location = new System.Drawing.Point(95, 362);
            this.costeLabel.Name = "costeLabel";
            this.costeLabel.Size = new System.Drawing.Size(55, 20);
            this.costeLabel.TabIndex = 8;
            this.costeLabel.Text = "Coste:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(184, 356);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(157, 26);
            this.txtPrecio.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Coste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioBOrdinario
            // 
            this.radioBOrdinario.AutoSize = true;
            this.radioBOrdinario.Location = new System.Drawing.Point(106, 294);
            this.radioBOrdinario.Name = "radioBOrdinario";
            this.radioBOrdinario.Size = new System.Drawing.Size(98, 24);
            this.radioBOrdinario.TabIndex = 12;
            this.radioBOrdinario.TabStop = true;
            this.radioBOrdinario.Text = "Ordinario";
            this.radioBOrdinario.UseVisualStyleBackColor = true;
            // 
            // radioBUrgente
            // 
            this.radioBUrgente.AutoSize = true;
            this.radioBUrgente.Location = new System.Drawing.Point(232, 294);
            this.radioBUrgente.Name = "radioBUrgente";
            this.radioBUrgente.Size = new System.Drawing.Size(92, 24);
            this.radioBUrgente.TabIndex = 13;
            this.radioBUrgente.TabStop = true;
            this.radioBUrgente.Text = "Urgente";
            this.radioBUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioBUrgente);
            this.Controls.Add(this.radioBOrdinario);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.textoLabel);
            this.Controls.Add(this.costeLabel);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label textoLabel;
        private System.Windows.Forms.Label costeLabel;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioBOrdinario;
        private System.Windows.Forms.RadioButton radioBUrgente;
    }
}


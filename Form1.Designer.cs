namespace CRONOMETRO
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
            this.components = new System.ComponentModel.Container();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.BTNReiniciar = new System.Windows.Forms.Button();
            this.Tcronometro = new System.Windows.Forms.Timer(this.components);
            this.lblrecorrido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Red;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(24, 310);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(153, 43);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.Red;
            this.btnDetener.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetener.Location = new System.Drawing.Point(211, 310);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(162, 43);
            this.btnDetener.TabIndex = 1;
            this.btnDetener.Text = "DETENER";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // BTNReiniciar
            // 
            this.BTNReiniciar.BackColor = System.Drawing.Color.Red;
            this.BTNReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNReiniciar.Location = new System.Drawing.Point(392, 310);
            this.BTNReiniciar.Name = "BTNReiniciar";
            this.BTNReiniciar.Size = new System.Drawing.Size(162, 43);
            this.BTNReiniciar.TabIndex = 2;
            this.BTNReiniciar.Text = "REINICIAR";
            this.BTNReiniciar.UseVisualStyleBackColor = false;
            this.BTNReiniciar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tcronometro
            // 
            this.Tcronometro.Tick += new System.EventHandler(this.Tcronometro_Tick);
            // 
            // lblrecorrido
            // 
            this.lblrecorrido.AutoSize = true;
            this.lblrecorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecorrido.Location = new System.Drawing.Point(241, 128);
            this.lblrecorrido.Name = "lblrecorrido";
            this.lblrecorrido.Size = new System.Drawing.Size(70, 25);
            this.lblrecorrido.TabIndex = 3;
            this.lblrecorrido.Text = "Label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(595, 411);
            this.Controls.Add(this.lblrecorrido);
            this.Controls.Add(this.BTNReiniciar);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "CRONOMETRO";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button BTNReiniciar;
        private System.Windows.Forms.Timer Tcronometro;
        private System.Windows.Forms.Label lblrecorrido;
    }
}


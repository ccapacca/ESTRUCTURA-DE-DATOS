namespace semana7colas2
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
            this.LSTBOX = new System.Windows.Forms.ListBox();
            this.TXTINGRESARNOMBRE = new System.Windows.Forms.TextBox();
            this.ENCOLAR = new System.Windows.Forms.Button();
            this.DESENCOLAR = new System.Windows.Forms.Button();
            this.ELEMENTOS = new System.Windows.Forms.Button();
            this.DESTRUIR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LSTBOX
            // 
            this.LSTBOX.FormattingEnabled = true;
            this.LSTBOX.Location = new System.Drawing.Point(432, 183);
            this.LSTBOX.Name = "LSTBOX";
            this.LSTBOX.Size = new System.Drawing.Size(236, 212);
            this.LSTBOX.TabIndex = 0;
            // 
            // TXTINGRESARNOMBRE
            // 
            this.TXTINGRESARNOMBRE.Location = new System.Drawing.Point(432, 119);
            this.TXTINGRESARNOMBRE.Name = "TXTINGRESARNOMBRE";
            this.TXTINGRESARNOMBRE.Size = new System.Drawing.Size(236, 20);
            this.TXTINGRESARNOMBRE.TabIndex = 1;
            this.TXTINGRESARNOMBRE.TextChanged += new System.EventHandler(this.TXTINGRESARNOMBRE_TextChanged);
            this.TXTINGRESARNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTINGRESARNOMBRE_KeyPress);
            // 
            // ENCOLAR
            // 
            this.ENCOLAR.Location = new System.Drawing.Point(225, 172);
            this.ENCOLAR.Name = "ENCOLAR";
            this.ENCOLAR.Size = new System.Drawing.Size(184, 53);
            this.ENCOLAR.TabIndex = 2;
            this.ENCOLAR.Text = "ENCOLAR";
            this.ENCOLAR.UseVisualStyleBackColor = true;
            this.ENCOLAR.Click += new System.EventHandler(this.ENCOLAR_Click);
            // 
            // DESENCOLAR
            // 
            this.DESENCOLAR.Location = new System.Drawing.Point(225, 231);
            this.DESENCOLAR.Name = "DESENCOLAR";
            this.DESENCOLAR.Size = new System.Drawing.Size(184, 53);
            this.DESENCOLAR.TabIndex = 3;
            this.DESENCOLAR.Text = "DESENCOLAR";
            this.DESENCOLAR.UseVisualStyleBackColor = true;
            this.DESENCOLAR.Click += new System.EventHandler(this.DESENCOLAR_Click);
            // 
            // ELEMENTOS
            // 
            this.ELEMENTOS.Location = new System.Drawing.Point(225, 290);
            this.ELEMENTOS.Name = "ELEMENTOS";
            this.ELEMENTOS.Size = new System.Drawing.Size(184, 53);
            this.ELEMENTOS.TabIndex = 4;
            this.ELEMENTOS.Text = "# ELEMENTOS";
            this.ELEMENTOS.UseVisualStyleBackColor = true;
            this.ELEMENTOS.Click += new System.EventHandler(this.ELEMENTOS_Click);
            // 
            // DESTRUIR
            // 
            this.DESTRUIR.Location = new System.Drawing.Point(225, 349);
            this.DESTRUIR.Name = "DESTRUIR";
            this.DESTRUIR.Size = new System.Drawing.Size(184, 53);
            this.DESTRUIR.TabIndex = 5;
            this.DESTRUIR.Text = "DESTRUIR";
            this.DESTRUIR.UseVisualStyleBackColor = true;
            this.DESTRUIR.Click += new System.EventHandler(this.DESTRUIR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "INGRESAR NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "COLA(QUEUE)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DESTRUIR);
            this.Controls.Add(this.ELEMENTOS);
            this.Controls.Add(this.DESENCOLAR);
            this.Controls.Add(this.ENCOLAR);
            this.Controls.Add(this.TXTINGRESARNOMBRE);
            this.Controls.Add(this.LSTBOX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LSTBOX;
        private System.Windows.Forms.TextBox TXTINGRESARNOMBRE;
        private System.Windows.Forms.Button ENCOLAR;
        private System.Windows.Forms.Button DESENCOLAR;
        private System.Windows.Forms.Button ELEMENTOS;
        private System.Windows.Forms.Button DESTRUIR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


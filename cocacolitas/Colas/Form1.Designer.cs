namespace Colas
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
            this.lstbox = new System.Windows.Forms.ListBox();
            this.vercola = new System.Windows.Forms.Button();
            this.encolar = new System.Windows.Forms.Button();
            this.desencolar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.txtnuevo = new System.Windows.Forms.TextBox();
            this.txtmodifica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbox
            // 
            this.lstbox.FormattingEnabled = true;
            this.lstbox.Location = new System.Drawing.Point(71, 167);
            this.lstbox.Name = "lstbox";
            this.lstbox.Size = new System.Drawing.Size(137, 225);
            this.lstbox.TabIndex = 0;
            // 
            // vercola
            // 
            this.vercola.Location = new System.Drawing.Point(77, 105);
            this.vercola.Name = "vercola";
            this.vercola.Size = new System.Drawing.Size(130, 34);
            this.vercola.TabIndex = 1;
            this.vercola.Text = "ver cola";
            this.vercola.UseVisualStyleBackColor = true;
            this.vercola.Click += new System.EventHandler(this.vercola_Click);
            // 
            // encolar
            // 
            this.encolar.Location = new System.Drawing.Point(227, 203);
            this.encolar.Name = "encolar";
            this.encolar.Size = new System.Drawing.Size(130, 34);
            this.encolar.TabIndex = 2;
            this.encolar.Text = "encolar";
            this.encolar.UseVisualStyleBackColor = true;
            this.encolar.Click += new System.EventHandler(this.encolar_Click);
            // 
            // desencolar
            // 
            this.desencolar.Location = new System.Drawing.Point(227, 243);
            this.desencolar.Name = "desencolar";
            this.desencolar.Size = new System.Drawing.Size(130, 34);
            this.desencolar.TabIndex = 3;
            this.desencolar.Text = "desencolar";
            this.desencolar.UseVisualStyleBackColor = true;
            this.desencolar.Click += new System.EventHandler(this.desencolar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(227, 283);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(130, 34);
            this.modificar.TabIndex = 4;
            this.modificar.Text = "modiicar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // txtnuevo
            // 
            this.txtnuevo.Location = new System.Drawing.Point(322, 64);
            this.txtnuevo.Name = "txtnuevo";
            this.txtnuevo.Size = new System.Drawing.Size(141, 20);
            this.txtnuevo.TabIndex = 5;
            // 
            // txtmodifica
            // 
            this.txtmodifica.Location = new System.Drawing.Point(499, 64);
            this.txtmodifica.Name = "txtmodifica";
            this.txtmodifica.Size = new System.Drawing.Size(141, 20);
            this.txtmodifica.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "nuevo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "modifica";
            // 
            // contar
            // 
            this.contar.Location = new System.Drawing.Point(230, 332);
            this.contar.Name = "contar";
            this.contar.Size = new System.Drawing.Size(126, 25);
            this.contar.TabIndex = 9;
            this.contar.Text = "Contar";
            this.contar.UseVisualStyleBackColor = true;
            this.contar.Click += new System.EventHandler(this.contar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmodifica);
            this.Controls.Add(this.txtnuevo);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.desencolar);
            this.Controls.Add(this.encolar);
            this.Controls.Add(this.vercola);
            this.Controls.Add(this.lstbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox;
        private System.Windows.Forms.Button vercola;
        private System.Windows.Forms.Button encolar;
        private System.Windows.Forms.Button desencolar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.TextBox txtnuevo;
        private System.Windows.Forms.TextBox txtmodifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button contar;
    }
}


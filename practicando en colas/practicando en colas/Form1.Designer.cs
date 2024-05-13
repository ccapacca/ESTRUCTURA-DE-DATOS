namespace practicando_en_colas
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
            this.buttonencolar = new System.Windows.Forms.Button();
            this.buttondesencolar = new System.Windows.Forms.Button();
            this.buttonelementos = new System.Windows.Forms.Button();
            this.buttondestruir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttonmodificar = new System.Windows.Forms.Button();
            this.textBoxmodificar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonencolar
            // 
            this.buttonencolar.Location = new System.Drawing.Point(114, 169);
            this.buttonencolar.Name = "buttonencolar";
            this.buttonencolar.Size = new System.Drawing.Size(146, 56);
            this.buttonencolar.TabIndex = 0;
            this.buttonencolar.Text = "encolar";
            this.buttonencolar.UseVisualStyleBackColor = true;
            this.buttonencolar.Click += new System.EventHandler(this.buttonencolar_Click);
            // 
            // buttondesencolar
            // 
            this.buttondesencolar.Location = new System.Drawing.Point(114, 231);
            this.buttondesencolar.Name = "buttondesencolar";
            this.buttondesencolar.Size = new System.Drawing.Size(146, 56);
            this.buttondesencolar.TabIndex = 1;
            this.buttondesencolar.Text = "desencolar";
            this.buttondesencolar.UseVisualStyleBackColor = true;
            this.buttondesencolar.Click += new System.EventHandler(this.buttondesencolar_Click);
            // 
            // buttonelementos
            // 
            this.buttonelementos.Location = new System.Drawing.Point(114, 293);
            this.buttonelementos.Name = "buttonelementos";
            this.buttonelementos.Size = new System.Drawing.Size(146, 56);
            this.buttonelementos.TabIndex = 2;
            this.buttonelementos.Text = "# elementos";
            this.buttonelementos.UseVisualStyleBackColor = true;
            this.buttonelementos.Click += new System.EventHandler(this.buttonelementos_Click);
            // 
            // buttondestruir
            // 
            this.buttondestruir.Location = new System.Drawing.Point(114, 355);
            this.buttondestruir.Name = "buttondestruir";
            this.buttondestruir.Size = new System.Drawing.Size(146, 56);
            this.buttondestruir.TabIndex = 3;
            this.buttondestruir.Text = "destruir";
            this.buttondestruir.UseVisualStyleBackColor = true;
            this.buttondestruir.Click += new System.EventHandler(this.buttondestruir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(337, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 228);
            this.listBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ingresar datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "cola (queue)";
            this.label2.UseMnemonic = false;
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(592, 184);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(146, 47);
            this.buttonbuscar.TabIndex = 16;
            this.buttonbuscar.Text = "buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttonmodificar
            // 
            this.buttonmodificar.Location = new System.Drawing.Point(596, 242);
            this.buttonmodificar.Name = "buttonmodificar";
            this.buttonmodificar.Size = new System.Drawing.Size(141, 44);
            this.buttonmodificar.TabIndex = 17;
            this.buttonmodificar.Text = "Modificar";
            this.buttonmodificar.UseVisualStyleBackColor = true;
            this.buttonmodificar.Click += new System.EventHandler(this.buttonmodificar_Click);
            // 
            // textBoxmodificar
            // 
            this.textBoxmodificar.Location = new System.Drawing.Point(592, 110);
            this.textBoxmodificar.Name = "textBoxmodificar";
            this.textBoxmodificar.Size = new System.Drawing.Size(173, 22);
            this.textBoxmodificar.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxmodificar);
            this.Controls.Add(this.buttonmodificar);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttondestruir);
            this.Controls.Add(this.buttonelementos);
            this.Controls.Add(this.buttondesencolar);
            this.Controls.Add(this.buttonencolar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonencolar;
        private System.Windows.Forms.Button buttondesencolar;
        private System.Windows.Forms.Button buttonelementos;
        private System.Windows.Forms.Button buttondestruir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button buttonmodificar;
        private System.Windows.Forms.TextBox textBoxmodificar;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicando_en_colas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        colita cocacola = new colita();
        private void buttonencolar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ingrese un valor válido.");
                return;
            }
            cocacola.encolar(textBox1.Text);//aca usamos enconcola en textbox por que es donde vamos a escribir
            textBox1.Text = " ";//para limpiar el texbox
            textBox1.Focus();//para que se mantenga el cursor y no estar clicleando a cada rato
            listBox1.Items.Clear();//esto es paara limpiar el listbox
            cocacola.mostrar(listBox1);//esto muestra  los datos que quiero en mi listbox

        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {

            
                bool encontrado = cocacola.buscar(textBox1.Text);
                MessageBox.Show(encontrado ? "Valor encontrado" : "Valor no encontrado");
            

        }

        private void buttonmodificar_Click(object sender, EventArgs e)
        {
            cocacola.modificar(textBox1.Text, textBoxmodificar.Text);//
            textBox1.Text = " ";
            textBoxmodificar.Text = " ";
            listBox1.Items.Clear();
            cocacola.mostrar(listBox1);
        }

        private void buttondestruir_Click(object sender, EventArgs e)
        {
            cocacola.destruir();
            listBox1.Items.Clear();
        }

        private void buttonelementos_Click(object sender, EventArgs e)
        {
            cocacola.elementos();
        }

        private void buttondesencolar_Click(object sender, EventArgs e)
        {
            cocacola.desencolar();
            ActualizarListBox();


        }
        private void ActualizarListBox()
        {
            listBox1.Items.Clear();
            cocacola.mostrar(listBox1);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123)
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que se genere el sonido de "beep"
                cocacola.encolar(textBox1.Text);
                textBox1.Clear();
                ActualizarListBox();
            }
        }
    }
}

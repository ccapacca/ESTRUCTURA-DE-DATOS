using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semana7colas2
{
    public partial class Form1 : Form
    {
        COLAS micoli = new COLAS();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ENCOLAR_Click(object sender, EventArgs e)
        {
            if(TXTINGRESARNOMBRE.Text !="")
            {
                LSTBOX.Items.Clear();
                micoli.encolar(TXTINGRESARNOMBRE.Text);
                micoli.mostrar(LSTBOX);
                TXTINGRESARNOMBRE.Clear();
            }
        }

        private void DESENCOLAR_Click(object sender, EventArgs e)
        {
            micoli.desencolar();
            LSTBOX.Items.Clear();
            micoli.mostrar(LSTBOX);
        }

        private void ELEMENTOS_Click(object sender, EventArgs e)
        {
            micoli.elementos();
        }

        private void DESTRUIR_Click(object sender, EventArgs e)
        {
            micoli.destruir();
            LSTBOX.Items.Clear();

        }

        private void TXTINGRESARNOMBRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTINGRESARNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123)
            { 
                e.Handled=true;
                return;
            }

        }
    }
}

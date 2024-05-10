using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        cocacola colita=new cocacola();
        private void vercola_Click(object sender, EventArgs e)
        {
            lstbox.Items.Clear();
            colita.listadododelacola(lstbox);


        }

        private void encolar_Click(object sender, EventArgs e)
        {
            colita.encolar(int.Parse(txtnuevo.Text));
            txtnuevo.Text = "";
            txtnuevo.Focus();
        }

        private void desencolar_Click(object sender, EventArgs e)
        {
            colita.desencolar();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            colita.modificar(int.Parse(txtnuevo.Text),int.Parse(txtmodifica.Text));
            lstbox.Items.Clear();
            colita.listadododelacola(lstbox);
            txtnuevo.Text = "";
            txtnuevo.Focus();
            txtmodifica.Text = "";
            txtmodifica.Focus();
        }

        private void contar_Click(object sender, EventArgs e)
        {
            colita.contar();
        }
    }
}

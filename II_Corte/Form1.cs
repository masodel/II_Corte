using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace II_Corte
{
    public partial class Form1 : Form
    {
        new Queue<string> ColaRegular = new Queue<string>();
        new Stack<string> ColaUrgente = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void utileria()
        {
            tbNombre.Clear();
            tbNombre.Focus();
        }

        private void LlenarLista()
        {
            lbLista.Items.Clear();

            foreach (var item in ColaUrgente)
            {
                lbLista.Items.Add(item);
            }

            foreach (var item in ColaRegular)
            {
                lbLista.Items.Add(item);
            }

        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            ColaRegular.Enqueue(tbNombre.Text);
            LlenarLista();
            utileria();
        }

    }
}

using System;
using System.Windows.Forms;
using CNNOrdenadores;

namespace OrdenadorPresentacion
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            ListaOrdenador Compus = new ListaOrdenador();
            Compus.AgregarOrdenador(new Ordenador(230));
            Compus.AgregarOrdenador(new Ordenador(240));
            Compus.AgregarOrdenador(new Ordenador(250));
            Compus.AgregarOrdenador(new Ordenador(260));
            Compus.AgregarOrdenador(new Ordenador(270));
            lbOrdenadores.Items.Add(Compus.getListaOrdenador()); 

            
        }

        private void lbOrdenadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

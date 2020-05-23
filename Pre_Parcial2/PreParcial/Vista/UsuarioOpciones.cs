using System;
using System.Windows.Forms;
using ClaseGUI05.Modelo;

namespace ClaseGUI05
{
    public partial class UsuarioOpciones : Form
    {
        private Usuario u;
        public UsuarioOpciones(Usuario pUsuario)
        {
            InitializeComponent();
            u = pUsuario;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Realizar_pedidos ventana = new Realizar_pedidos(u);
            ventana.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerPedidosUsuario pedidos = new VerPedidosUsuario(u);
            pedidos.Show();
        }

        private void UsuarioOpciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
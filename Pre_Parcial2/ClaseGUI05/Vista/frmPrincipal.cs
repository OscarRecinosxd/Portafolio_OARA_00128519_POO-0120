using System;
using System.Windows.Forms;
using ClaseGUI05.Modelo;

namespace ClaseGUI05
{
    public partial class frmPrincipal : Form
    {
        private Usuario usuario;
        
        public frmPrincipal(Usuario pUsuario)
        {
            InitializeComponent();
            usuario = pUsuario;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = 
                "Bienvenido " + usuario.usuario + " [" + (usuario.admin ? "Administrador" : "Usuario") + "]";
        }
        

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
                 {
                     //Necesario porque el frmInicioSesion está escondido
                     //Application.Exit();
                 }

        private void button3_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioMantenimiento us = new UsuarioMantenimiento();
            us.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmInicioSesion us = new frmInicioSesion();
            this.Close();
            us.Show();
        }
    }
}
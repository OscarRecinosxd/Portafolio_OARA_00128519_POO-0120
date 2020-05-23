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

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, " + usuario.usuario + "?", 
                "Clase GUI 05", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    // No se pone el App.Exit() aquí porque volvería a llamar al evento
                    // form closing, ejecutando 2 veces el message box
                    e.Cancel = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha sucedido un error, favor intente dentro de un minuto.", 
                        "Clase GUI 05", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Necesario porque el frmInicioSesion está escondido
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MantenimientoUsuarios u = new MantenimientoUsuarios();
            u.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            MantenimientoStock u = new MantenimientoStock();
            u.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            PedidosTodos u = new PedidosTodos();
            u.Show();
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
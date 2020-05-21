using System;
using System.Windows.Forms;
using ClaseGUI05.Modelo;

namespace ClaseGUI05
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            poblarControles();
        }

        private void poblarControles()
        {
            // Actualizar ComboBox
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "contrasena";
            cmbUsuario.DisplayMember = "usuario";
            cmbUsuario.DataSource = UsuarioDAO.getLista();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedValue.Equals(txtContrasena.Text))
            {
                Usuario u = (Usuario) cmbUsuario.SelectedItem;

                MessageBox.Show("¡Bienvenido!",
                    "Clase GUI 05", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPrincipal ventana = new frmPrincipal(u);
                ventana.Show();
                this.Hide();
            }

            else MessageBox.Show("Contraseña incorrecta!");
        }


        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnIniciarSesion_Click(sender, e);
        }

        private void frmInicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
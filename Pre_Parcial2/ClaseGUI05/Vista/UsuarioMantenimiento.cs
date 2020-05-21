using System;
using System.Windows.Forms;
using ClaseGUI05.Modelo;

namespace ClaseGUI05
{
    public partial class UsuarioMantenimiento : Form
    {
        public UsuarioMantenimiento()
        {
            InitializeComponent();
            administrador1.Enabled= false;
            administrador1.Visible = false;
            modificarUsuario1.Enabled = false;
            modificarUsuario1.Visible = false;
            eliminarUsuario1.Enabled = false;
            eliminarUsuario1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            administrador1.Enabled= true;
            administrador1.Visible = true;
        }


        private void UsuarioMantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            //his.Close();
            //Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificarUsuario1.Enabled = true;
            modificarUsuario1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eliminarUsuario1.Enabled = true;
            eliminarUsuario1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmInicioSesion a = new frmInicioSesion();
            this.Close();
            a.Show();
        }
        
    }
}
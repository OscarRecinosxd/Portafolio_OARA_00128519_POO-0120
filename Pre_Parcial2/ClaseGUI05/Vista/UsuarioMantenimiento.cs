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
        }


        private void UsuarioMantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            //his.Close();
            //Application.Exit();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            frmInicioSesion a = new frmInicioSesion();
            this.Close();
            a.Show();
        }
        
    }
}
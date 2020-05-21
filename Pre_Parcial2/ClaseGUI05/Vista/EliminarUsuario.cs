using System;
using System.Windows.Forms;
using ClaseGUI05.Modelo;

namespace ClaseGUI05
{
    public partial class EliminarUsuario : UserControl
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = comboBox1.Text;

            if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("formato incorrecto");
            }
            else
            {
                Conexion.realizarAccion($"DELETE FROM USUARIO WHERE id_usuario = '{nombre}'");
                MessageBox.Show("usuario eliminado");
            }
        }
    }
}
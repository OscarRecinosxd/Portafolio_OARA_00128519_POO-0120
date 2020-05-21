using System;
using System.Windows.Forms;
using ClaseGUI05.Modelo;

namespace ClaseGUI05
{
    public partial class Administrador : UserControl
    {
        public Administrador()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
                MessageBox.Show("Error!");
            
            else{
                try
                {
                    string id_usuario = textBox1.Text;
                    string pass = textBox2.Text;
                    bool admi = checkBox1.Checked;

                    string sql = $"INSERT INTO USUARIO VALUES(" +
                                 $"'{id_usuario}'," +
                                 $"'{pass}'," +
                                 $"'{admi}')";
                    Conexion.realizarAccion(sql);
                    MessageBox.Show("Se agregó el usuario");

                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
            }
            

        }
    }
}
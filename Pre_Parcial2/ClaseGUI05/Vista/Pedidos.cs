using System;
using System.Windows.Forms;
using ClaseGUI05.Modelo;

namespace ClaseGUI05
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            try
            {
                var dt = Conexion.realizarConsulta("SELECT *FROM PEDIDOS");
                dataGridView1.DataSource = dt;
                MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void Pedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
using System.Windows.Forms;
using ClaseGUI05.Modelo;

namespace ClaseGUI05
{
    public partial class PedidosTodos : Form
    {
        public PedidosTodos()
        {
            InitializeComponent();
            cargar();
        }

        public void cargar()
        {
            var dt = Conexion.realizarConsulta($"SELECT *FROM PEDIDOS");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }
        
        
    }
}
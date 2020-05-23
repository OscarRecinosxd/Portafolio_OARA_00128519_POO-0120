using System;
using System.Windows.Forms;
using ClaseGUI05.Modelo;

namespace ClaseGUI05
{
    public partial class Realizar_pedidos : Form
    {
        private Usuario u;
        public Realizar_pedidos(Usuario pUsuario)
        {
            InitializeComponent();
            u = pUsuario;

        }


        private void poblar()
        {
            comboProductos.DataSource = null;
            comboProductos.DataSource = InventarioDAO.getNombresInventario();
        }

        private void Realizar_pedidos_Load(object sender, EventArgs e)
        {
            poblar();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string producto = comboProductos.Text;
            string usuario = u.usuario.ToString();
            int cantidad = Convert.ToInt32(numericCantidad.Text);

            try
            {
                Conexion.realizarAccion($"INSERT INTO PEDIDOS(producto, usuario, cantidad)" +
                                        $" VALUES (" +
                                        $"'{producto}'," +
                                        $"'{usuario}'," +
                                        $"{cantidad})");
                MessageBox.Show("Pedido agregado!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERROR");
            }
            
        }
    }
    
    
    
}
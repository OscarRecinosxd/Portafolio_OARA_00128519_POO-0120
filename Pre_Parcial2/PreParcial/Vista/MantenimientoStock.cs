using System;
using System.Windows.Forms;
using ClaseGUI05.Modelo;

namespace ClaseGUI05
{
    public partial class MantenimientoStock : Form
    {
        public MantenimientoStock()
        {
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreAgregar.Text;
                string descripcion = richTextDescripcionAgregar.Text;
                double precio = Convert.ToDouble(numericPrecioAgregar.Value);
                double cantidad=Convert.ToInt32(numericCantidadAgregar.Text);
            
                Conexion.realizarAccion($"INSERT INTO INVENTARIO VALUES(" +
                                        $"'{nombre}'," +
                                        $"'{descripcion}'," +
                                        $"{precio}," +
                                        $"{cantidad})");
                MessageBox.Show("Se ingreso correctamente");
                limpiarCajas();
                poblarCrearUsuario();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
                throw;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nombre = comboNombreEditar.Text;
            string descripcion = richTextEditar.Text;
            double precio = Convert.ToDouble(numericPrecioEditar.Text);
            int cantidad = Convert.ToInt32(numericCantidadEditar.Text);
            if (nombre.Equals("") || descripcion.Equals("") || precio <= 0 || cantidad < 0)
            {
                MessageBox.Show("Ingrese datos validos");
            }
            else {
                try
                {
                    Conexion.realizarAccion($"UPDATE INVENTARIO SET descripcion = '{descripcion}' ," +
                                            $" precio = {precio} , stock = {cantidad} WHERE nombre = '{nombre}' ");
                    MessageBox.Show("Stock editado");
                    limpiarCajas();
                    poblarCrearUsuario();
                
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error!");
                }}

        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = comboUsuarioEliminar.Text;
            try
            {
                Conexion.realizarAccion($"DELETE FROM INVENTARIO WHERE nombre ='{nombre}'");
            MessageBox.Show("Eliminado!");
            limpiarCajas();
            poblarCrearUsuario();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Algo salio mal...");
            }
            
        }
        
        public void poblarCrearUsuario()
        {
            // Actualizar ComboBox de Editar
            comboNombreEditar.DataSource = null;
            comboNombreEditar.DataSource = InventarioDAO.getNombresInventario();
            
            
            // Actualizar ComboBox de Eliminar
            comboUsuarioEliminar.DataSource = null;
            comboUsuarioEliminar.DataSource = InventarioDAO.getNombresInventario();
            
            
        }
        
        private void limpiarCajas()
        {
            txtNombreAgregar.Text = "";
            richTextDescripcionAgregar.Text = "";
            numericCantidadAgregar.Text = "";
            numericPrecioAgregar.Text = "";
            
            richTextEditar.Text = "";
            numericCantidadEditar.Text = "";
            numericPrecioEditar.Text = "";
            
            
            
        }

        private void MantenimientoStock_Load(object sender, EventArgs e)
        {
            poblarCrearUsuario();
        }
    }
}
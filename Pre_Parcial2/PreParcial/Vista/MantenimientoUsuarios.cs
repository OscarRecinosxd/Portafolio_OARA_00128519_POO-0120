using System;
using System.Windows.Forms;
using ClaseGUI05.Modelo;

namespace ClaseGUI05
{
    public partial class MantenimientoUsuarios : Form
    {
        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }


        public void poblarCrearUsuario()
        {
            // Actualizar ComboBox de Editar
            cmbEditarUsuario.DataSource = null;
            cmbEditarUsuario.DataSource = UsuarioDAO.getUsuarios();
            
            
            // Actualizar ComboBox de Eliminar
            cmbUsuarioEliminar.DataSource = null;
            cmbUsuarioEliminar.DataSource = UsuarioDAO.getUsuarios();
            
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtPassAgregar.Text.Equals("") || txtUsuarioAgregar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese datos validos");
            }
            else
            {
                try
                { 
                    string usuario = txtUsuarioAgregar.Text;
                    string pass = txtPassAgregar.Text;
                    bool admi = CheckAdmiAgregar.Checked;

                    Conexion.realizarAccion($"INSERT INTO USUARIO VALUES(" +
                                            $"'{usuario}' ,'{pass}' , {admi} )");
                    MessageBox.Show("Usuario agregado!");
                    limpiarCajas();
                    poblarCrearUsuario();
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void MantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            poblarCrearUsuario();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string usuario = cmbUsuarioEliminar.Text;
            Conexion.realizarAccion($"DELETE FROM USUARIO WHERE id_usuario = '{usuario}'");
            limpiarCajas();
            MessageBox.Show("Hecho!");
            poblarCrearUsuario();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassEditar.Text.Equals("") || cmbEditarUsuario.Text.Equals("") )
            {
                MessageBox.Show("Ingrese datos validos");
            }
            else
            {
                try
                {
                    string usuario = cmbEditarUsuario.Text;
                    string pass = txtPassEditar.Text;
                    bool admi = checkAdmiEditar.Checked;

                    Conexion.realizarAccion($"UPDATE USUARIO SET " +
                                            $" pass = '{pass}' , administrador = {admi} " +
                                            $" WHERE id_usuario = '{usuario}'");

                    limpiarCajas();
                    MessageBox.Show("Usuario editado!");
                    poblarCrearUsuario();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void limpiarCajas()
        {
            txtPassAgregar.Text = "";
            txtPassEditar.Text = "";
            txtUsuarioAgregar.Text = "";
            CheckAdmiAgregar.Checked = false;
            checkAdmiEditar.Checked = false;
        }
    }
}
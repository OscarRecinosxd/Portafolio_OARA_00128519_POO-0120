﻿using System.Windows.Forms;
using ClaseGUI05.Modelo;

namespace ClaseGUI05
{
    public partial class VerPedidosUsuario : Form
    {
        private Usuario u;
        public VerPedidosUsuario(Usuario pUsuario)
        {
            InitializeComponent();
            u = pUsuario;
            cargar();
        }

        private void cargar()
        {
            var dt = Conexion.realizarConsulta($"SELECT *FROM PEDIDOS" +
                                               $" WHERE usuario ='{u.usuario.ToString()}'");
            
            dataGridPedidosUsuario.DataSource = null;
            dataGridPedidosUsuario.DataSource = dt;
        }
    }
}
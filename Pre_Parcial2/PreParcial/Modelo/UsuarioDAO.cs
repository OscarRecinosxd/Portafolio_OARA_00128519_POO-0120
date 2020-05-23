using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ClaseGUI05.Modelo
{
    public static class UsuarioDAO
    {
        public static List<Usuario> getLista()
        {
            string sql = "select * from usuario";

            DataTable dt = Conexion.realizarConsulta(sql);

            List<Usuario> lista = new List<Usuario>();
            foreach (DataRow fila in dt.Rows)
            {
                Usuario u = new Usuario();
                u.usuario = fila[0].ToString();
                u.contrasena = fila[1].ToString();
                u.admin = Convert.ToBoolean(fila[2].ToString());

                lista.Add(u);
            }
            return lista;
        }
        
        public static List<string> getUsuarios()
        {
            string sql = "select id_usuario from usuario";
            string u = "";
            DataTable dt = Conexion.realizarConsulta(sql);
            
            List<string> lista = new List<string>();
            
            foreach (DataRow fila in dt.Rows)
            {
                u = fila[0].ToString();
                lista.Add(u);
            }
            return lista;
        }
        
        public static void seleccionar(ComboBox cb)
        {
            cb.Items.Clear();
            Conexion.realizarConsulta("SELECT *FROM USUARIO");
        }
        
    }
}
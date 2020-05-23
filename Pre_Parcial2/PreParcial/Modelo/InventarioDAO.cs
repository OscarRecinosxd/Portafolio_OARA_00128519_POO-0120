using System;
using System.Collections.Generic;
using System.Data;


namespace ClaseGUI05.Modelo
{

    public static class InventarioDAO
    {
    

    public static List<Inventario> getLista()
        {
            string sql = "SELECT *FROM INVENTARIO";

            DataTable dt = Conexion.realizarConsulta(sql);

            List<Inventario> lista = new List<Inventario>();
            foreach (DataRow fila in dt.Rows)
            {
                Inventario u = new Inventario();
                u.nombre = fila[0].ToString();
                u.descripcion = fila[1].ToString();
                u.precio = Convert.ToDouble((fila[2].ToString()));
                u.stock = Convert.ToInt32(fila[3].ToString());
                lista.Add(u);
            }
            return lista;
        }

        public static string getDescripcion(string nombre)
        {
            string sql = $"SELECT DESCRIPCION FROM INVENTARIO WHERE nombre ='{nombre}' ";
            string u="";
            DataTable dt = Conexion.realizarConsulta(sql);
            
            foreach (DataRow fila in dt.Rows)
            {
                u = fila[0].ToString();
            }

            return u;
        }
        
        public static List<string> getNombresInventario()
        {
            string sql = "SELECT nombre FROM INVENTARIO ";
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
        
    }
}
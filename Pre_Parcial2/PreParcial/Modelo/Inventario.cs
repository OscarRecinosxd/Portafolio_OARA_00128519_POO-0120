namespace ClaseGUI05.Modelo
{
    public class Inventario
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }

        public  Inventario()
        {
            nombre = "";
            descripcion = "";
            precio = 0;
            stock = 0;
        }
    }
}
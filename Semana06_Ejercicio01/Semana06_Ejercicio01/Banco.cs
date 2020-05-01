using System;

namespace Semana06_Ejercicio01
{


    public static class Banco
    {
        public static void registrarTarjeta()
        {
            Console.Write("Número de tarjeta: ");
            try
            {
                int pnumero = Convert.ToInt32(Console.ReadLine());
                string numero = Convert.ToString(pnumero);
                GestorArchivos.Anexar("Tarjetas.txt", numero);
                Console.WriteLine("Tarjeta creada exitosamente!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese una tarjeta válida");
            }
        }

        public static void consultarTarjetas()
        {
            Console.WriteLine(GestorArchivos.Leer("Tarjetas.txt"));
        }

        public static bool realizarCompras(string tarjeta)
        {
            return GestorArchivos.Buscar("Tarjetas.txt", tarjeta);
        }
    }
}
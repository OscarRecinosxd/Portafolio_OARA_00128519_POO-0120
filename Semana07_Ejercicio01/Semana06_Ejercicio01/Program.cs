using System;
using Semana06_Ejercicio01;

public class Program {
    static void Main() {
        bool continuar = true;
        do{
            Console.WriteLine(menu());
            int opcion = 0;
            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Dato inválido");
            }
            switch(opcion){
                case 1: Banco.registrarTarjeta(); break;
                case 2: Banco.consultarTarjetas(); break;
                case 3: ConsolaJuegos.comprarJuego(); break;
                case 4: ConsolaJuegos.jugar(); break;
                case 5: continuar = false; break;
            }
        }while(continuar);
        Console.WriteLine("\nTenga un buen día!");
    }
    
    static string menu(){
        return "\nBienvenido:\n" +
               "1) Registrar tarjeta (banco).\n" +
               "2) Consultar tarjetas (banco).\n" +
               "3) Comprar videojuego (consola).\n" +
               "4) Jugar videojuego (consola).\n" +
               "5) Salir.\n" + 
               "Opción elegida: \n";
    }
}
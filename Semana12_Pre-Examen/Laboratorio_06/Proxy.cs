using System;
using System.Collections.Generic;

namespace Laboratorio_06
{
    public class Proxy
    {
        

        public static class Nota
        {
            
            public static double peticion(List<Evaluacion> ev)
            {
                return CalcularNota.Calcular(ev);
            }

        }

        private static class CalcularNota
        {
            
            public static double Calcular(List<Evaluacion> ev)
            {
                double Nota = 0, Promedio = 0;
                
                foreach (var s in ev)
                {
                    Console.WriteLine("Ingrese la nota de " + s.Nombre);
                    Nota = Convert.ToDouble(Console.ReadLine());
                    Promedio += (Nota * ((s.Porcentaje) / 100.0));
                 
                }

                return Promedio;
            }
        }
    }
}
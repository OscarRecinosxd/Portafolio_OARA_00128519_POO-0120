package com.OARA.x00128519;

public class GeneradorISBN {
    private static int contador;

    private GeneradorISBN(){
      contador = 0;

    }

    public static int nuevoISBN(){
        contador =(int) (Math.random()*1000000+1);
        return contador;

    }
}

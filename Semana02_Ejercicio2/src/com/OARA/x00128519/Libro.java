package com.OARA.x00128519;

public class Libro {
   private int ISBN;
   private String nombre;
   private int paginas;

    public Libro(String nombre, int paginas){
        ISBN = GeneradorISBN.nuevoISBN();
        this.nombre = nombre;
        this.paginas = paginas;
    }


    public int getISBN() {
        return ISBN;
    }

    public String getNombre() {
        return nombre;
    }

    public int getPaginas() {
        return paginas;
    }

    @Override
    public String toString() {
        return "ISBN: "+ISBN +" nombre: "+nombre+" páginas: "+paginas;
    }


}

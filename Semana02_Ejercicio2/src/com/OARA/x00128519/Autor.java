package com.OARA.x00128519;

public class Autor {
    private String nombre;
    private String email;
    private char genero;

    public Autor(String nombre, String email, char genero) {
        this.nombre = nombre;
        this.email = email;
        this.genero = genero;
    }

    //Setter
    public void setEmail(String email) {
        this.email = email;
    }

    //Getters
    public String getNombre() {
        return nombre;
    }

    public String getEmail() {
        return email;
    }

    public char getGenero() {
        return genero;
    }

    @Override
    public String toString() {
        return "Nombre: " + nombre + " género: " + genero + " Email : "+ email;
    }
}

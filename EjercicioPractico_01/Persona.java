package com.OARA.x00128519;

public class Persona {
    //Atributos
    private int edad;
    private String nombre;
    private String Dui;

    //Constructores Sobrecargados
    public Persona (){
        edad = 0;
        nombre = "Persona";
        Dui = "00000000-0";
    }


    public Persona(int pEdad,String pNombre,String pDui) {
        edad = pEdad;
        nombre = pNombre;
        Dui=pDui;
    }


    //Metodos
    public void Saltar(int saltos){
        System.out.println(nombre + " Saltó "+ saltos +" veces");
    }
    public void Caminar(int km){
        System.out.println(nombre + " ha caminado "+km +" kilometros ");
    }
    public void Presentarse(){
        System.out.println("Hola soy "+nombre+ " y tengo "+edad +" años.");
    }


    //Setters
    public void setEdad(int edad) {
        this.edad = edad;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setDui(String dui) {
        Dui = dui;
    }

    //Getters
    public int getEdad() {
        return edad;
    }

    public String getNombre() {
        return nombre;
    }

    public String getDui() {
        return Dui;
    }


}

package com.OARA.x00128519;

public class Laptop {
    //Atributos
    private String Marca;
    private String Usuario;
    private int Bateria;

    //Constructores
    public Laptop(){
        Marca = "Marca";
        Usuario = "Usuario";
        Bateria = 100;
    }

    public Laptop(String pMarca, String pUsuario,int pBateria){
        Marca = pMarca;
        Usuario=pUsuario;
        Bateria=pBateria;
    }
    //Metodos

    public void Encender(){
        System.out.println("Encendiendo....");
        System.out.println("Encendida");
    }

    public void Apagar(){
        System.out.println("Apagando....");

    }

    public void Bateria(){
        System.out.println("El nivel de bateria esta en "+Bateria+"%");
    }

    //Setters
    public void setMarca(String marca) {
        Marca = marca;
    }

    public void setUsuario(String usuario) {
        Usuario = usuario;
    }

    public void setBateria(int bateria) {
        Bateria = bateria;
    }

    //Getters
    public String getMarca() {
        return Marca;
    }

    public String getUsuario() {
        return Usuario;
    }

    public int getBateria() {
        return Bateria;
    }
}

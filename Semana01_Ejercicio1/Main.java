package com.OARA.x00128519;

public class Main {

    public static void main(String[] args) {
        //Persona Construyendi
        Persona Persona1 = new Persona();
        Persona Persona2 = new Persona(18,"Oscar","12345678-9");
        Persona Persona3 = new Persona(40,"Chepe","87654321-9");
        //Metodos
        Persona2.Presentarse();
        Persona2.Saltar(20);
        Persona1.Caminar(5);

        System.out.println("----------------------------");

        //Laptop Construyendo
        Laptop Laptop1 = new Laptop();
        Laptop Laptop2 = new Laptop("HP", "Oscar",100);
        Laptop Laptop3 = new Laptop("ASUS", "Chepe",55);
        //Laptop metodos
        Laptop1.Encender();
        Laptop1.Bateria();
        Laptop1.Apagar();




    }
}

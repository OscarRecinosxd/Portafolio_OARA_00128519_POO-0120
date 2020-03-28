package com.OARA.x00128519;


import java.util.ArrayList;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        byte opcion = -1;
        byte opcion2 = -1;
        String AuxString ="";
        String AuxString2 ="";
        char AuxChar ;
        int AuxInt;
        Scanner in = new Scanner(System.in);
        ArrayList<Autor> Autores = new ArrayList<>();
        ArrayList<Libro> Libros = new ArrayList<>();

        do {
            opcion2 = 0;
            AuxString = "";
            AuxString2= "";
            AuxChar = 'a';
            AuxInt = 0;
            MenuPrincipal();
            opcion=in.nextByte(); in.nextLine();
            switch (opcion){
                case 1:
                    System.out.println("1. Agregar autor");
                    System.out.println("2. Agregar libro");
                    opcion2 = in.nextByte(); in.nextLine();
                    if(opcion2==1){
                        System.out.println("Ingrese su nombre "); AuxString = in.nextLine();
                        System.out.println("Ingrese su gmail ");  AuxString2 = in.nextLine();
                        System.out.println("Ingrese su género 'm' o 'f' "); AuxChar = in.next().charAt(0);
                        Autores.add(new Autor(AuxString,AuxString2,AuxChar));
                    }
                    else{
                        System.out.println("1. Ingrese su nombre"); AuxString = in.nextLine();
                        System.out.println("2. Ingrese número de páginas");AuxInt = in.nextInt(); in.nextLine();
                        Libros.add(new Libro(AuxString,AuxInt));
                    }
                    break;

                case 2:
                    System.out.println("1. Borrar autor");
                    System.out.println("2. Borrar libro");
                    opcion2 = in.nextByte(); in.nextLine();
                    if(opcion2==1){
                        System.out.println("Ingrese el nombre del autor para borrarlo ");
                        AuxString= in.nextLine();
                        String finalAux = AuxString;
                        Autores.removeIf(s -> {
                            return s.getNombre().equalsIgnoreCase(finalAux);
                        });
                    }
                    else{
                        System.out.println("Ingrese el nombre del libro para borrarlo ");
                        AuxString2= in.nextLine();
                        String finalAux2 = AuxString2;
                        System.out.println(finalAux2);
                        Libros.removeIf(s -> {
                             return s.getNombre().equalsIgnoreCase(finalAux2);
                        });
                    }
                    break;

                case 3:
                    System.out.println("1. Mostrar autores");
                    System.out.println("2. Mostrar libros");
                    opcion2 = in.nextByte(); in.nextLine();
                    if(opcion2==1){
                        Autores.forEach(s -> {
                            System.out.println(s);
                        });

                        }

                    else{
                        Libros.forEach(s -> {
                            System.out.println(s);
                        });

                    }   break;


                case 4: break;

                default:
                    System.out.println("Opcion inválida ");

            }


        }while (opcion!=4);

    }

    static void MenuPrincipal(){
        System.out.println("1: Agregar autores o libros");
        System.out.println("2: Quitar autores o libros");
        System.out.println("3: Mostrar autores o libros");
        System.out.println("4: Salir ");

    }


}

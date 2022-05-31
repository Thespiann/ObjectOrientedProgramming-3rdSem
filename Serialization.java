package com.myproject;
import java.io.*;
import java.util.Scanner;

public class Serialization {
    public static void main(String[] args) throws IOException, ClassNotFoundException {


        Animal Cow = new Animal();
        Cow.setCode("1234");
        Cow.setName("Qwerty");
        Cow.setAnimalClass("Mammal");
        Cow.setAnimalSpecies("Cow");
        Cow.setMass(150.20f);
        Cow.setAge(5);
        FileOutputStream fileOut = new FileOutputStream("myAnimal.ser");
        ObjectOutputStream out = new ObjectOutputStream(fileOut);
        out.writeObject(Cow);
        out.close();
        fileOut.close();


        Animal MyCow = null;
        FileInputStream fileIn = new FileInputStream("myAnimal.ser");
        ObjectInputStream in = new ObjectInputStream(fileIn);
        MyCow = (Animal) in.readObject();
        in.close();
        fileIn.close();
        System.out.println("I got all your info!");
        System.out.println("Name: " + MyCow.getName());
        System.out.println("Species: " + MyCow.getAnimalSpecies());
        System.out.println("Class: " + MyCow.getAnimalClass());
        System.out.println("Code: " + MyCow.getCode());
        System.out.println("Mass: " + MyCow.getMass());
        System.out.println("Max Age: " + MyCow.getAge());
    }

}

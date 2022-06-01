package com.myproject;
import java.util.*;
import java.io.*;

public class Serialize {
    private static int counter = 0;
    public static int getCounter(){return counter;}
    void RegisterAnimals() throws IOException {
        System.out.println("How many animals would you like to register?");
        Scanner sc = new Scanner(System.in);    //System.in is a standard input stream
        int howMany = sc.nextInt();
        System.out.println("Okay, " + howMany + " animal(s):");
        List<Animal> animals= new ArrayList<Animal>();

        for (int i = 1; i <= howMany; i++) {
            counter++;
            Animal newAnimal= new Animal();

            System.out.println("What is animal number " + i + "'s name?");
            String tempName = sc.next();
            newAnimal.setName(tempName);



            System.out.println("What is " + tempName+ "'s code?");
            String tempCode = sc.next();
            newAnimal.setCode(tempCode);


            System.out.println("What is " + tempName + "'s class?");
            String tempClass = sc.next();
            newAnimal.setAnimalClass(tempClass);


            System.out.println("What is " + tempName + "'s species?");
            String tempSpecies = sc.next();
            newAnimal.setAnimalSpecies(tempSpecies);


            System.out.println("What is " + tempName + "'s Mass?(in kg)");
            String tempMass = sc.next();
            newAnimal.setMass(tempMass);



            System.out.println("What is " + tempName + "'s approximate maximum age?");
            String tempAge = sc.next();
            newAnimal.setAge(tempAge);


            animals.add(newAnimal);

        }
        FileOutputStream fileOut = new FileOutputStream("newAnimal.ser");
        ObjectOutputStream out = new ObjectOutputStream(fileOut);
        out.writeObject(animals);
        out.close();
        fileOut.close();

    }
}

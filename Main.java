package com.myproject;

import java.util.*;
import static com.myproject.FileIO.writeMyAnimal;
import static com.myproject.FileIO.readMyAnimals;

public class Main {

    public static ArrayList<Animal> animals = new ArrayList<Animal>();//ημιουργω μια λιστα στην οποια θα αποθηκευσω τα παλιά ζωα

    public static void main(String[] args) {
        int action;
        Animal zoo = new Animal();//Δημιουργία αντικειμενου ζωων
        zoo.savedAnimals.addAll(readMyAnimals(animals));//Προσθετω στην saved animals του zoo τα παλια ζώα
        do {//Ρωταω τον χρηστη τι θελει να κανει
            System.out.println("Hello! What would you like to do?");
            System.out.println("1. Register new animals");
            System.out.println("2. Display registered animals");
            System.out.println("3. Delete an animal via its code");
            System.out.println("4. Search for an animal via its name");
            System.out.println("5. Search for an animal via its code");
            System.out.println("6. Edit animal info via its code");
            System.out.println("7. Learn about a random animal's class");
            System.out.println("8. Exit application");

            Scanner sc2 = new Scanner(System.in);
            action = sc2.nextInt();
            //Αναλογα την λειτουργία που επιλέγει εκτελω την αντιστοιχη διαδικασία
            if (action == 1) {//Αν θελει να εισάγει ζώα
                System.out.println("===Register new animals===");
                zoo.makeAnimal();//καλω την makeanimal
                System.out.println("Returning to menu");
            }
            if (action == 2) {//Αν θελει να προβαλλει τα αποθηκευμενα ζωα
                if (zoo.savedAnimals.size() == 0) {
                    System.out.println("Sorry, you haven't saved any animals!");
                }//Αν η λιστα με τα αποθηκευμενα ζώα ειναι κενη, δεν δειχνω ζωα
                else {//Αμα δεν ειναι κενη
                    System.out.println("""
                            These are your saved animals.
                             Keep in mind that if you haven't closed the program,
                             your animals haven't been saved""");
                    for (Animal i : zoo.savedAnimals) {
                        String s = i.toString();//Εκτυπωνω τις πληροφορίες καθε ζωου i απο την λιστα με τα αποθηκευμενα ζωα με την toString
                        System.out.println(s);
                    }
                    System.out.println("Returning to menu");
                }

            }
            if (action == 3) {//Αν θελει να διαγραψει ζωο με βαση τον κωδικό
                zoo.deleteAnimal();//Καλώ την συναρτηση διαγραφης
            }
            if (action == 4) {//Αν θελει να αναζητησει ζωο με βαση το όνομα
                zoo.searchByName();//Καλω την συναρτηση
            }
            if (action == 5) {
                zoo.searchByCode();
            }
            if (action == 6) {//Αν θέλει να αλλαξει κάποιο ζωο με βαση τον κωδικό
                zoo.editAnimal();
            }
            if (action == 7) {//Αν θελει να παρει πληροφοριες για την κλαση ενος τυχαιου ζωου
                zoo.randomClass();
            }
        }
            while (action != 8) ;//Αν διαλεξει να κλείσει το προγραμμα
            {
                writeMyAnimal(zoo);//Αποθηκευω τα ζωα και βγαινω απο την do
                System.out.println("Okay, now exiting");

            }
        }
    }

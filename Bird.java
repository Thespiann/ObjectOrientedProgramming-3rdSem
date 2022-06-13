package com.myproject;

public class Bird extends Animal implements AnimalActions {
    @Override
    public void learnAboutClass() {//Μέθοδος εκτύπωσης πληροφοριωνΚ της κλασης Bird, ομοιως για τις υπολοιπες κλασεις παιδια
        System.out.println("//////About Birds");
        System.out.println("Birds are a group of warm-blooded vertebrates characterised\n by feathers, toothless beaked jaws, the laying of hard-shelled eggs,\na high metabolic rate, a four-chambered heart, and a strong yet\n lightweight skeleton.");
    }
}

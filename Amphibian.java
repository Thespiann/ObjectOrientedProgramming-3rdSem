package com.myproject;


public class Amphibian extends Animal implements AnimalActions{
    @Override
    public void learnAboutClass() {
        System.out.println("//////About amphibians");
        System.out.println("Amphibian are small vertebrates that need water, or a moist environment, to survive.\n" +
                "\n" +
                "The species in this group include frogs, toads, salamanders, and newts.\nAll can breathe and absorb water through their very thin skin.\n" +
                "\n" +
                "Amphibian also have special skin glands that produce useful proteins.\n Some transport water, oxygen, and carbon dioxide either into or out of the animal.\nOthers fight bacteria or fungal infections. And at least\n one—in each species—is used for defense.");
    }
}

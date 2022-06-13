package com.myproject;

public class Reptile extends Animal implements AnimalActions{
    @Override
    public void learnAboutClass() {
        System.out.println("//////About Reptile");
        System.out.println("Reptile, like amphibians, make up a fairly small proportion of terrestrial \nanimals, but as dinosaurs they ruled the Earth for over 150 million years. \nThere are four basic types of reptiles: crocodiles and alligators; turtles and tortoises;\n snakes; and lizards. Reptile are characterized by their cold-blooded metabolisms—they fuel\n themselves by exposure to the sun—their scaly skin, and their leathery eggs,\n which they, unlike amphibians, can lay some distance from bodies of water.");

    }
}

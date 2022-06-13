package com.myproject;


public class Mammal extends Animal implements AnimalActions {
    @Override
    public void learnAboutClass() {
        System.out.println("//////About Mammals");
        System.out.println("It's natural for people to consider mammals the pinnacle of evolution. After all,\n humans are mammals, and so were our ancestors. But In fact, mammals are among \nthe least diverse animal groups: There are only about 5,000 species overall.\n Mammals are characterized by their hair or fur, which all species\n possess during some stage of their life cycles; the milk with which they suckle\n their young, and their warm-blooded metabolisms, which, as with birds, allows \nthem to inhabit a wide range of habitats, ranging from deserts to oceans to arctic tundra.");
    }
}

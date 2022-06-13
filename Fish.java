package com.myproject;

public class Fish extends Animal implements AnimalActions{
    @Override
    public void learnAboutClass() {
        System.out.println("//////About Fish");
        System.out.println("The first true vertebrates on Earth, fish evolved from invertebrate ancestors\n about 500 million years ago and have dominated the world's oceans, lakes, and rivers\n ever since. There are three main types of fish: bony fish, which includes such\n familiar species as tuna and salmon; cartilaginous fish, which includes sharks,\n rays, and skates; and jawless fish, a small family made up entirely of hagfish\n and lampreys). Fish breathe using gills and are equipped with \"lateral lines,\" \ninterconnected networks of receptors along the head and body that detect \nwater currents and even electricity.");

    }
}

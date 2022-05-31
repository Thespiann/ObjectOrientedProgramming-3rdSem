package com.myproject;
import java.io.*;
public class Animal implements Serializable{
    //μεταβλητές
    private String codeNum; //κωδικός ζωου
    private String animalName;//όνομα ζώου
    private String animalClass;//ομοταξία ζώου
    private String animalSpecies;// ειδος ζώου
    private float animalMass;// μάζα ζώου
    private int maxAge;//μεγιστη ηλικία

    //Setters και getters
    //για τον κωδικό-----------------
    public void setCode(String codeNum){
        this.codeNum= codeNum;
    }
    public String getCode(){
        return this.codeNum;
    }
    //για το όνομα-------------------
    public void setName(String animalName){
        this.animalName=animalName;
    }
    public String getName(){
        return this.animalName;
    }
    //για την ομοταξία--------------
    public void setAnimalClass(String animalClass){
        this.animalClass= animalClass;
    }
    public String getAnimalClass(){
        return this.animalClass;
    }
    //για το είδος--------------
    public void setAnimalSpecies(String animalSpecies){
        this.animalSpecies= animalSpecies;
    }
    public String getAnimalSpecies(){
        return this.animalSpecies;
    }
    //για την μάζα------------------
    public void setMass(float animalMass){
        this.animalMass= animalMass;
    }
    public float getMass(){
        return this.animalMass;
    }
    //για την μέγιστη ηλικία
    public void setAge(int maxAge){
        this.maxAge=maxAge;
    }
    public int getAge(){
        return this.maxAge;
    }



}

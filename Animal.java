package com.myproject;
import java.util.*;
import java.util.Scanner;

public  class Animal {
    //μεταβλητές
    private String codeNum; //κωδικός ζωου
    private String animalName;//όνομα ζώου
    private String animalClass;//ομοταξία ζώου
    private String animalSpecies;// ειδος ζώου
    private String animalMass;// μάζα ζώου
    private String maxAge;//μεγιστη ηλικία

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
    public void setMass(String animalMass){
        this.animalMass= animalMass;
    }
    public String getMass(){
        return this.animalMass;
    }
    //για την μέγιστη ηλικία
    public void setAge(String maxAge){
        this.maxAge=maxAge;
    }
    public String getAge(){
        return this.maxAge;
    }
    //σκανερ για εισοδο
    public Scanner sc1 = new Scanner(System.in);
    //λιστα στην οποια θα φορτώνω τα ζωα
    public ArrayList<Animal> savedAnimals= new ArrayList<>();

    //Μεθοδος αποθηκευσης δεδομένων σε string για εκτυπωση
    public String toString() {
        return "---------"+
        "\nClass: " + getAnimalClass()+
        "\nName: " +getName()+
        "\nSpecies: " +getAnimalSpecies()+
        "\nCode: " + getCode()+
        "\nMass: " + getMass()+" kg"+
        "\nMax Age: " +getAge()+" years\n";
    }

    //Μεθοδος αποθηκευσης δεδομένων σε string για αποθηκευση στο αρχειο
    public String toString2() {
        return  getAnimalClass()+
                "#" +getName()+
                "#" +getAnimalSpecies()+
                "#" +getCode()+
                "#" +getMass()+
                "#" +getAge()+"\n";
    }


    public void registerAnimal(Animal animal){//Μεθοδος ερωτησης για δεδομένα και εκχωρηση στις μεταβλητες
        System.out.println("What is the animal's name?");//Ερωτηση
        String tempName = sc1.next();//Αποθήκευση απαντησης στο string tempName
        animal.setName(tempName);//Xρήση setter για αποθήκευση του tempName ως ονομα του animal

        System.out.println("What is " + tempName+ "'s code?");
        String tempCode = sc1.next();//Ομοίως
        animal.setCode(tempCode);

        System.out.println("What is " + tempName + "'s species?");
        String tempSpecies = sc1.next();//Ομοίως
        animal.setAnimalSpecies(tempSpecies);

        System.out.println("What is " + tempName + "'s Mass?(in kg)");
        String tempMass = sc1.next();//Ομοίως
        animal.setMass(tempMass);

        System.out.println("What is " + tempName + "'s maximum age?");
        String tempAge = sc1.next();//Ομοίως
        animal.setAge(tempAge);

    }
    public void makeAnimal() {//Μέθοδος δημιουργίας συλλογης ζωων
        Scanner sc = new Scanner(System.in);
        System.out.println("How many animals would you like to register?");
        int howMany = sc.nextInt();//Αρχικοποιηση των ζωων που θελει ο χρηστης για το for loop μου
        System.out.println("Okay, " + howMany + " animal(s):");

        for (int i = 1; i <= howMany; i++) {
            System.out.println("Animal number " + i + ":");
            System.out.println("What is your animal's class?");//Ερωτηση για την κλάση ωστε να φτιάξω το σωστό παιδι της Animal
            System.out.println("For mammal type 1.\nFor bird type 2\nFor fish type 3\nFor reptile type 4\nFor amphibian type 5\n");
            int tempClass = sc.nextInt();

            if (tempClass == 1) {// Αν επέλεξε θηλαστικό
                Mammal myAnimal = new Mammal();//Φτιαχνω καινούριο αντικειμενο της mammal, η οποια ειναι παιδι της animal
                myAnimal.registerAnimal(myAnimal);//καλώ την μεθοδο που θα αρχικοποιησει τα δεδομενα της animal
                myAnimal.setAnimalClass("Mammal");//Ορίζω την κλαση
                savedAnimals.add(myAnimal);//Προσθέτω το αντικειμενο στην λίστα με τα υπολοιπα ζωα\

//Ομοίως για τις υπόλοιπες ομοταξίες

            }
            if (tempClass == 2) {
                Bird myAnimal = new Bird();
                myAnimal.registerAnimal(myAnimal);
                myAnimal.setAnimalClass("Bird");
                savedAnimals.add(myAnimal);
            }
            if (tempClass == 3) {
                Fish myAnimal = new Fish();
                myAnimal.registerAnimal(myAnimal);
                myAnimal.setAnimalClass("Fish");
                savedAnimals.add(myAnimal);
            }
            if (tempClass == 4) {
                Reptile myAnimal = new Reptile();
                myAnimal.registerAnimal(myAnimal);
                myAnimal.setAnimalClass("Reptile");
                savedAnimals.add(myAnimal);
            }
            if (tempClass == 5) {
                Amphibian myAnimal = new Amphibian();
                myAnimal.registerAnimal(myAnimal);
                myAnimal.setAnimalClass("Amphibian");
                savedAnimals.add(myAnimal);
            }

        }

    }

    public ArrayList<String> myAnimalString2() {//Μεθοδος που προσθέτει σε μια λίστα τα string του καθε ζωου για να τα αποθηκευσω στο αρχειο μου
        ArrayList<String> myAnimals = new ArrayList<>();
        for (Animal i : savedAnimals) {
            myAnimals.add(i.toString2());
        }
        return myAnimals;
    }
    public void deleteAnimal(){//Συναρτηση διαγραφης ζωου με βαση τον κωδικό
        int counter = 0;//Ενα counter για να καταλαβω αν δεν υπαρχει ζωο με τον κωδικό που δινεται
        System.out.println("What is the code of the animal for deletion?");
        Scanner sc3 = new Scanner(System.in);
        String codeToDelete = sc3.next();//Αποθηκευω τον κωδικο που ψαχνω
        for (Animal i :savedAnimals) {//Για καθε ζωο i που εχω αποθηκευσει
            if (codeToDelete.equals(i.getCode())) {//Εαν ο κωδικος του  ειναι ιδιος με αυτον που ψάχνω
                savedAnimals.remove(i);//Αφαιρω το i απο την λίστα
                System.out.println("I removed that animal!!\nReturning to menu.");
                break;//Σταματαω την αναζήτηση
            } else {
                counter++;//Αλλιώς αυξανω το counter
            }

        }
        if (counter == savedAnimals.size()) {//Αν το counter γινει το ιδιο με το μεγεθος της λίστας, τοτε δεν υπαρχει στοιχειο με αυτον τον κωδικό
            System.out.println("Sorry, i didnt find that animal!\nReturning to menu.");
        }
    }
    public void searchByName(){//Συνάρτηση αναζήτησης ζωου με βάση το ονομα
        int counter = 0;//Ενα counter για να καταλαβω αν δεν υπαρχει ζωο με τον κωδικό που δινεται
        System.out.println("What is the name of the animal you are searching for?");
        Scanner sc4 = new Scanner(System.in);
        String nameToSearch = sc4.next();//Αποθηκευω το ονομα που ψάχνω
        for (Animal i : savedAnimals) {//Για καθε ζωο i στα αποθηκευμενα ζωα
            if (nameToSearch.equals(i.getName())) {//Αν το ονομα που ψαχνω ειναι ιδιο με αυτο του ζωου
                System.out.println("I found that animal! Here is its info:");
                String s = i.toString();//Εκτυπωνω τις πληροφορίες του ζωου με την toString
                System.out.println(s);
                System.out.println("Returning to menu.");
                break;//Σταματαω την αναζήτηση
            }
            else {
                counter++;//Αλλιως αυξανω το counter
            }
        }
        if (counter == savedAnimals.size()) {//Αν το counter γινει το ιδιο με το μεγεθος της λίστας, τοτε δεν υπαρχει στοιχειο με αυτο το ονομα
            System.out.println("Sorry, i didnt find that animal!\nReturning to menu.");
        }
    }
    public void searchByCode(){
        int counter = 0;//Ομοιως με την searchByName
        System.out.println("What is the code of the animal you are searching for?");
        Scanner sc5 = new Scanner(System.in);
        String codeToSearch = sc5.next();
        for (Animal i : savedAnimals) {
            if (codeToSearch.equals(i.getCode())) {
                System.out.println("I found that animal! Here is its info:");
                String s = i.toString();
                System.out.println(s);
                System.out.println("Returning to menu.");
                break;
            } else {
                counter++;
            }

        }
        if (counter == savedAnimals.size()) {
            System.out.println("Sorry, i didnt find that animal!\nReturning to menu.");
        }
    }
    public void editAnimal(){
        int counter = 0;//Ενα counter για να καταλαβω αν δεν υπαρχει ζωο με τον κωδικό που δινεται
        System.out.println("What is the code of the animal whose info you want to change?");
        Scanner sc6 = new Scanner(System.in);
        String codeToEdit = sc6.next();//Αποθηκευση κωδικου που ψάχνω
        for (Animal i : savedAnimals) {//Για καθε ζωο i στα αποθηκευμενα ζωα
            Scanner scan = new Scanner(System.in);
            if (codeToEdit.equals(i.getCode())) {//Εαν ο κωδικος του  ειναι ιδιος με αυτον που ψάχνω
                System.out.println("I found that animal!");
                scan = new Scanner(System.in);
                //Ερωτησεις για αλλαγη των μεταβλητων
                System.out.println("What is the animal's name?");
                String tempName = scan.next();
                i.setName(tempName);

                System.out.println("What is " + i.getName() + "'s species?");
                String tempSpecies = scan.next();
                i.setAnimalSpecies(tempSpecies);

                System.out.println("What is " + i.getName() + "'s Mass?(in kg)");
                String tempMass = scan.next();
                i.setMass(tempMass);

                System.out.println("What is " + i.getName() + "'s max age?");
                String tempAge = scan.next();
                i.setAge(tempAge);
                break;//Σταματαω την αναζήτηση
            }
            else {
                counter++;//Αλλιώς αυξάνω το counter
            }

        }
        if (counter == savedAnimals.size()) {//Αν το counter γινει το ιδιο με το μεγεθος της λίστας, τοτε δεν υπαρχει στοιχειο με αυτον τον κωδικό
            System.out.println("Sorry, i didnt find that animal!\nReturning to menu.");
        }

    }
    public void randomClass(){//Μεθοδος εκτυπωσης πληροφοριων για μια τυχαια κλαση
        System.out.println("I'll choose a random animal and give you some info for its class!");
        if (savedAnimals.size() == 0) {//Εαν δεν εχω αποθηκευμενα ζωα δεν μπορω να παρω καποιο τυχαιο
            System.out.println("Sorry, you haven't saved any animals, so i cant choose!");
        } else {
            int random = new Random().nextInt(savedAnimals.size());//Διαλεγω εναν τυχαιο αριθμό random στο range ο μεγεθους του arraylist
            String myRandomClass = savedAnimals.get(random).getAnimalClass();//Παιρνω ενα string με την κλαση του ζωου που βρισκεται στην θεση random της λίστας
            if (myRandomClass.equals("Mammal")) {//Εαν είναι θηλαστικό
                Mammal rdm = new Mammal();//δημιουργω ενα κενό αντικειμενο της mammal και καλω τηn learnAboutClass()
                rdm.learnAboutClass();
            }
            if (myRandomClass.equals("Bird")) {
                Bird rdm = new Bird();
                rdm.learnAboutClass();
            }
            if (myRandomClass.equals("Fish")) {
                Fish rdm = new Fish();
                rdm.learnAboutClass();
            }
            if (myRandomClass.equals("Reptile")) {
                Reptile rdm = new Reptile();
                rdm.learnAboutClass();
            }
            if (myRandomClass.equals("Amphibian")) {
                Amphibian rdm = new Amphibian();
                rdm.learnAboutClass();
            }

        }

    }

}


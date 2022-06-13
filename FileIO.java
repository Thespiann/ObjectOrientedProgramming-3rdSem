package com.myproject;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.StringTokenizer;

public abstract class FileIO {
    public static void writeMyAnimal(Animal zoo) {//Μεθοδος αποθηκευσης των ζωων σε εγγραφο txt
        try {
            BufferedWriter bw = new BufferedWriter(new FileWriter("myFile"));//δημιουργία αντικειμενου buffered writer αι filewriter
            for (String i : zoo.myAnimalString2())//Για όλα τα string ζωων στο arrayList<string> myanimalstring2(δηλαδη τα string ολων των σωσμένων ζώων)
                bw.write(i);//Γράφω  το string στο εγγραφο
            bw.close();//Κλεινω το αρχείο
        } catch (Exception ex) {
            System.out.println("I couldn't write your file");//Αν δεν μπορω, πεταω exception
        }
    }

        public static ArrayList<Animal> readMyAnimals(ArrayList<Animal> animals){//Μεθοδος που διαβαζει τα αποθηκευμενα ζωα και επιστρεφει ενα arraylist με αυτα
            String line;
            StringTokenizer st;
            String token;
            Animal animal;
        try {
            BufferedReader br = new BufferedReader(new FileReader("myFile"));//Δημιουργία bufferdreader και  filereader
            line = br.readLine();//Διαβαζω την πρωτη γραμμή
            while (line != null) {//Οσο η γραμμη μου δεν ειναι κενή
                st = new StringTokenizer(line, "#");//Το token μου χωρίζεται απο "#"
                token = st.nextToken();//Παίρνω το πρώτο τοκεν
                if (token.equals("Mammal")) {//Εαν είναι θηλαστικό,δημιουργώ το αντικείμενο της mammal και χρησιμοποιω την makereadobj με τα παρακατω ορίσματα για να αρχικοποιησω τις μεταβλητες
                    animal = new Mammal();//upcasting
                    makeReadObj(animal,st,token,animals);
                }
                if (token.equals("Bird")) {
                    animal = new Bird();//Ομοίως
                    makeReadObj(animal,st,token,animals);
                }
                if (token.equals("Fish")) {
                    animal = new Fish();//Ομοίως
                    makeReadObj(animal,st,token,animals);
                }
                if (token.equals("Reptile")) {
                    animal = new Reptile();//Ομοίως
                    makeReadObj(animal,st,token,animals);
                }
                if (token.equals("Amphibian")) {
                    animal = new Amphibian();//Ομοίως
                    makeReadObj(animal,st,token,animals);
                }
                line = br.readLine();//Πρωχωρω στην επομενη γραμμη
            }
        } catch (Exception ex) {
            System.out.println("i couldn't read your file");//Εαν δεν μπορω πεταω exception
        }
        return animals;//Επιστρεφω την λίστα
    }

public static void makeReadObj(Animal animal, StringTokenizer st,String token,ArrayList<Animal> animals){
        animal.setAnimalClass(token);//Βαζω το πρώτο token ως κλαση του animal
        animal.setName(st.nextToken());//Θετω ως ονομα το επομενο τοκεν
        animal.setAnimalSpecies(st.nextToken());//Θετω ως είδος το επομενο τοκεν
        animal.setCode(st.nextToken());//Θετω ως κωδικό το επομενο τοκεν
        animal.setMass(st.nextToken());//Θετω ως βαρος το επομενο τοκεν
        animal.setAge(st.nextToken());//Θετω ως μεγιστη ηλικία το επομενο τοκεν
        animals.add(animal);//Προσθέτω στην λίστα το animal
    }
}

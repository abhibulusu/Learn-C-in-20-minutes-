using System;

class MainClass {  
    public static void Main (string[] args) {
        // go here kiddo: https://gist.github.com/topherPedersen/bf5ca7969ca9d9120f159eadb854d27d

        // Concept No. 1: FUNCTIONS & METHODS
        Console.WriteLine("Console.WriteLine is a method. Methods do things.");

        // Concept No. 2: VARIABLES
        string myVariable = "Variable are simply containers which hold values";
        Console.WriteLine(myVariable);

        // Concept No. 3: ARRAYS
        string[] myArray = {"Arrays", "are", "like", "variables", "but", "contain", "many", "values"};

        // Concept No. 5: LOOPS
        // Make a variable that stores the length of our Arrays
        int myArrayLength = myArray.Length;
        for (int i = 0; i < myArrayLength; i++) {
          Console.WriteLine(myArray[i]);
        }

        /*
        // Concept No. 3: ARRAYS
        // myArray = 


        // Concept No. 4: DATA TYPES
        "I am a string, a basic data type(human readable text used in a computer program";



        // Concept No. 5: LOOPS 
        



        // Concept No. 6: IF-STATEMENTS
        */
    }
}

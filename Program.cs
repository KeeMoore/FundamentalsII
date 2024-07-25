// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        // Three Basic Arrays
        int[] intArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // //Create an integer array with the values 0 through 9 inside
        string[] stringArray = { "Tim", "Martin", "Nikki", "Sara" }; // Create a string array with the names "Tim", "Martin", "Nikki", and "Sara
        bool[] boolArray = new bool[10]; // //Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true.
        for (int i = 0; i < boolArray.Length; i++) {
            boolArray[i] = i % 2 == 0;
        }

        // List of Flavors
        List<string> flavors = new List<string> { "Vanilla", "Chocolate", "Strawberry", "Cookies & Cream", "Cookie Dough" }; // Create a string List of ice cream flavors that holds at least 5 different flavors
        Console.WriteLine(flavors.Count); // Output: 5:Output the length of the List after you added the flavors
        Console.WriteLine(flavors[2]); // Output: Strawberry : Output the third flavor in the List
        flavors.RemoveAt(2); //Now remove the third flavor using its index location.
        Console.WriteLine(flavors.Count); // Output: 4  : Output the length of the List again.

        // User Dictionary
        Dictionary<string, string> userFlavors = new Dictionary<string, string>();
        Random rand = new Random();
        string[] names = { "Tim", "Martin", "Nikki", "Sara" };
        foreach (string name in names) {
            string randomFlavor = flavors[rand.Next(flavors.Count)];
            userFlavors[name] = randomFlavor;
        }
        foreach (var entry in userFlavors) {
            Console.WriteLine($"{entry.Key} likes {entry.Value} ice cream.");
        }
    }
}

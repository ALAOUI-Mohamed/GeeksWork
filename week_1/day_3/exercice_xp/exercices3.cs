using System;
using System.Collections.Generic;

//Exercice1: Convert Lists into Dictionaries
// class Exercice1
// {
//     static void Main(string[] args)
//     {
//         //Given lists
//         List<string> keys = new List<string> { "Ten", "Twenty", "Thirty" };
//         List<int> values = new List<int> { 10, 20, 30 };

//         //Creating a dictionary to hold the key-value pairs
//         Dictionary<string, int> dict = new Dictionary<string, int>();

//         //Iterating through the lists and adding to the dictionary
//         for (int i = 0; i < keys.Count; i++)
//         {
//             dict[keys[i]] = values[i];
//         }

//         //Printing the dictionary
//         Console.Write("{");
//         foreach (var kvp in dict)
//         {
//             Console.Write($"\"{kvp.Key}\": {kvp.Value}");
//             if (kvp.Key != keys[keys.Count - 1])
//             {
//                 Console.Write(", ");
//             }
//         }
//         Console.Write("}");
//     }
// }

//Exercice2: Cinemax #2
// class Exercice2
// {
//     static void Main(string[] args)
//     {
//         //Creating a dictionary to hold movie titles and their prices
//         // Dictionary<string, int> family = new Dictionary<string, int>
//         // {
//         //     {"rick", 43}, {"beth", 13}, {"morty", 5}, {"summer", 8}
//         // };
//         Console.WriteLine("Enter the family members and there age:");
//         Dictionary<string, int> family = new Dictionary<string, int>();

//         while (true)
//         {
//             Console.Write("Do you want to add a family member? (yes/no): ");
//             string? response = Console.ReadLine()?.ToLower();

//             if (response == "no")
//                 break;

//             if (response != "yes")
//             {
//                 Console.WriteLine("Please answer 'yes' or 'no'.");
//                 continue;
//             }

//             Console.Write("Enter the name of the family member: ");
//             string? name;

//             while (true)
//             {
//                 name = Console.ReadLine();

//                 if (!string.IsNullOrWhiteSpace(name))
//                     break;

//                 Console.Write("Name cannot be empty. Please enter a valid name: ");
//             }

//             Console.Write("Enter the age of the family member: ");
//             int age;

//             while (true)
//             {
//                 string? ageInput = Console.ReadLine();
//                 if (int.TryParse(ageInput, out age) && age >= 0)
//                     break;

//                 Console.Write("Please enter a valid non-negative integer for age: ");
//             }

//             family[name!] = age;
//         }

//         foreach (var member in family)
//         {
//             Console.WriteLine($"{member.Key}: {member.Value} years old");
//         }

//         int totalPrice = 0;
//         //Calculating the total price based on age
//         foreach (var member in family)
//         {
//             int age = member.Value;
//             int price = 0;

//             if (age < 3)
//             {
//                 price = 0;
//             }
//             else if (age >= 3 && age < 13)
//             {
//                 price = 10;
//             }
//             else
//             {
//                 price = 15;
//             }

//             totalPrice += price;
//         }
//         //Printing the total price
//         Console.WriteLine($"Total price for the family is: ${totalPrice} $");

//     }
// }
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

//Exercice3: Zara Brand Dictionary
// class Exercice3
// {
//     static void Main(string[] args)
//     {
//         var brand = new Dictionary<string, object>
// {
//     {"name", "Zara"},
//     {"creation_date", 1975},
//     {"creator_name", "Amancio Ortega Gaona"},
//     {"type_of_clothes", new List<string>{"men", "women", "children", "home"}},
//     {"international_competitors", new List<string>{"Gap", "H&M", "Benetton"}},
//     {"number_stores", 7000},
//     {"major_color", new Dictionary<string, List<string>>
//         {
//             {"France", new List<string>{"blue"}},
//             {"Spain", new List<string>{"red"}},
//             {"US", new List<string>{"pink", "green"}}
//         }
//     }
// };
//         //Adding a new key-value pair
//         brand["country_creation"] = "Spain";

//         //Updating the number of stores
//         brand["number_stores"] = 2;

//         //Explaining Zara's clients
//         var clothesTypes = (List<string>)brand["type_of_clothes"];
//         Console.WriteLine("Zara's clients are: " + string.Join(", ", (List<string>)brand["type_of_clothes"]));

//         //Checking if the key "international_competitors" exists and adding desigual
//         if (brand.ContainsKey("international_competitors"))
//         {
//             var competitors = (List<string>)brand["international_competitors"];
//             competitors.Add("Desigual");
//         }

//         //Removing the key "creation_date"
//         brand.Remove("creation_date");

//         //Printing the last international competitor
//         var internationalCompetitors = (List<string>)brand["international_competitors"];
//         Console.WriteLine("Last international competitor: " + internationalCompetitors[internationalCompetitors.Count - 1]);

//         //Printing the major colors in the US
//         var majorColors = (Dictionary<string, List<string>>)brand["major_color"];
//         var usColors = majorColors["US"];
//         Console.WriteLine("Major colors in the US: " + string.Join(", ", usColors));

//         //Printing the number of key-value pairs in the dictionary
//         Console.WriteLine("Number of key-value pairs in the brand dictionary: " + brand.Count);

//         //Printing all the keys in the dictionary
//         Console.WriteLine("Keys in the brand dictionary: " + string.Join(", ", brand.Keys));

//         //Merge another dictionary:
//         var more_on_zara = new Dictionary<string, object>
//         {
//             {"creation_date", 1975},
//             {"number_stores", 10000}
//         };
//         foreach (var kvp in more_on_zara)
//         {
//             brand[kvp.Key] = kvp.Value;
//         }

//         //Printing the updated number of stores
//         Console.WriteLine("Updated number of stores: " + brand["number_stores"]);

//         //Explaination:
//         //When merged, the existing keys were updated with the new values of the second dictionary
//     }
// }

//Exercice4: Some Geography
// void DescribeCity(string city, string country = "Iceland")
// {
//     Console.WriteLine($"{city} is in {country}.");
// }
// DescribeCity("Casablanca", "Morocco");
// DescribeCity("Paris", "France");
// DescribeCity("Seoul", "South Korea");

//Exercice5: Random Number Guess
// Console.WriteLine("Enter a number between 1 and 100:");
// int number = Convert.ToInt32(Console.ReadLine());
// Random rand = new Random();
// int randomNumber = rand.Next(1, 101);
// do
// {
//     Console.WriteLine("Wrong number, try again:");
//     number = Convert.ToInt32(Console.ReadLine());
// } while (number != randomNumber);
// Console.WriteLine("Congratulations! You guessed the correct number!");

//Exercice6: Personalized Shirts
// void MakeShirt(string size = "Large", string text = "I love C#")
// {
//     Console.WriteLine($"The size of the shirt is {size} and the text is '{text}'.");
// }
// //Shows the default values
// MakeShirt();

// //Customize the size of the Shirt
// MakeShirt("Large");
// MakeShirt("Medium");
// //Customize the size and the text of the Shirt
// MakeShirt("Fits All", "Soulframe incoming");
// //Bonus Customize in a random order
// MakeShirt(text: "Jump High", size: "Extra Small");

//Exercice7: Temperature Advice

// class Exercice7
// {
//     float GetRandomTemp(string season)
//     {
//         Random rnd = new Random();
//         float min = -10, max = 40;

//         if (season == "winter") { min = -10; max = 16; }
//         if (season == "spring") { min = 0; max = 23; }
//         if (season == "summer") { min = 16; max = 40; }
//         if (season == "autumn") { min = 0; max = 23; }

//         return (float)(rnd.NextDouble() * (max - min) + min);
//     }

//     static void Main(string[] args)
//     {
//         Exercice7 ex = new Exercice7();

//         // Console.Write("Enter the season (winter, spring, summer, autumn): ");
//         // string? season = Console.ReadLine()?.ToLower();

//         // Ask the user for month number and determine the season
//         Console.Write("Enter the month number (1-12): ");
//         int month;
//         while (true)
//         {
//             string? monthInput = Console.ReadLine();
//             if (int.TryParse(monthInput, out month) && month >= 1 && month <= 12)
//                 break;

//             Console.Write("Please enter a valid month number (1-12): ");
//         }
//         string? season = month switch
//         {
//             12 or 1 or 2 => "winter",
//             3 or 4 or 5 => "spring",
//             6 or 7 or 8 => "summer",
//             9 or 10 or 11 => "autumn",
//             _ => null
//         };

//         if (season != "winter" && season != "spring" && season != "summer" && season != "autumn")
//         {
//             Console.WriteLine("Invalid season entered.");
//             return;
//         }

//         float temp = ex.GetRandomTemp(season!);
//         Console.WriteLine($"The season is {season}");
//         Console.WriteLine($"The temperature is {temp}°C.");

//         if (temp < 0)
//             Console.WriteLine("Albeeeeerd a 3chirib! 3ane9 Manta");
//         else if (temp >= 0 && temp < 16)
//             Console.WriteLine("Kayn brrd chwya! Lbes sweatter wla jacket.");
//         else if (temp >= 16 && temp < 23)
//             Console.WriteLine("Ljaw mzyan! Khoud ra7tek");
//         else
//             Console.WriteLine("WAL7ARAAAAAAAAAAAAAAARAAAA");
//     }

// }

// Exercice8: Star Wars Quiz

// class Exercice8
// {
//     List<Dictionary<string, string>> data = new List<Dictionary<string, string>>
//     {
//         new Dictionary<string, string> { {"question", "What is Baby Yoda's real name?"}, {"answer", "Grogu"} },
//         new Dictionary<string, string> { {"question", "Where did Obi-Wan take Luke after his birth?"}, {"answer", "Tatooine"} },
//         new Dictionary<string, string> { {"question", "What year did the first Star Wars movie come out?"}, {"answer", "1977"} },
//         new Dictionary<string, string> { {"question", "Who built C-3PO?"}, {"answer", "Anakin Skywalker"} },
//         new Dictionary<string, string> { {"question", "Anakin Skywalker grew up to be who?"}, {"answer", "Darth Vader"} },
//         new Dictionary<string, string> { {"question", "What species is Chewbacca?"}, {"answer", "Wookiee"} }
//     };

//     public string AskQuestion(string question, string answer)
//     {
//         Console.WriteLine(question);
//         string? userAnswer = Console.ReadLine();

//         if (userAnswer != null && userAnswer.Equals(answer, StringComparison.OrdinalIgnoreCase))
//         {
//             Console.WriteLine("Correct!");
//             return "correct";
//         }
//         else
//         {
//             Console.WriteLine("Wrong!");
//             return userAnswer ?? "";
//         }
//     }

//     class WrongAnswer
//     {
//         public string Question { get; set; }
//         public string UserAnswer { get; set; }
//         public string CorrectAnswer { get; set; }
//     }

//     static void Main(string[] args)
//     {
//         List<WrongAnswer> wrongAnswers = new List<WrongAnswer>();
//         Exercice8 ex = new Exercice8();
//         int score = 0;

//         do
//         {
//             wrongAnswers.Clear();
//             score = 0;

//             foreach (var qa in ex.data)
//             {
//                 string result = ex.AskQuestion(qa["question"], qa["answer"]);
//                 if (result == "correct")
//                 {
//                     score++;
//                 }
//                 else
//                 {
//                     wrongAnswers.Add(new WrongAnswer
//                     {
//                         Question = qa["question"],
//                         UserAnswer = result,
//                         CorrectAnswer = qa["answer"]
//                     });
//                 }
//             }

//             Console.WriteLine("\nQuiz Over!");
//             Console.WriteLine($"Your total score is: {score} out of {ex.data.Count}.");

//             if (wrongAnswers.Count > 0)
//             {
//                 Console.WriteLine("\nYou got the following questions wrong:");
//                 foreach (var item in wrongAnswers)
//                 {
//                     Console.WriteLine($"-----------------------------");
//                     Console.WriteLine($"Question: {item.Question}");
//                     Console.WriteLine($"Your answer: {item.UserAnswer}");
//                     Console.WriteLine($"Correct answer: {item.CorrectAnswer}");
//                 }
//                 Console.WriteLine("-----------------------------");
//             }

//             if (score >= 3)
//             {
//                 Console.WriteLine("\nCongratulations! You passed the quiz.");
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("\nPlay Again? (yes/no):");
//                 string? retry = Console.ReadLine()?.ToLower();
//                 if (retry != "yes")
//                     break;
//             }
//         } while (true);
//     }
// }

//Exercice9: Cats
// class Cat
// {
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public Cat(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }

// }

// class Exercice9
// {
// public Cat GetOldestCat(List<Cat> cats)
// {
//     if (cats == null || cats.Count == 0)
//         return null;

//     Cat oldestCat = cats[0];

//     foreach (var cat in cats)
//     {
//         if (cat.Age > oldestCat.Age)
//         {
//             oldestCat = cat;
//         }
//     }

//     return oldestCat;
// }

// static void Main(string[] args)
//     {
//         List<Cat> cats = new List<Cat>
//         {
//             new Cat("Happy", 3),
//             new Cat("Carla", 5),
//             new Cat("Migi", 2)
//         };

//         Exercice9 ex = new Exercice9();
//         Cat oldest = ex.GetOldestCat(cats);

//         if (oldest != null)
//         {
//             Console.WriteLine($"The oldest cat is {oldest.Name} and is {oldest.Age} years old.");
//         }
//         else
//         {
//             Console.WriteLine("No cats in the list.");
//         }
//     }
// }

//Exercice10: Dogs
// class Dog
// {
//     public string Name { get; set; }
//     public int Height { get; set; }

//     public Dog(string name, int height)
//     {
//         Name = name;
//         Height = height;
//     }
//     public string Bark()
//     {
//         return $"{Name} goes Woof";
//     }
//     public string Jump()
//     {
//         int jumpHeight = Height * 2;
//         return $"{Name} jumps {jumpHeight} cm high!";
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Dog davidsDog = new Dog("Rex", 50);
//         Dog sarahsDog = new Dog("Teacup", 20);

//         Console.WriteLine(davidsDog.Bark());
//         Console.WriteLine(davidsDog.Jump());

//         Console.WriteLine(sarahsDog.Bark());
//         Console.WriteLine(sarahsDog.Jump());
//         if (davidsDog.Height > sarahsDog.Height)
//         {
//             Console.WriteLine($"{davidsDog.Name} is bigger");
//         }
//         else if (sarahsDog.Height > davidsDog.Height)
//         {
//             Console.WriteLine($"{sarahsDog.Name} is bigger");
//         }
//         else
//         {
//             Console.WriteLine($"{davidsDog.Name} and {sarahsDog.Name} are of the same height");
//         }
//     }
// }

//Exercise 11: Who’s the Song Producer?
// class Song
// {
//     //Constructor
//     public List<string> Lyrics { get; set; }

//     public Song(List<string> lyrics)
//     {
//         Lyrics = lyrics;
//     }

//     public string SingMeASong()
//     {
//         foreach (string line in Lyrics)
//         {
//             Console.WriteLine(line);
//         }
//         return "";
//         }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         var stairway = new Song(new List<string>
//         {
//             "There's a lady who's sure",
//             "All that glitters is gold",
//             "And she's buying a stairway to heaven"
//         });
//         stairway.SingMeASong();
//     }
// }

//Exercise 12: Afternoon at the Zoo
// class Zoo
// {
//     public string ZooName { get; set; }
//     public List<string> Animals { get; set; }
//     public Zoo(string zooName)
//     {
//         ZooName = zooName;
//         Animals = new List<string>();
//     }
//     public void AddAnimal(string animal)
//     {
//         if (!Animals.Contains(animal))
//         {
//             Animals.Add(animal);
//         }
//         else
//         {
//             Console.WriteLine($"{animal} is already in the zoo.");
//         }
//     }
//     public void GetAnimals()
//     {
//         Console.WriteLine($"Animals in {ZooName}:");
//         foreach (var animal in Animals)
//         {
//             Console.WriteLine(animal);
//         }
//     }
//     public void SellAnimal(string animalSold)
//     {
//         if (Animals.Contains(animalSold))
//         {
//             Animals.Remove(animalSold);
//             Console.WriteLine($"{animalSold} has been sold.");
//         }
//         else
//         {
//             Console.WriteLine($"{animalSold} is out of stock, oups i mean... not in the zoo.");
//         }
//     }
//     public Dictionary<char, List<string>> SortAnimals()
//     {
//         var sortedAnimals = Animals.OrderBy(a => a).ToList();
//         var groupedAnimals = new Dictionary<char, List<string>>();
//         foreach (var animal in sortedAnimals)
//         {
//             char firstLetter = animal[0];
//             if (!groupedAnimals.ContainsKey(firstLetter))
//             {
//                 groupedAnimals[firstLetter] = new List<string>();
//             }
//             groupedAnimals[firstLetter].Add(animal);
//         }
//         return groupedAnimals;
//     }
//     public void GetGroups()
//     {
//         var groupedAnimals = SortAnimals();
//         foreach (var entry in groupedAnimals)
//         {
//             Console.WriteLine($"    '{entry.Key}': [{string.Join(", ", entry.Value.Select(a => $"\"{a}\""))}]");
//         }
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         var newYorkZoo = new Zoo("NEEEEW YOOOORK");
//         string[] animals = { "Lion", "Liger", "Bear", "Beluga", "Giraffe", "Zebra", "Monkey", "Panda", "Pelican", "Penguin" };
//         foreach (var animal in animals)
//         {
//             newYorkZoo.AddAnimal(animal);
//         }
//         Console.WriteLine("------------------------------------------------");
//         newYorkZoo.GetAnimals();
//         Console.WriteLine("------------------------------------------------");
//         newYorkZoo.SellAnimal("Tiger");
//         newYorkZoo.SellAnimal("Dolphin");
//         Console.WriteLine("------------------------------------------------");
//         newYorkZoo.GetAnimals();
//         Console.WriteLine("------------------------------------------------");
//         Console.WriteLine("Sorted and Grouped Animals:");
//         newYorkZoo.GetGroups();
//         Console.WriteLine("------------------------------------------------");
//     }
// }
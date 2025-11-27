using System;
using System.Collections.Generic;

//Exercice1: Birthday Look-up
// class Exercice1
// {
//     static void Main(string[] args)
//     {
//         //Creating a dictionary to hold names and birthdays
//         Dictionary<string, string> birthDays = new Dictionary<string, string>
//         {
//             {"mohamed", "2002/01/14"},
//             {"betty", "2004/04/14"},
//             {"meliodas", "1000/07/25"},
//             {"elizabeth", "1000/07/12"}
//         };

//         //Prompting user for a name
//         Console.Write("Enter a name to look up the birthday: ");
//         string? name = Console.ReadLine().ToLower();

//         //Looking up the birthday
//         if (name != null && birthDays.ContainsKey(name))
//         {
//             Console.WriteLine($"{name}'s birthday is on {birthDays[name]}.");
//         }
//         else
//         {
//             Console.WriteLine("Sorry, that name is not in the birthday list.");
//         }
//     }
// }

//Exercice2: Birthdays Advanced
// class Exercice2
// {
//     static void Main(string[] args)
//     {
//         //Creating a dictionary to hold names and birthdays
//         Dictionary<string, string> birthDays = new Dictionary<string, string>
//         {
//             {"mohamed", "2002/01/14"},
//             {"betty", "2004/04/14"},
//             {"meliodas", "1000/07/25"},
//             {"elizabeth", "1000/07/12"}
//         };

//         //Displaying current birthdays
//         Console.WriteLine("Current Birthdays:");
//         foreach (var kvp in birthDays)
//         {
//             Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//         }

//         //Prompting user for a name
//         Console.Write("Enter a name to look up the birthday: ");
//         string? name = Console.ReadLine().ToLower();

//         //Looking up the birthday
//         if (name != null && birthDays.ContainsKey(name))
//         {
//             Console.WriteLine($"{name}'s birthday is on {birthDays[name]}.");
//         }
//         else
//         {
//             Console.WriteLine($"Sorry, we don’t have the birthday information for {name}");
//         }
//     }
// }

//Exercice3: Sum Sequence of numbers x + xx + xxx + xxxx
// class Exercice3
// {
//     public int SumSequence(int a)
//     {
//         List<int> numbers = new List<int>{a,a,a,a};
//         List<int> sequences = new List<int>{1,11,111,1111};
//         int sumSeq = 0;

//         foreach (var mul in numbers.Zip(sequences, (x, y) => (x * y)))
//         {
//             sumSeq += mul;
//         }

//         return sumSeq;
//     }

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a number:");
//         int n = Convert.ToInt32(Console.ReadLine());

//         Exercice3 ex = new Exercice3();
//         int result = ex.SumSequence(n);

//         Console.WriteLine($"The sum of the sequence of number {n} is: {result}");
//     }
// }

//Exercice4: Double Dice
// class Exercice4
// {
//     public int ThrowDice()
//     {
//         Random rand = new Random();
//         int die1 = rand.Next(1, 7);
//         return die1;
//     }

//     public int ThrowUntilDoubles()
//     {
//         int die1, die2;
//         int attempts = 0;

//         do
//         {
//             die1 = ThrowDice();
//             die2 = ThrowDice();
//             attempts++;
//             Console.WriteLine($"Roll {attempts}: Die 1 = {die1}, Die 2 = {die2}");
//         } while (die1 != die2);

//         Console.WriteLine($"Doubles rolled after {attempts} attempts!");
//         return attempts;
//     }

//     public void MainSimulation()
//     {
//         int totalAttempts = 100;
//         List<int> attemptsList = new List<int>();
//         int cumulativeAttempts = 0;
//         double cumulativeAttemptsDivBy100 = 0;
//         double avrageAttempts;
//         Exercice4 ex = new Exercice4();
//         while (totalAttempts > 0)
//         {
//             cumulativeAttempts += ex.ThrowUntilDoubles();
//             cumulativeAttemptsDivBy100 += ex.ThrowUntilDoubles() / 100.0;
//             attemptsList.Add(ex.ThrowUntilDoubles());
//             totalAttempts--;
//         }
//         // Console.WriteLine("List of Attempts in this simulation:");
//         // Console.Write("{");
//         // foreach (var attempt in attemptsList)
//         // {
//         //     Console.Write($"{attempt}");
//         //     if (attempt != attemptsList[^1])
//         //     {
//         //         Console.Write(", ");
//         //     }
//         // }
//         // Console.Write("}");
//         avrageAttempts = cumulativeAttemptsDivBy100;
//         Console.WriteLine($"Total attempts to roll doubles in 100 simulations: {cumulativeAttempts}");
//         Console.WriteLine($"Average attempts to roll doubles over 100 simulations: {avrageAttempts:F2}");
//     }
//     static void Main(string[] args)
//     {
//         Exercice4 ex = new Exercice4();
//         ex.MainSimulation();
//     }
// }
//Exercice 1: FizzBuzz

// class Exercise1
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a number between 1 to 100:");
//         int number = int.Parse(Console.ReadLine());
//             if (number % 3 == 0 && number % 5 == 0)
//             {
//                 Console.WriteLine("FizzBuzz");
//             }
//             else if (number % 3 == 0)
//             {
//                 Console.WriteLine("Fizz");
//             }
//             else if (number % 5 == 0)
//             {
//                 Console.WriteLine("Buzz");
//             }
//             else
//             {
//                 Console.WriteLine(number);
//             }
//     }
// }



//Exercice 2: Build a Triangle Pattern

// class Exercise2
// {
//     static void Main(string[] args)
//     {
//         int rows = 5;
//         for (int i = 1; i <= rows; i++)
//         {
//             for (int j = 1; j <= i; j++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine();
//         }
//     }
// }



//Exercice 3: Reverse a Word (No Built-in Functions)

class Exercise3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a word:");
        string input = Console.ReadLine();
        char[] reversedChars = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            reversedChars[i] = input[input.Length - 1 - i];
        }
        string reversedWord = new string(reversedChars);
        Console.WriteLine("Reversed word: " + reversedWord);
    }
}
//--------------------------------Challenge 1: Multiples List Generator---------------------------------

// class Challenge1
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a number:");
//         int number = int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter a lenght:");
//         int length = int.Parse(Console.ReadLine());

//         List<int> multiples = new List<int>();
//         for (int i = 1; i <= length; i++)
//         {
//             multiples.Add(i * number);
//         }
//         Console.WriteLine("The multiples of "+ number +" are: " + string.Join(", ", multiples));
//     }
// }



//---------------------------Challenge 2: Remove Consecutive Duplicate Letters----------------------------

// class Challenge2
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a string:");
//         string input = Console.ReadLine().ToLower();
//         if (string.IsNullOrEmpty(input))
//         {
//             Console.WriteLine("Empty string provided.");
//             return;
//         }

//         char previousChar = input[0];
//         List<char> resultChars = new List<char> { previousChar };

//         for (int i = 1; i < input.Length; i++)
//         {
//             if (input[i] != previousChar)
//             {
//                 resultChars.Add(input[i]);
//                 previousChar = input[i];
//             }
//         }

//         string result = new string(resultChars.ToArray());
//         Console.WriteLine("Resulting string: " + result);
//     }
// }
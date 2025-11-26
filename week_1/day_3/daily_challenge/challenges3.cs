//Requesting user input
Console.WriteLine("Insert word :");
string word = Console.ReadLine();

//Creating dictionary to hold letters and their positions
Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();

//Iterating through each letter in the word
for (int i = 0; i < word.Length; i++)
{
    //Getting the current letter
    char letter = word[i];

    //If letter is not in dictionary, add it with an empty list
    if (!dict.ContainsKey(letter))
    {
        dict[letter] = new List<int>();
    }

    //Add the current index to the list of positions for the letter
    dict[letter].Add(i);
}

//Printing the letters and their positions
foreach (var l in dict)
{
    //Handling space character for better readability
    if (l.Key == ' ')
    {
        Console.Write("Space: [");
    }
    else
    {
    Console.Write($"{l.Key}: [");
    }
    Console.Write(string.Join(", ", l.Value) + "] \n");
}
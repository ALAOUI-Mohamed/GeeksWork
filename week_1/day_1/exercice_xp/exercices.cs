using System;

//Exercice 1: Welcome to C# Programming!
/*class Exercise1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to C# Programming!");
    }
}*/

//Exercice 2: Name showing
/*class Exercise2
{

    static void Main(string[] args)
    {
        string name = "Alaoui Mohamed";
        int age = 23;
        Console.WriteLine($"My name is {name} I am {age} years old.");
    }
}*/

//Exercice 3: Simple Calculator
/*class Exercise3
{

    static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 5;
        int sum = num1 + num2;
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");
    }
}*/

//Exercice 4: Age Checker
/*class Exercise4
{

    static void Main(string[] args)
    {
        int age = 20;
        if (age >= 18)
        {
            Console.WriteLine("Access Granted.");
        }
        else
        {
            Console.WriteLine("Access Denied.");
        }
    }
}*/

//Exercice 5: The countdown while loop
/*class Exercise5
{

    static void Main(string[] args)
    {
        int count = 10;
        while (count > 0)
        {
            Console.WriteLine(count);
            count--;
        }
        Console.WriteLine("Liftoff!");
    }
}*/

//Exercice 6: The Repeater
/*class Exercise6
{
    static void SayHello(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    static void Main(string[] args)
    {
        SayHello("Meliodas");
        SayHello("Elizabeth");
        SayHello("Ban");
    }
}*/

//Exercice 7: Even or Odd?
/*class Exercise7
{
    static void EvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd.");
        }
    }
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            EvenOrOdd(i);
        }
    }
}*/

//Exercice 8: Temperature Converter
/*class Exercise8
{
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static void Main(string[] args)
    {
        double celsius;
        Console.Write("Enter temperature in Celsius: ");
        celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = CelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F.");
    }
}*/

//Exercice 9: Number Swapper
/*class Exercise9
{
    static void NumbersSwapper(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;
        Console.WriteLine($"Before Swap: num1 = {num1}, num2 = {num2}");
        NumbersSwapper(ref num1, ref num2);
        Console.WriteLine($"After Swap: num1 = {num1}, num2 = {num2}");
    }
}*/
//Exercice 10: Simple Multiplication Table
/*class Exercise10
{
    static void PrintMultiplicationTable(int number)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }

    static void Main(string[] args)
    {
        int num;
        Console.Write("Enter a number to display its multiplication table: ");
        num = Convert.ToInt32(Console.ReadLine());
        PrintMultiplicationTable(num);
    }
}*/
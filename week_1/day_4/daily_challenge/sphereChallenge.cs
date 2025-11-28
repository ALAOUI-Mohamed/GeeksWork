//Challenge: Sphere Challenge
using System;
class Sphere
{
    // A Sphere can be defined by either specifying the radius or the diameter.
    private double radius;
    public Sphere(double radius)
    {
        this.radius = radius;
    }
    public Sphere(double diameter, bool isDiameter)
    {
        if (isDiameter)
        {
            this.radius = diameter / 2;
        }
        else
        {
            this.radius = diameter;
        }
    }
    public double GetRadius()
    {
        return radius;
    }
    public double GetDiameter()
    {
        return radius * 2;
    }

    //Compute the volume and surface area of the sphere.
    public double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }
    public double GetSurfaceArea()
    {
        return 4 * Math.PI * Math.Pow(radius, 2);
    }

    //Print the attributes of the sphere in a readable format (override ToString()).
    public override string ToString()
    {
        return $"Sphere Infos:\n[\n\tRadius: {GetRadius():F2} \n\tDiameter: {GetDiameter():F2} \n\tVolume: {GetVolume():F2} \n\tSurface Area: {GetSurfaceArea():F2}\n]";
    }

    //Add two spheres together, returning a new sphere with the new radius equal to the sum of the two radii (override + operator)
    public static Sphere operator +(Sphere s1, Sphere s2)
    {
        return new Sphere(s1.radius + s2.radius);
    }

    //Compare two spheres to see which is bigger (by volume), returning a Boolean (override > and <).
    public static bool operator >(Sphere s1, Sphere s2)
    {
        return s1.GetVolume() > s2.GetVolume();
    }
    public static bool operator <(Sphere s1, Sphere s2)
    {
        return s1.GetVolume() < s2.GetVolume();
    }

    //Compare two spheres to see if they are equal in radius (override == and !=).
    public static bool operator ==(Sphere s1, Sphere s2)
    {
        return s1.radius == s2.radius;
    }
    public static bool operator !=(Sphere s1, Sphere s2)
    {
        return s1.radius != s2.radius;
    }
    // public override bool Equals(object obj)
    // {
    //     if (obj is Sphere otherSphere)
    //     {
    //         return this.radius == otherSphere.radius;
    //     }
    //     return false;
    // }

    //Put spheres in a list and sort them by radius or volume.
    public static void SortSpheresByRadius(Sphere[] spheres)
    {
        Array.Sort(spheres, (s1, s2) => s1.radius.CompareTo(s2.radius));
    }
    public static void SortSpheresByVolume(Sphere[] spheres)
    {
        Array.Sort(spheres, (s1, s2) => s1.GetVolume().CompareTo(s2.GetVolume()));
    }

    //Bonus: Implement a method to scale a sphere by a factor.
    public void Scale(double factor)
    {
        radius *= factor;
    }

}

class SphereChallenge
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Welcome to the Sphere Challenge Interactive Demo! ---");
        
        // List to hold the spheres created by the user
        List<Sphere> spheresList = new List<Sphere>();

        // Loop to allow the user to create multiple spheres
        bool continueCreating = true;
        int sphereCount = 1;

        while (continueCreating)
        {
            Console.WriteLine($"\n*** Creating Sphere #{sphereCount} ***");
            
            // 1. Get input type (Radius or Diameter)
            double size = 0.0;
            bool isDiameter = false;
            
            while (true)
            {
                Console.Write("Do you want to define the sphere by **(R)adius** or **(D)iameter**? (R/D): ");
                string choice = Console.ReadLine().Trim().ToUpper();

                if (choice == "R")
                {
                    isDiameter = false;
                    Console.Write("Enter the radius value: ");
                    break;
                }
                else if (choice == "D")
                {
                    isDiameter = true;
                    Console.Write("Enter the diameter value: ");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 'R' for Radius or 'D' for Diameter.");
                }
            }

            // 2. Get the numerical size input
            while (!double.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for the size:");
                Console.Write(isDiameter ? "Enter the diameter value: " : "Enter the radius value: ");
            }

            // 3. Create and add the new Sphere
            Sphere newSphere = isDiameter ? new Sphere(size, true) : new Sphere(size);
            spheresList.Add(newSphere);
            Console.WriteLine($"\nSuccessfully created Sphere #{sphereCount}!");
            Console.WriteLine(newSphere);
            
            // 4. Ask if the user wants to create another
            Console.Write("Do you want to create another sphere? (Y/N): ");
            string anotherChoice = Console.ReadLine().Trim().ToUpper();
            
            if (anotherChoice != "Y")
            {
                continueCreating = false;
            }
            sphereCount++;
        }
        
        // --- End of interactive creation. Start of Sphere Challenge execution ---

        // Check if enough spheres were created for the rest of the demo
        if (spheresList.Count < 2)
        {
            Console.WriteLine("\nNot enough spheres created (minimum 2 needed for comparisons and addition). Skipping full challenge demo.");
            return;
        }

        Sphere sphere1 = spheresList[0];
        Sphere sphere2 = spheresList[1];
        
        Console.WriteLine("\n" + new string('-', 40));
        Console.WriteLine("--- Running Sphere Challenge Logic ---");
        Console.WriteLine(new string('-', 40));

        // Addition (+) operator demonstration
        Sphere sphere3 = sphere1 + sphere2;
        Console.WriteLine("\nSphere Addition (sphere1 + sphere2)");
        Console.WriteLine("The new sphere has a radius equal to the sum of the first two radii.");
        Console.WriteLine(sphere3);
        // Comparison operators demonstration
        Console.WriteLine("\n## ⚖️ Sphere Comparison (by Volume)");
        Console.WriteLine($"Is Sphere 1 > Sphere 2? **{sphere1 > sphere2}**");
        Console.WriteLine($"Is Sphere 1 < Sphere 2? **{sphere1 < sphere2}**");
        Console.WriteLine($"Is Sphere 1 == Sphere 2 (by Radius)? **{sphere1 == sphere2}**");
        Console.WriteLine($"Is Sphere 1 != Sphere 2 (by Radius)? **{sphere1 != sphere2}**");
        
        // Array for sorting demonstration (includes sphere3)
        Sphere[] spheresArray = spheresList.ToArray();
        // The array is dynamically sized based on user input
        if (spheresArray.Length > 1)
        {
            Sphere[] sortSpheres = new Sphere[spheresArray.Length + 1];
            Array.Copy(spheresArray, sortSpheres, spheresArray.Length);
            sortSpheres[sortSpheres.Length - 1] = sphere3;
            spheresArray = sortSpheres;
        }

        // Sorting by Radius
        Console.WriteLine("\n## 📏 Spheres Sorted by Radius");
        Sphere.SortSpheresByRadius(spheresArray);
        foreach (var sphere in spheresArray)
        {
            Console.WriteLine(sphere);
        }

        // Sorting by Volume
        Console.WriteLine("\n## ⚗️ Spheres Sorted by Volume");
        Sphere.SortSpheresByVolume(spheresArray);
        foreach (var sphere in spheresArray)
        {
            Console.WriteLine(sphere);
        }

        int factor = 0;
         while (true)
        {
            Console.Write("Enter a scaling factor (positive integer) to scale Sphere 1: ");
            if (int.TryParse(Console.ReadLine(), out factor) && factor > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
        // Scaling demonstration
        Console.WriteLine("\n## ⏫ Bonus: Scaling Sphere 1");
        Console.WriteLine("How Much factor to scale Sphere 1 by?");
        Console.WriteLine($"Original Sphere 1 Radius: {sphere1.GetRadius():F2}");
        sphere1.Scale(factor);
        Console.WriteLine($"Scaling Sphere 1 by a factor of **{factor}**...");
        Console.WriteLine(sphere1);

        Console.WriteLine("\n--- Demo Complete ---");
    }
}

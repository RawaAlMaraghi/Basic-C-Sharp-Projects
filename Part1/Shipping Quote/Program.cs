using System;

class PackageShipping
{
    static void Main()
    {
        // Greet the user and explain the process
        Console.WriteLine("Welcome to Package Express. Let's get your shipping details!");

        // Collect the weight of the package
        double packageWeight = GetPackageDimension("weight");

        // Ensure the weight is within the allowed limit
        if (packageWeight > 50)
        {
            Console.WriteLine("Sorry, your package is too heavy to ship via Package Express.");
            return; // Exit if the weight exceeds the limit
        }

        // Collect the dimensions (width, height, length)
        double packageWidth = GetPackageDimension("width");
        double packageHeight = GetPackageDimension("height");
        double packageLength = GetPackageDimension("length");

        // Validate the total dimensions (width + height + length)
        if ((packageWidth + packageHeight + packageLength) > 50)
        {
            Console.WriteLine("Sorry, the total dimensions exceed the shipping limit.");
            return; // Exit if the total dimensions are too large
        }

        // Calculate the shipping quote
        double shippingCost = CalculateShippingCost(packageWeight, packageWidth, packageHeight, packageLength);

        // Show the estimated shipping cost to the user
        Console.WriteLine($"The estimated cost for shipping is: ${shippingCost:F2}");

        // Thank the user for using the service
        Console.WriteLine("Thank you for choosing Package Express!");
    }

    // Method to get the user's input for package dimensions or weight
    static double GetPackageDimension(string dimension)
    {
        Console.WriteLine($"Please enter the package {dimension}:");
        return double.Parse(Console.ReadLine());
    }

    // Method to calculate the shipping cost based on the dimensions and weight
    static double CalculateShippingCost(double weight, double width, double height, double length)
    {
        return (width * height * length * weight) / 100;
    }
}

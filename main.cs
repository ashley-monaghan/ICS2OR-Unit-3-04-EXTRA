// Created by: Ashley Monaghan
// Created on: Nov 2022
//
//This program converts Fahrenheit to Celsius

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double Fahrenheit;
        double celsius;

        Console.WriteLine("This program converts Fahrenheit to Celsius.");
        Console.WriteLine("");

        Console.Write("Enter Fahrenheit (°F): ");
        Fahrenheit = Convert.ToDouble(Console.ReadLine());

        celsius = (Fahrenheit - 32) * 5 / 9;

        Console.WriteLine("");
        Console.WriteLine("The celsius is: " + celsius.ToString("0.00") + " °C ");

        Console.WriteLine("\nDone.");
    }
}
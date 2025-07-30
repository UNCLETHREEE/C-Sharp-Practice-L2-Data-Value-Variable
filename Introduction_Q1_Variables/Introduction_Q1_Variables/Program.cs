// To test out your code, comment the other parts and uncomment the part you want to test.
// To comment a part, select the part and press Ctrl + K + C
// To uncomment a part, select the part and press Ctrl + K + U
// Press Ctrl + F5 to run the code.

using System;

class Program
{
    static void Main(string[] args)
    {
        //---------------------------------------------------------------------
        // Part 1: Create variables of different types, assign values to them, and print them to the console
        // Hint: Use the Console.WriteLine() method to print the string to the console.
        // Create variables of different types and assign values to them using a consistent naming convention.
        // Use the following variable types: int, double, string, bool, char, byte, long, decimal, float.

        int enemy_health = 100;
        double game_currency = 2500.50;
        string player_name = "John Doe";
        bool isalive = true;
        char patrol_state = 'S';
        byte player_age = 25;
        long score = 1000000000;
        decimal price = 100.50m;
        object null_variable = null;
        float speed = 100.50f;

        Console.WriteLine("Enemy Health (int): " + enemy_health);
        Console.WriteLine("Game Currency (double): " + game_currency);
        Console.WriteLine("Player Name (string): " + player_name);
        Console.WriteLine("Is Alive (bool): " + isalive);
        Console.WriteLine("Patrol State (char): " + patrol_state);
        Console.WriteLine("Player Age (byte): " + player_age);
        Console.WriteLine("Score (long): " + score);
        Console.WriteLine("Price (decimal): " + price);
        Console.WriteLine("Null Variable (object): " + null_variable);
        Console.WriteLine("Speed (float): " + speed);

        //---------------------------------------------------------------------
        // Part 17: Declaration of Constants
        // Write a C# program to declare a constant integer variable representing the value of Pi.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const double Pi = 3.14159;

        const double Pi = 3.14159;
        Console.WriteLine("Constant Pi: " + Pi);

        //---------------------------------------------------------------------
        // Part 18: Declaration of Constants
        // Write a C# program to declare a constant string variable representing the name of a company.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const string CompanyName = "ABC Corporation";

        const string CompanyName = "ABC Corporation";
        Console.WriteLine("Company Name: " + CompanyName);

        //---------------------------------------------------------------------
        // Part 19: Declaration of Constants
        // Write a C# program to declare a constant integer variable representing the maximum number of retries for a network request.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const int MaxRetries = 3;

        const int MaxRetries = 3;
        Console.WriteLine("Max Retries: " + MaxRetries);

        //---------------------------------------------------------------------
        // Part 20: Declaration of Constants
        // Write a C# program to declare a constant double variable representing the acceleration due to gravity.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const double Gravity = 9.8;

        const double Gravity = 9.8;
        Console.WriteLine("Gravity: " + Gravity);

        //---------------------------------------------------------------------
        // Part 21: Declaration of Constants
        // Write a C# program to declare a constant integer variable representing the number of months in a year.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const int MonthsInYear = 12;

        const int MonthsInYear = 12;
        Console.WriteLine("Months in a Year: " + MonthsInYear);
    }
}

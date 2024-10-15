using System;

class RandomPhoneNumberGenerator
{
    static Random random = new Random();

    static void Main(string[] args)
    {
        Console.WriteLine("Random South African Phone Number Generator");
        
        // Generate and display 5 random phone numbers
        for (int i = 0; i < 5; i++)
        {
            string phoneNumber = GeneratePhoneNumber();
            Console.WriteLine(phoneNumber);
        }
        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Function to generate random phone numbers
    static string GeneratePhoneNumber()
    {
        // Define possible starting digits for South African mobile numbers (0XX)
        string[] prefixes = { "060", "061", "071", "072", "073", "074", "081", "082", "083", "084" };

        // Pick a random prefix
        string prefix = prefixes[random.Next(prefixes.Length)];

        // Generate the remaining 7 digits (XXX XXXX)
        string middle = random.Next(100, 1000).ToString(); // Generates 3 digits
        string last = random.Next(1000, 10000).ToString(); // Generates 4 digits

        // Combine to form the full phone number
        return $"{prefix} {middle} {last}";
    }
}

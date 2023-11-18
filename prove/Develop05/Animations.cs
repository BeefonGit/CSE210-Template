using System;

class CharacterGenerator
{
    private string[,] asciiArtArray = {
        // Acolyte
        {
            "   ~   \n  /|\\  \n  / \\  ", // Level 1
            "   @   \n  /|\\  \n  / \\  ", // Level 2
            "   #   \n  /|\\  \n  / \\  "  // Level 3
        },
        // Fighter
        {
            "  |\\|  \n  / \\  \n /___\\ ", // Level 1
            "  |\\/| \n  / \\  \n /___\\ ", // Level 2
            "  |\\/| \n  /o\\  \n /___\\ "  // Level 3
        },
        // Ranger
        {
            "   ^   \n  /|\\  \n /___\\ ", // Level 1
            "  ^^^  \n  /|\\  \n /___\\ ", // Level 2
            " ^^^^^ \n  /|\\  \n /___\\ "  // Level 3
        }
    };

    public string GenerateCharacter(int archetype, int level)
    {
        return asciiArtArray[archetype - 1, level - 1];
    }
}

<<<<<<< HEAD
// class Program This Cannot exist as a program class
class Animate
{
    static void Main()
    {
        CharacterGenerator characterGenerator = new CharacterGenerator();

        Console.WriteLine("Choose an archetype:");
        Console.WriteLine("1. Acolyte");
        Console.WriteLine("2. Fighter");
        Console.WriteLine("3. Ranger");

        int archetypeChoice = int.Parse(Console.ReadLine());

        //int levelChoice = int.Parse(Console.ReadLine());
        int level = 

        string asciiArt = characterGenerator.GenerateCharacter(archetypeChoice, level);

        Console.WriteLine("Character Power Level:");
        Console.WriteLine(asciiArt);
    }

    
}
=======
>>>>>>> 8ac7f379bc4d85615d99ae19ab248aad46ce7177

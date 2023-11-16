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


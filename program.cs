using System;
//test
class Program
{
    static void Main()
    {
        string[,] ourAnimals = new string[8, 6];
        int petCount = 4;
        ourAnimals[0, 0] = "ID #: D1";
        ourAnimals[0, 1] = "Species: Dog";
        ourAnimals[0, 2] = "Age: 2";
        ourAnimals[0, 3] = "Nickname: Bella";
        ourAnimals[0, 4] = "Physical description: Medium-sized, cream color.";
        ourAnimals[0, 5] = "Personality: Playful, loves belly rubs.";

        ourAnimals[1, 0] = "ID #: D2";
        ourAnimals[1, 1] = "Species: Dog";
        ourAnimals[1, 2] = "Age: 9";
        ourAnimals[1, 3] = "Nickname: Max";
        ourAnimals[1, 4] = "Physical description: Large, brown.";
        ourAnimals[1, 5] = "Personality: Loves ear rubs, very friendly.";

        ourAnimals[2, 0] = "ID #: C3";
        ourAnimals[2, 1] = "Species: Cat";
        ourAnimals[2, 2] = "Age: 1";
        ourAnimals[2, 3] = "Nickname: Whiskers";
        ourAnimals[2, 4] = "Physical description: Small, white.";
        ourAnimals[2, 5] = "Personality: Friendly, curious.";

        ourAnimals[3, 0] = "ID #: C4";
        ourAnimals[3, 1] = "Species: Cat";
        ourAnimals[3, 2] = "Age: ?";
        ourAnimals[3, 3] = "Nickname: Unknown";
        ourAnimals[3, 4] = "Physical description: Not recorded.";
        ourAnimals[3, 5] = "Personality: Not recorded.";

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1 - List all pets");
            Console.WriteLine("2 - Add a new pet");
            Console.WriteLine("3 - Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                for (int i = 0; i < petCount; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                        Console.WriteLine(ourAnimals[i, j]);
                }
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "2" && petCount < 8)
            {
                string species = "";
                while (species != "dog" && species != "cat")
                {
                    Console.Write("Enter 'dog' or 'cat': ");
                    species = Console.ReadLine().ToLower();
                }

                string id = species.Substring(0, 1).ToUpper() + (petCount + 1);
                Console.Write("Enter age or ? if unknown: ");
                string age = Console.ReadLine();
                Console.Write("Enter physical description: ");
                string description = Console.ReadLine();
                Console.Write("Enter personality: ");
                string personality = Console.ReadLine();
                Console.Write("Enter nickname: ");
                string nickname = Console.ReadLine();

                ourAnimals[petCount, 0] = "ID #: " + id;
                ourAnimals[petCount, 1] = "Species: " + species;
                ourAnimals[petCount, 2] = "Age: " + age;
                ourAnimals[petCount, 3] = "Nickname: " + (nickname == "" ? "Unknown" : nickname);
                ourAnimals[petCount, 4] = "Physical description: " + (description == "" ? "Not recorded." : description);
                ourAnimals[petCount, 5] = "Personality: " + (personality == "" ? "Not recorded." : personality);
                petCount++;

                Console.WriteLine("Pet added! Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "3")
                break;
            else
                Console.WriteLine("Invalid choice! Press Enter to try again.");
        }
    }
}

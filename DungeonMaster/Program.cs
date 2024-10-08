using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DungeonMaster
{
    #region Character
    public interface ICharacter
    {
        string Name { get; set; }
        int Strength { get; set; }
        int Dexterity { get; set; }
        int Constitution { get; set; }
        int Intelligence { get; set; }
        int Wisdom { get; set; }
        int Charisma { get; set; }
        int Level { get; set; }
        int HitPoints { get; set; }
        double ProficiencyBonus { get; set; }
        string Gender { get; set; }
        string Alignment { get; set; }
        int Money { get; set; }
        Race Race { get; set; }
        Class Class { get; set; }
    }

    public class Character : ICharacter
    {
        public int Id { get; set; } // Primary key for EF
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Level { get; set; }
        public int HitPoints { get; set; }
        public double ProficiencyBonus { get; set; }
        public string Gender { get; set; }
        public string Alignment { get; set; }
        public int Money { get; set; }

        // Foreign keys
        public int RaceId { get; set; }
        public int ClassId { get; set; }
        public int CampaignId { get; set; }

        // Navigation properties
        public Race Race { get; set; } // Concrete class
        public Class Class { get; set; } // Concrete class
        public Campaign Campaign { get; set; } // Add navigation property for Campaign
    }
    #endregion
    //

    #region Race
    public interface IRace
    {
        string RaceName { get; }
    }

    public class Race : IRace
    {
        public int Id { get; set; } // This will be the primary key in the database
        public string RaceName { get; set; } // This will store the race name
    }

    public class Dwarf : IRace
    {
        public string RaceName => "Dwarf";
    }

    public class Elf : IRace
    {
        public string RaceName => "Elf";
    }

    public class Halfling : IRace
    {
        public string RaceName => "Halfling";
    }

    public class Human : IRace
    {
        public string RaceName => "Human";
    }

    public class Tiefling : IRace
    {
        public string RaceName => "Tiefling";
    }
    #endregion

    #region Class
    public interface IClass
    {
        string ClassName { get; }
    }

    public class Class : IClass
    {
        public int Id { get; set; } // Primary key
        public string ClassName { get; set; } // Name of the class (e.g., Bard, Cleric, etc.)
    }

    public class Bard : IClass
    {
        public string ClassName => "Bard";
    }

    public class Cleric : IClass
    {
        public string ClassName => "Cleric";
    }

    public class Fighter : IClass
    {
        public string ClassName => "Fighter";
    }

    public class Rogue : IClass
    {
        public string ClassName => "Rogue";
    }

    public class Wizard : IClass
    {
        public string ClassName => "Wizard";
    }

    public class Barbarian : IClass
    {
        public string ClassName => "Barbarian";
    }
    #endregion

    #region DungeonMaster
    public class DungeonMaster
    {
        public void ModifyCharacterProperties(Character character)
        {
            bool continueModifying = true;
            while (continueModifying)
            {
                Console.WriteLine($"Modifying properties for character: {character.Name}");
                Console.WriteLine("Select a property to modify:");
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Strength");
                Console.WriteLine("3. Dexterity");
                Console.WriteLine("4. Constitution");
                Console.WriteLine("5. Intelligence");
                Console.WriteLine("6. Wisdom");
                Console.WriteLine("7. Charisma");
                Console.WriteLine("8. Level");
                Console.WriteLine("9. Hit Points");
                Console.WriteLine("10. Alignment");
                Console.WriteLine("11. Money");
                Console.WriteLine("12. Exit");

                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Enter new character name (leave blank to keep current):");
                        string newName = Console.ReadLine();
                        if (!string.IsNullOrEmpty(newName))
                        {
                            character.Name = newName;
                        }
                        break;
                    case "2":
                        Console.WriteLine($"Enter new strength for {character.Name} (current: {character.Strength}):");
                        if (int.TryParse(Console.ReadLine(), out int newStrength))
                        {
                            character.Strength = newStrength;
                        }
                        break;
                    case "3":
                        Console.WriteLine($"Enter new dexterity for {character.Name} (current: {character.Dexterity}):");
                        if (int.TryParse(Console.ReadLine(), out int newDexterity))
                        {
                            character.Dexterity = newDexterity;
                        }
                        break;
                    case "4":
                        Console.WriteLine($"Enter new constitution for {character.Name} (current: {character.Constitution}):");
                        if (int.TryParse(Console.ReadLine(), out int newConstitution))
                        {
                            character.Constitution = newConstitution;
                        }
                        break;
                    case "5":
                        Console.WriteLine($"Enter new intelligence for {character.Name} (current: {character.Intelligence}):");
                        if (int.TryParse(Console.ReadLine(), out int newIntelligence))
                        {
                            character.Intelligence = newIntelligence;
                        }
                        break;
                    case "6":
                        Console.WriteLine($"Enter new wisdom for {character.Name} (current: {character.Wisdom}):");
                        if (int.TryParse(Console.ReadLine(), out int newWisdom))
                        {
                            character.Wisdom = newWisdom;
                        }
                        break;
                    case "7":
                        Console.WriteLine($"Enter new charisma for {character.Name} (current: {character.Charisma}):");
                        if (int.TryParse(Console.ReadLine(), out int newCharisma))
                        {
                            character.Charisma = newCharisma;
                        }
                        break;
                    case "8":
                        Console.WriteLine($"Enter new level for {character.Name} (current: {character.Level}):");
                        if (int.TryParse(Console.ReadLine(), out int newLevel))
                        {
                            character.Level = newLevel;
                        }
                        break;
                    case "9":
                        Console.WriteLine($"Enter new hit points for {character.Name} (current: {character.HitPoints}):");
                        if (int.TryParse(Console.ReadLine(), out int newHitPoints))
                        {
                            character.HitPoints = newHitPoints;
                        }
                        break;
                    case "10":
                        Console.WriteLine($"Enter new alignment for {character.Name} (current: {character.Alignment}):");
                        string newAlignment = Console.ReadLine();
                        if (!string.IsNullOrEmpty(newAlignment))
                        {
                            character.Alignment = newAlignment;
                        }
                        break;
                    case "11":
                        Console.WriteLine($"Enter new money for {character.Name} (current: {character.Money}):");
                        if (int.TryParse(Console.ReadLine(), out int newMoney))
                        {
                            character.Money = newMoney;
                        }
                        break;
                    case "12":
                        continueModifying = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid property.");
                        break;
                }

                if (continueModifying)
                {
                    Console.WriteLine("Do you want to modify another property for this character? (yes/no)");
                    string response = Console.ReadLine().ToLower();
                    continueModifying = response == "yes";
                }
            }
        }

        public void ManageCampaign(DungeonMasterContext context)
        {
            Console.WriteLine("List of available campaigns:");
            var campaigns = context.Campaigns.Include(c => c.Characters).ToList();
            foreach (var campaign in campaigns)
            {
                Console.WriteLine($"Campaign: {campaign.CampaignName} (ID: {campaign.Id})");
            }

            Console.WriteLine("Enter the campaign ID to manage:");
            if (int.TryParse(Console.ReadLine(), out int campaignId))
            {
                var selectedCampaign = context.Campaigns
                    .Include(c => c.Characters)
                    .ThenInclude(ch => ch.Race)
                    .Include(c => c.Characters)
                    .ThenInclude(ch => ch.Class)
                    .FirstOrDefault(c => c.Id == campaignId);

                if (selectedCampaign != null)
                {
                    Console.WriteLine($"Managing campaign: {selectedCampaign.CampaignName}");

                    if (selectedCampaign.Characters == null)
                    {
                        selectedCampaign.Characters = new List<Character>();
                    }

                    if (selectedCampaign.Characters.Count == 0)
                    {
                        Console.WriteLine("There are no characters in this campaign.");
                        return;
                    }

                    bool continueEditing = true;
                    while (continueEditing)
                    {
                        // Display the list of characters with their index number
                        Console.WriteLine("List of characters in the campaign:");
                        for (int i = 0; i < selectedCampaign.Characters.Count; i++)
                        {
                            var character = selectedCampaign.Characters[i];
                            Console.WriteLine($"{i + 1}. {character.Name} (Race: {character.Race?.RaceName ?? "No Race"}, Class: {character.Class?.ClassName ?? "No Class"})");
                        }

                        Console.WriteLine("Enter the number of the character you want to modify:");
                        if (int.TryParse(Console.ReadLine(), out int characterIndex) && characterIndex >= 1 && characterIndex <= selectedCampaign.Characters.Count)
                        {
                            var selectedCharacter = selectedCampaign.Characters[characterIndex - 1];
                            if (selectedCharacter != null)
                            {
                                ModifyCharacterProperties(selectedCharacter);
                            }
                            else
                            {
                                Console.WriteLine("Error: Selected character is null.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid character selection.");
                        }

                        Console.WriteLine("Do you want to modify another character? (yes/no)");
                        string response = Console.ReadLine().ToLower();
                        continueEditing = response == "yes";
                    }

                    context.SaveChanges();
                    Console.WriteLine("All changes have been saved.");
                }
                else
                {
                    Console.WriteLine("Invalid campaign ID.");
                }
            }
        }
    }


    #endregion


    public class Campaign
    {
        public int Id { get; set; } // Primary key for EF
        public string CampaignName { get; set; }

        // Ensure Characters is always initialized
        public List<Character> Characters { get; set; } = new List<Character>();

        public void AddCharacter(Character character)
        {
            Characters.Add(character);
        }

        public void DisplayCharacters()
        {
            Console.WriteLine("Characters in the Campaign:");
            foreach (var character in Characters)
            {
                Console.WriteLine($"Name: {character.Name}, Race: {character.Race.RaceName}, Class: {character.Class.ClassName}, Level: {character.Level}");
            }
        }
    }


    public class DungeonMasterContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=dungeonmasterdb;user=root;password=$$MySchoolProject11;port=3306;",
                new MySqlServerVersion(new Version(8, 0, 23))
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Optionally, seed some initial data
            modelBuilder.Entity<Race>().HasData(
                new Race { Id = 1, RaceName = "Dwarf" },
                new Race { Id = 2, RaceName = "Elf" },
                new Race { Id = 3, RaceName = "Human" },
                new Race { Id = 4, RaceName = "Halfling" },
                new Race { Id = 5, RaceName = "Tiefling" }
            );

            modelBuilder.Entity<Class>().HasData(
                new Class { Id = 1, ClassName = "Bard" },
                new Class { Id = 2, ClassName = "Cleric" },
                new Class { Id = 3, ClassName = "Fighter" },
                new Class { Id = 4, ClassName = "Rogue" },
                new Class { Id = 5, ClassName = "Wizard" },
                new Class { Id = 6, ClassName = "Barbarian" }
            );

            // Define the one-to-many relationship between Campaign and Characters
            modelBuilder.Entity<Campaign>()
                .HasMany(c => c.Characters)
                .WithOne(e => e.Campaign)
                .HasForeignKey(e => e.CampaignId);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DungeonMasterContext())
            {
                // Ask if the user is a Dungeon Master (DM) or creating a new campaign
                Console.WriteLine("Are you the Dungeon Master (DM) or creating a new campaign?");
                Console.WriteLine("Enter (1) for DM, (2) for creating a new campaign:");

                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    // DM functionality
                    DungeonMaster dm = new DungeonMaster();
                    dm.ManageCampaign(context);
                }
                else if (choice == "2")
                {
                    // Create a new campaign
                    Console.WriteLine("Enter the campaign name:");
                    string campaignName = Console.ReadLine();
                    Campaign campaign = new Campaign { CampaignName = campaignName };

                    bool addMoreCharacters = true;

                    while (addMoreCharacters)
                    {
                        // Create a character
                        Console.WriteLine("Enter character name:");
                        string characterName = Console.ReadLine();

                        // Select Race with validation
                        int raceChoice = 0;
                        var selectedRace = GetValidRace(context, ref raceChoice);

                        // Select Class with validation
                        int classChoice = 0;
                        var selectedClass = GetValidClass(context, ref classChoice);

                        // Select Gender
                        Console.WriteLine("Select gender: (M) Male, (F) Female");
                        string gender = Console.ReadLine().ToUpper();
                        while (gender != "M" && gender != "F")
                        {
                            Console.WriteLine("Invalid input. Select gender: (M) Male, (F) Female");
                            gender = Console.ReadLine().ToUpper();
                        }

                        // Select Alignment
                        Console.WriteLine("Select alignment: (LG) Lawful good, (NG) Neutral good, (CG) Chaotic good, (LN) Lawful neutral, (N) Neutral, (CN) Chaotic neutral, (LE) Lawful evil, (NE) Neutral evil, (CE) Chaotic evil");
                        string alignment = Console.ReadLine().ToUpper();
                        while (!IsValidAlignment(alignment))
                        {
                            Console.WriteLine("Invalid input. Select alignment: (LG) Lawful good, (NG) Neutral good, (CG) Chaotic good, (LN) Lawful neutral, (N) Neutral, (CN) Chaotic neutral, (LE) Lawful evil, (NE) Neutral evil, (CE) Chaotic evil");
                            alignment = Console.ReadLine().ToUpper();
                        }

                        // Create the new character
                        Character newCharacter = new Character
                        {
                            Name = characterName,
                            Race = selectedRace,
                            Class = selectedClass,
                            Level = 1, // Default level
                            HitPoints = 10, // Example hit points
                            ProficiencyBonus = 2, // Default proficiency bonus
                            Alignment = alignment, // Set alignment based on user input
                            Gender = (gender == "M") ? "Male" : "Female", // Set gender based on user input
                            Money = 10
                        };

                        // Add the new character to the campaign
                        campaign.Characters.Add(newCharacter);

                        // Ask the user if they want to add another character
                        Console.WriteLine("Do you want to add another character? (yes/no):");
                        string response = Console.ReadLine();
                        addMoreCharacters = response.ToLower() == "yes";
                    }

                    // Save the campaign and characters to the database
                    context.Campaigns.Add(campaign);
                    context.SaveChanges();

                    // Display characters in the campaign
                    var savedCampaign = context.Campaigns.Include(c => c.Characters).FirstOrDefault(c => c.Id == campaign.Id);
                    if (savedCampaign != null)
                    {
                        Console.WriteLine($"Campaign: {savedCampaign.CampaignName}");
                        foreach (var character in savedCampaign.Characters)
                        {
                            Console.WriteLine($"Character: {character.Name}, Race: {character.Race.RaceName}, Class: {character.Class.ClassName}, Gender: {character.Gender}, Alignment: {character.Alignment}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }

        // Helper function to validate alignment input
        private static bool IsValidAlignment(string alignment)
        {
            string[] validAlignments = { "LG", "NG", "CG", "LN", "N", "CN", "LE", "NE", "CE" };
            return Array.Exists(validAlignments, a => a == alignment);
        }

        // Helper function to validate race input
        private static Race GetValidRace(DungeonMasterContext context, ref int raceChoice)
        {
            Race selectedRace = null;
            while (selectedRace == null)
            {
                Console.WriteLine("Select race: (1) Dwarf, (2) Elf, (3) Human, (4) Halfling, (5) Tiefling");
                if (int.TryParse(Console.ReadLine(), out raceChoice) && raceChoice >= 1 && raceChoice <= 5)
                {
                    selectedRace = context.Races.Find(raceChoice);
                }
                if (selectedRace == null)
                {
                    Console.WriteLine("Invalid race choice. Please select one of the available options.");
                }
            }
            return selectedRace;
        }

        // Helper function to validate class input
        private static Class GetValidClass(DungeonMasterContext context, ref int classChoice)
        {
            Class selectedClass = null;
            while (selectedClass == null)
            {
                Console.WriteLine("Select class: (1) Bard, (2) Cleric, (3) Fighter, (4) Rogue, (5) Wizard, (6) Barbarian");
                if (int.TryParse(Console.ReadLine(), out classChoice) && classChoice >= 1 && classChoice <= 6)
                {
                    selectedClass = context.Classes.Find(classChoice);
                }
                if (selectedClass == null)
                {
                    Console.WriteLine("Invalid class choice. Please select one of the available options.");
                }
            }
            return selectedClass;
        }
    }
}





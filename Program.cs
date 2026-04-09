namespace Week10;

class Program
{
    static void Main(string[] args)
    {
        Party party = new Party();
        EventLog eventLog = new EventLog();
        
        party.Add(new Character("Butenko", "Coder", 15, 152, 200, 1000, StatusCharacter.Active));
        party.Add(new Character("Maksimenko", "Disabled", 19, 0, 200, 67, StatusCharacter.Unconscious));
        party.Add(new Character("Kristina", "Psycho", 17, 38, 200, 9760, StatusCharacter.Wounded));
        party.Add(new Character("Vetal", "GoodBoy", 23, 200, 200, 16760, StatusCharacter.Active));

        eventLog.Add(new Event(1, "Suddenly date on coliving", EventType.Hunting, +100));
        eventLog.Add(new Event(2, "Provoke Andrey burst into tears", EventType.Quest, +25));
        eventLog.Add(new Event(3, "Have a nice party with Bahrii", EventType.Chill, 0));
        eventLog.Add(new Event(4, "To play cards against Kolya", EventType.Battle, +50));

        Console.WriteLine();
        foreach (var character in party)
        {
            Console.WriteLine(character);
        }

        Console.WriteLine();
        foreach (var character in party.GetActiveCharacters())
        {
            Console.WriteLine(character);
        }

        Console.WriteLine();
        foreach (var character in party.GetCharactersByLimit(50))
        {
            Console.WriteLine(character);
        }

        Console.WriteLine();
        foreach (var character in eventLog)
        {
            Console.WriteLine(character);
        }

        Console.WriteLine();
        foreach (var character in eventLog.GetTypedEvent(EventType.Hunting))
        {
            Console.WriteLine(character);
        }

        Console.WriteLine();
        foreach (var character in eventLog.GetLastSortedNActions(1))
        {
            Console.WriteLine(character);
        }

        Console.WriteLine();
        var charactersUpperLevel = party.Where(character => character.Level > 18);
        foreach (var character in charactersUpperLevel)
        {
            Console.WriteLine(character);
        }

        Console.WriteLine();
        var sortedByHp = party.OrderBy(character => character.Health);
        foreach (var character in sortedByHp)
        {
            Console.WriteLine(character);
        }

        Console.WriteLine();
        var names = party.Select(character => character.Name);
        foreach (var character in names)
        {
            Console.WriteLine(character);
        }
        
        int maxGold = party.Max(character => character.Gold);
        Character CharacterWithMostGold = party.OrderByDescending(character => character.Gold).First();
        int WoundedPeople = party.Count(character => character.Status ==  StatusCharacter.Wounded);
        double AvgGold = party.Average(character => character.Gold);

        Console.WriteLine();
        Console.WriteLine($"Max Gold: {maxGold}");
        Console.WriteLine($"Richest: {CharacterWithMostGold}");
        Console.WriteLine($"Wounded count: {WoundedPeople}");
        Console.WriteLine($"Average Gold: {AvgGold:F1}");

        Console.WriteLine();
        var gropedRole = party.GroupBy(character => character.Role);
        foreach (var gr in gropedRole)
        {
            Console.WriteLine(gr.Key);
            foreach (var character in gr)
            {
                Console.WriteLine(character.Name);
            }
        }
    }
}
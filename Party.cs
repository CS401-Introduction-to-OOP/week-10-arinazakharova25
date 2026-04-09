namespace Week10;

public class Party : IEnumerable<Character>
{
    private List<Character> characters = new List<Character>();
    public int Count => characters.Count;

    public void Add(Character character)
    {
        characters.Add(character);
    }

    public IEnumerator<Character> GetEnumerator()
    {
        foreach (var character in characters)
        {
            yield return character;
        }
    }

    public IEnumerable<Character> GetActiveCharacters()
    {
        foreach (var character in characters)
        {
            
        }
    }
}